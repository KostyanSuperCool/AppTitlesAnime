using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;
        public FormListGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewTypes.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["TitlesGenres"].Visible = false;

            dataGridViewTypes.Columns["GenreName"].HeaderText = "Тип жанра";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddGenreType_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxTypeNameGenre.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
        private void BtnUpdateGenreType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxTypeNameGenre.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formAddGenre.textBoxTypeNameGenre.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewTypes.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void btnDeleteGenreType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;


            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить эту строку? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if(result == DialogResult.No)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            db.Genres.Remove(genre);
            db.SaveChanges();

            MessageBox.Show("Строка удалена ");
            this.dataGridViewTypes.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
