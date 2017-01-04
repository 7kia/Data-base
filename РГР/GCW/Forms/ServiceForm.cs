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
    public partial class ServiceForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CService m_service;

        public ServiceForm()
        {
            InitializeComponent();
            m_service = new CService();
        }
        public ServiceForm(CService service)
        {
            InitializeComponent();
            m_service = service;
            m_create = false;
            FillFields();
        }

        private void FillFields()
        {
            textName.Text = m_service.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_service.Name = textName.Text;

            if (m_create)
            {
                m_mySqlWrapper.AddService(m_service);
            }
            else
            {
                m_mySqlWrapper.UpdateService(m_service);
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

    }
}
