using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGW;
using CGW.Forms;
using GCW.Entities;

namespace GCW.Forms
{
    public partial class MainForm : Form
    {
        // private members
        private MySqlWrapper m_mySqlWrapper;
        private Table m_currentMainTable;

        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        // private methods
        private void InitializeMainForm()
        {
            m_mySqlWrapper = new MySqlWrapper();
            m_currentMainTable = Table.Apartments;// TODO : rewrite, must be other

            // initialize context menu
            dataGridView_MainTable.ContextMenuStrip = contextMenuStrip;

            FillMainTable();
            FillDependentTable();
        }

        ///////////////////////////////////////////////////////////////////
        private void FillMainTable(string filter = "", string include = "", string orderBy = "")
        {
            switch (m_currentMainTable)
            {
                case Table.Apartments:
                    FillApartmentsTable(m_mySqlWrapper.GetListOfApartments(filter, include, orderBy));
                    break;
                case Table.Payment:
                    FillPaymentTable(m_mySqlWrapper.GetListOfPayment(filter, include, orderBy));
                    break;
                case Table.Rate:
                    FillRateTable(m_mySqlWrapper.GetListOfRate(filter, include, orderBy));
                    break;
                case Table.ServiceToApartment:
                    FillRateOfPaymentTable(m_mySqlWrapper.GetListOfServiceToApartment(filter, include, orderBy));
                    break;
            }
        }

        private void FillDependentTable(string filter = "", string include = "", string orderBy = "")
        {
            // TODO : see need it, check correctness     
        }

        ///////////////////////////////////////////////////////////////////
        /// Filling tables


        private void FillApartmentsTable(IEnumerable<CApartments> apartments)
        {

            dataGridView_MainTable.DataSource = apartments;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Адрес";
            dataGridView_MainTable.Columns[2].HeaderText = "Номер платежа";
        }
        private void FillPaymentTable(IEnumerable<CPayment> payment)
        {
            dataGridView_MainTable.DataSource = payment;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Номер платежа";
            dataGridView_MainTable.Columns[2].HeaderText = "Дата";
            dataGridView_MainTable.Columns[3].HeaderText = "Сумма";

        }
        private void FillRateTable(IEnumerable<CRate> rate)
        {
            dataGridView_MainTable.DataSource = rate;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Название тарифа";
            dataGridView_MainTable.Columns[2].HeaderText = "Тариф";
        }
        private void FillRateOfPaymentTable(IEnumerable<CServiceToApartment> rateOfPayment)
        {
            dataGridView_MainTable.DataSource = rateOfPayment;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Id квартиры";
            dataGridView_MainTable.Columns[2].HeaderText = "Id услуги";
        }

        ///////////////////////////////////////////////////////////////////
        /// ToolStripMenuItem_Click
        private void услугиВКвартиреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.ServiceToApartment)
                return;

            m_currentMainTable = Table.ServiceToApartment;
            FillMainTable();
            FillDependentTable();
        }

        private void тарифУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.Rate)
                return;

            m_currentMainTable = Table.Rate;
            FillMainTable();
            FillDependentTable();
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.Payment)
                return;

            m_currentMainTable = Table.Payment;
            FillMainTable();
            FillDependentTable();
        }

        private void квартирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.Apartments)
                return;

            m_currentMainTable = Table.Apartments;
            FillMainTable();
            FillDependentTable();
        }


       

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_MainTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите запись для изменения");
                return;
            }


            switch (m_currentMainTable)
            {
                case Table.Apartments:
                    ApartmentForm apartmentForm = new ApartmentForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CApartments);
                    if (apartmentForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Payment:
                    PaymentForm paymentForm = new PaymentForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CPayment);
                    if (paymentForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Rate:
                    RateForm rateForm = new RateForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CRate);
                    if (rateForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.ServiceToApartment:
                    ServiceToApartment rateOfPaymentFormForm = new ServiceToApartment(dataGridView_MainTable.CurrentRow.DataBoundItem as CServiceToApartment);
                    if (rateOfPaymentFormForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (m_currentMainTable)
            {
                case Table.Apartments:
                    ApartmentForm apartmentForm = new ApartmentForm();
                    if (apartmentForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Payment:
                    PaymentForm paymentForm = new PaymentForm();
                    if (paymentForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Rate:
                    RateForm rateForm = new RateForm();
                    if (rateForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.ServiceToApartment:
                    ServiceToApartment rateOfPaymentFormForm = new ServiceToApartment();
                    if (rateOfPaymentFormForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;

            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_MainTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите запись для удаления");
                return;
            }

            switch (m_currentMainTable)
            {
                case Table.Apartments:
                    var recordApartments = dataGridView_MainTable.CurrentRow.DataBoundItem as CApartments;
                    m_mySqlWrapper.RemoveApartment(recordApartments);
                    FillMainTable();
                    break;
                case Table.Payment:
                    var recordPayment = dataGridView_MainTable.CurrentRow.DataBoundItem as CPayment;
                    m_mySqlWrapper.RemovePayment(recordPayment);
                    FillMainTable();
                    break;
                case Table.Rate:
                    var recordRate = dataGridView_MainTable.CurrentRow.DataBoundItem as CRate;
                    m_mySqlWrapper.RemoveRate(recordRate);
                    FillMainTable();
                    break;
                case Table.ServiceToApartment:
                    var recordRateOfPayment = dataGridView_MainTable.CurrentRow.DataBoundItem as CServiceToApartment;
                    m_mySqlWrapper.RemoveServiceToApartment(recordRateOfPayment);
                    FillMainTable();
                    break;
            }
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch(m_currentMainTable)
            {
                case Table.Apartments:
                    {
                        var form = new ApartmentFiltrationForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FillMainTable(form.filter, form.include, form.orderBy);
                        }
                    }
                    break;
                case Table.Payment:
                    {
                        var form = new PaymentFiltrationForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FillMainTable(form.filter, form.include, form.orderBy);
                        }
                    }
                    break;
                case Table.Rate:
                    {
                        var form = new RateFiltrationForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FillMainTable(form.filter, form.include, form.orderBy);
                        }
                    }
                    break;
                case Table.ServiceToApartment:
                    {
                        var form = new ServiceToApartmentFiltrarion(m_mySqlWrapper.m_connection);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            FillMainTable(form.filter, form.include, form.orderBy);
                        }
                    }
                    break;
            }
        }
        ///////////////////////////////////////////////////////////////////

    }
}
