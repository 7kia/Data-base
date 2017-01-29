using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCW.Forms
{
    public partial class PhotoForm : Form
    {
        private Image m_image;
        public PhotoForm(string path)
        {
            InitializeComponent();
            m_image = Image.FromFile(path);
            pictureBox.Image = m_image;
        }
    }
}
