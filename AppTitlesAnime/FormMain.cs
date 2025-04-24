namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void BtnShowTypes_Click_1(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGenreTypes_Click(object sender, EventArgs e)
        {
            FormListGenres formGenreTypes = new FormListGenres();
            formGenreTypes.Show();
        }

        private void btnStatusTypes_Click(object sender, EventArgs e)
        {
            FormListStatus formListStatus = new FormListStatus();
            formListStatus.Show();
        }
    }
}
