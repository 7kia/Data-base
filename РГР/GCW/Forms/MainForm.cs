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

    }
}
