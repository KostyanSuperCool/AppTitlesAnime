using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        private Models.AppContext db;
        public FormAddGenre()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
        }
        private void btnCancelGenre_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTypeNameGenre_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeNameGenre.Text))
            {
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Поле не может быть пустым!");
                btnSaveChangesGenre.Enabled = false;
            }
            else
            {
                errorProviderGenre1.Clear();
                btnSaveChangesGenre.Enabled = true;
            }
            FormAddGenre formAddGenre = new FormAddGenre();
            string newGenreAnime = textBoxTypeNameGenre.Text;//сохраняем текст в newStatusAnime

            bool exists = db.Genres.Any(t => t.GenreName == newGenreAnime);
            if (exists)
            {
                btnSaveChangesGenre.Enabled = false;//уходим в ошибку 
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Такой жанр уже есть");

            }
            else
            {
                errorProviderGenre1.Clear();
                btnSaveChangesGenre.Enabled = true;//пропускаем

            }
        }
        private void textBoxTypeNameGenre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeNameGenre.Text))
            {
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Поле не может быть пустым!");
                btnSaveChangesGenre.Enabled = false;
            }
            else
            {
                errorProviderGenre1.Clear();
                btnSaveChangesGenre.Enabled = true;
            }
        }
    }
}
