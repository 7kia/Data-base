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
using GCW.Entities;

namespace GCW.Forms
{
    public partial class TypeOfSettlementForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CTypeOfSettlement m_typeOfSettlement;

        public TypeOfSettlementForm()
        {
            InitializeComponent();
            m_typeOfSettlement = new CTypeOfSettlement();
        }
        public TypeOfSettlementForm(CTypeOfSettlement typeOfSettlement)
        {
            InitializeComponent();
            m_typeOfSettlement = typeOfSettlement;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            textName.Text = m_typeOfSettlement.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_typeOfSettlement.Name = textName.Text;

            if (m_create)
            {
                m_mySqlWrapper.AddTypeOfSettlement(m_typeOfSettlement);
            }
            else
            {
                m_mySqlWrapper.UpdateTypeOfSettlement(m_typeOfSettlement);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckFields()
        {
            if (textName.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Название\"", "Ошибка");
                return false;
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_typeOfSettlement.Name = textName.Text;

            if (m_create)
            {
                m_mySqlWrapper.AddTypeOfSettlement(m_typeOfSettlement);
            }
            else
            {
                m_mySqlWrapper.UpdateTypeOfSettlement(m_typeOfSettlement);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
