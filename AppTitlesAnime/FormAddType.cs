using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        private AppContext db;
        public FormAddType()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
            FormAddType formAddType = new FormAddType();
            string newTypeAnime = textBoxTypeName.Text;//сохраняем текст в newStatusAnime

            bool exists = db.Types.Any(t => t.TypeName == newTypeAnime);
            if (exists)
            {
                btnSaveChanges.Enabled = false;//уходим в ошибку 
                errorProvider.SetError(textBoxTypeName, "Такой жанр уже есть");

            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;//пропускаем

            }
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {

        }
    }
}
