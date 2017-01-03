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
                case Table.Service:
                    FillServiceTable(m_mySqlWrapper.GetListOfService(filter, include, orderBy));
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
        ///////////////////////////////////////////////////////////////////

    }
}
