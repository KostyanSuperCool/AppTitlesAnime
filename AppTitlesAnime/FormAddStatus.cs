using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        public FormAddStatus()
        {
            InitializeComponent();
        }

        private void FormAddStatus_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxStatusName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым!");
                btnSaveChangeStatus.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChangeStatus.Enabled = true;
            }
        }

        private void TextBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым!");
                btnSaveChangeStatus.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChangeStatus.Enabled = true;
            }
        }
    }
}
