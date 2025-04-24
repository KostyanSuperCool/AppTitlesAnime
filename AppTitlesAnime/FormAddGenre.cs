using System.Windows.Forms.VisualStyles; // Подключение пространства имен для визуальных стилей Windows Forms
using System.Windows.Forms; // Подключение пространства имен для Windows Forms
using AppContext = AppTitlesAnime.Models.AppContext; // Создание псевдонима для AppContext

namespace AppTitlesAnime // Определение пространства имен
{
    public partial class FormAddGenre : Form // Определение класса формы для добавления жанра
    {
        private Models.AppContext db; // Объявление переменной для контекста базы данных

        public FormAddGenre() // Конструктор формы
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        protected override void OnLoad(EventArgs e) // Переопределение метода OnLoad
        {
            base.OnLoad(e); // Вызов базового метода
            this.db = new AppContext(); // Инициализация контекста базы данных
        }

        private void btnCancelGenre_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Отмена"
        {
            // Здесь можно добавить логику для обработки нажатия кнопки "Отмена", например, закрытие формы
        }

        private void TextBoxTypeNameGenre_Validated(object sender, EventArgs e) // Обработчик события валидации текстового поля
        {
            if (String.IsNullOrEmpty(textBoxTypeNameGenre.Text)) // Проверка, пустое ли поле
            {
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Поле не может быть пустым!"); // Установка сообщения об ошибке
                btnSaveChangesGenre.Enabled = false; // Отключение кнопки сохранения
            }
            else
            {
                errorProviderGenre1.Clear(); // Очистка сообщения об ошибке
                btnSaveChangesGenre.Enabled = true; // Включение кнопки сохранения
            }
        }

        private void textBoxTypeNameGenre_TextChanged(object sender, EventArgs e) // Обработчик события изменения текста в текстовом поле
        {
            if (String.IsNullOrEmpty(textBoxTypeNameGenre.Text)) // Проверка, пустое ли поле
            {
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Поле не может быть пустым!"); // Установка сообщения об ошибке
                btnSaveChangesGenre.Enabled = false; // Отключение кнопки сохранения
            }
            else
            {
                errorProviderGenre1.Clear(); // Очистка сообщения об ошибке
                btnSaveChangesGenre.Enabled = true; // Включение кнопки сохранения
            }
            FormAddGenre formAddGenre = new FormAddGenre(); // Создание нового экземпляра формы (не обязательно)
            string newGenreAnime = textBoxTypeNameGenre.Text; // Сохранение текста в переменную newGenreAnime

            bool exists = db.Genres.Any(t => t.GenreName == newGenreAnime); // Проверка, существует ли жанр с таким именем
            if (exists) // Если жанр существует
            {
                btnSaveChangesGenre.Enabled = false; // Отключение кнопки сохранения
                errorProviderGenre1.SetError(textBoxTypeNameGenre, "Такой жанр уже есть"); // Установка сообщения об ошибке
            }
            else
            {
                errorProviderGenre1.Clear(); // Очистка сообщения об ошибке
                btnSaveChangesGenre.Enabled = true; // Включение кнопки сохранения
            }
        }
    }
}