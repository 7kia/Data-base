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
    public partial class RateForm : Form
    {
        private MySqlWrapper m_mySqlWrapper = new MySqlWrapper();
        private bool m_create = true;
        private CRate m_rate;
        private OpenFileDialog m_openFileDialogPhoto;

        public RateForm()
        {
            InitializeComponent();

            InitOpenFileDialog();
            m_rate = new CRate();

            FillFields();
        }
        public RateForm(CRate rate)
        {
            InitializeComponent();

            InitOpenFileDialog();

            m_rate = rate;
            m_create = false;

            FillFields();
        }

        public void InitOpenFileDialog()
        {
            m_openFileDialogPhoto = new OpenFileDialog();
            m_openFileDialogPhoto.InitialDirectory = "c:\\Study\\БД\\РГР\\GCW\\res\\";
            m_openFileDialogPhoto.Filter = "Image Files (*.bmp)|*.bmp";
            m_openFileDialogPhoto.RestoreDirectory = true;
        }

        private void FillFields()
        {
            textBoxNameRate.Text = m_rate.NameRate;
            textBoxRate.Text = m_rate.Rate.ToString();
            LogoTextBox.Text = m_rate.PathLogo;
        }

        private bool CheckFields()
        {
            if (textBoxNameRate.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Название тарифа\"", "Ошибка");
                return false;
            }

            uint res;
            if (!uint.TryParse(textBoxRate.Text, out res))
            {
                MessageBox.Show("В поле \"Тариф\" должно быть положительное целое число", "Ошибка");
                return false;
            }
            if (textBoxRate.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле \"Тариф\"", "Ошибка");
                return false;
            }

            if (LogoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите путь к \"logo кампании\"", "Ошибка");
                return false;
            }

            try
            {
                Image img = Image.FromFile(LogoTextBox.Text);
            }
            catch (System.IO.FileNotFoundException exception)
            {
                MessageBox.Show("Путь к \"logo кампании\" некорректен", "Ошибка");
                return false;
            }


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            m_rate.NameRate = textBoxNameRate.Text;
            m_rate.Rate = uint.Parse(textBoxRate.Text);
            m_rate.PathLogo = LogoTextBox.Text;

            if (m_create)
            {
                m_mySqlWrapper.AddRate(m_rate);
            }
            else
            {
                m_mySqlWrapper.UpdateRate(m_rate);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void LogoTextBox_Click(object sender, EventArgs e)
        {
            DialogResult dlg = m_openFileDialogPhoto.ShowDialog();
            if (dlg == DialogResult.OK)
            {

                Image image = Image.FromFile(m_openFileDialogPhoto.FileName);
                if ((image.Height > 640) || (image.Width > 640))
                {
                    MessageBox.Show("Максимальное разрещение изображения 640 x 640", "Ошибка");
                    return;
                }

                LogoTextBox.Text = m_openFileDialogPhoto.FileName;
            }
            else
            {
                MessageBox.Show("По заданному пути не удалось открыть картинку");
            }
        }

        private void LogoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void seeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(LogoTextBox.Text);
            }
            catch (System.IO.FileNotFoundException exception)
            {
                MessageBox.Show("Путь к \"logo кампании\" некорректен", "Ошибка");
                return;
            }

            PhotoForm form = new PhotoForm(LogoTextBox.Text);
            form.ShowDialog();
        }
    }
}
