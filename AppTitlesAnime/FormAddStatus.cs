using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        private AppContext db;
        public FormAddStatus()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
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
            FormAddStatus formAddStatus = new FormAddStatus();
            string newStatusAnime = textBoxStatusName.Text;//сохраняем текст в newStatusAnime

            bool exists = db.Statuses.Any(t => t.StatusName == newStatusAnime);
            if (exists)
            {
                btnSaveChangeStatus.Enabled = false;//уходим в ошибку 
                errorProvider.SetError(textBoxStatusName, "Такой жанр уже есть");

            }
            else
            {
                errorProvider.Clear();
                btnSaveChangeStatus.Enabled = true;//пропускаем

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
