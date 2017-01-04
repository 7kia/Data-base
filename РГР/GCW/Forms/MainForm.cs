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
            m_currentMainTable = Table.Service;// TODO : rewrite, must be other

            // initialize context menu
            dataGridView_MainTable.ContextMenuStrip = contextMenuStrip;
            dataGridView_DependentTable.ContextMenuStrip = contextMenuStripDependent;

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
                case Table.RateOfPayment:
                    FillRateOfPaymentTable(m_mySqlWrapper.GetListOfRateOfPayment(filter, include, orderBy));
                    break;
                case Table.Service:
                    FillServiceTable(m_mySqlWrapper.GetListOfService(filter, include, orderBy));
                    break;
                case Table.TypeOfSettlement:
                    FillTypeOfSettlementTable(m_mySqlWrapper.GetListOfTypeOfSettlement(filter, include, orderBy));
                    break;
            }
        }

        private void FillDependentTable(string filter = "", string include = "", string orderBy = "")
        {
            // TODO : see need it, check correctness     
        }

        ///////////////////////////////////////////////////////////////////
        /// Filling tables

        private void FillServiceTable(IEnumerable<CService> service)
        {
            dataGridView_MainTable.DataSource = service;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Название";
        }

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
            dataGridView_MainTable.Columns[1].HeaderText = "Id квартиры";
            dataGridView_MainTable.Columns[2].HeaderText = "Номер платежа";
        }
        private void FillRateTable(IEnumerable<CRate> rate)
        {
            dataGridView_MainTable.DataSource = rate;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Id услуги";
            dataGridView_MainTable.Columns[2].HeaderText = "Id типа населённого пункта";
            dataGridView_MainTable.Columns[3].HeaderText = "Тариф";
        }
        private void FillRateOfPaymentTable(IEnumerable<CRateOfPayment> rateOfPayment)
        {
            dataGridView_MainTable.DataSource = rateOfPayment;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Id тарифа";
            dataGridView_MainTable.Columns[2].HeaderText = "Id платежа";
            dataGridView_MainTable.Columns[3].HeaderText = "Оплачено";
        }
        private void FillTypeOfSettlementTable(IEnumerable<CTypeOfSettlement> typeOfSettlement)
        {
            dataGridView_MainTable.DataSource = typeOfSettlement;
            dataGridView_MainTable.Columns[0].HeaderText = "Id";
            dataGridView_MainTable.Columns[1].HeaderText = "Название";
        }

        ///////////////////////////////////////////////////////////////////
        /// ToolStripMenuItem_Click
        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.Service)
                return;

            m_currentMainTable = Table.Service;
            FillMainTable();
            FillDependentTable();
        }

        private void типНаселённогоПунктаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.TypeOfSettlement)
                return;

            m_currentMainTable = Table.TypeOfSettlement;
            FillMainTable();
            FillDependentTable();
        }

        private void тарифВПлатежеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_currentMainTable == Table.RateOfPayment)
                return;

            m_currentMainTable = Table.RateOfPayment;
            FillMainTable();
            FillDependentTable();
        }

        private void тарифToolStripMenuItem_Click(object sender, EventArgs e)
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
                case Table.RateOfPayment:
                    RateOfPaymentForm rateOfPaymentFormForm = new RateOfPaymentForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CRateOfPayment);
                    if (rateOfPaymentFormForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Service:
                    ServiceForm serviceForm = new ServiceForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CService);
                    if (serviceForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.TypeOfSettlement:
                    TypeOfSettlementForm typeOfSettlementform = new TypeOfSettlementForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CTypeOfSettlement);
                    if (typeOfSettlementform.ShowDialog() == DialogResult.OK)
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
                case Table.RateOfPayment:
                    RateOfPaymentForm rateOfPaymentFormForm = new RateOfPaymentForm();
                    if (rateOfPaymentFormForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.Service:
                    ServiceForm serviceForm = new ServiceForm();
                    if (serviceForm.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.TypeOfSettlement:
                    TypeOfSettlementForm typeOfSettlementform = new TypeOfSettlementForm();
                    if (typeOfSettlementform.ShowDialog() == DialogResult.OK)
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
                case Table.RateOfPayment:
                    var recordRateOfPayment = dataGridView_MainTable.CurrentRow.DataBoundItem as CRateOfPayment;
                    m_mySqlWrapper.RemoveRateOfPayment(recordRateOfPayment);
                    FillMainTable();
                    break;
                case Table.Service:
                    var recordService = dataGridView_MainTable.CurrentRow.DataBoundItem as CService;
                    m_mySqlWrapper.RemoveService(recordService);
                    FillMainTable();
                    break;
                case Table.TypeOfSettlement:
                    var recordTypeOfSettlement = dataGridView_MainTable.CurrentRow.DataBoundItem as CTypeOfSettlement;
                    m_mySqlWrapper.RemoveTypeOfSettlement(recordTypeOfSettlement);
                    FillMainTable();
                    break;
            }
        }
        ///////////////////////////////////////////////////////////////////

    }
}
