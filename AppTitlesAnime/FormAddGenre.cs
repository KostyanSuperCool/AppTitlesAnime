namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
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
