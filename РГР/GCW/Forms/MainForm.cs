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


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_MainTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите запись для удаления");
                return;
            }

            switch (m_currentMainTable)
            {
                case Table.Apartments:
                    break;
                case Table.Payment:
                    break;
                case Table.Rate:
                    break;
                case Table.RateOfPayment:
                    break;
                case Table.Service:
                    var record = dataGridView_MainTable.CurrentRow.DataBoundItem as CService;
                    m_mySqlWrapper.RemoveService(record);
                    FillMainTable();
                    break;
                case Table.TypeOfSettlement:
                    break;
            }
           
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
                    break;
                case Table.Payment:
                    break;
                case Table.Rate:
                    break;
                case Table.RateOfPayment:
                    break;
                case Table.Service:
                    ServiceForm form = new ServiceForm(dataGridView_MainTable.CurrentRow.DataBoundItem as CService);
                    if (form.ShowDialog() == DialogResult.OK)
                        FillMainTable();
                    break;
                case Table.TypeOfSettlement:
                    break;
            }
        }
        ///////////////////////////////////////////////////////////////////

    }
}
