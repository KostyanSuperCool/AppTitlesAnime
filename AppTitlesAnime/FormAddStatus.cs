using System.ComponentModel; // Подключение пространства имен для работы с компонентами и событиями
using AppContext = AppTitlesAnime.Models.AppContext; // Создание псевдонима для AppContext

namespace AppTitlesAnime // Определение пространства имен
{
    public partial class FormAddStatus : Form // Определение класса формы для добавления статуса
    {
        private AppContext db; // Объявление переменной для контекста базы данных

        public FormAddStatus() // Конструктор формы
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        protected override void OnLoad(EventArgs e) // Переопределение метода OnLoad
        {
            base.OnLoad(e); // Вызов базового метода
            this.db = new AppContext(); // Инициализация контекста базы данных
        }

        private void FormAddStatus_Validating(object sender, CancelEventArgs e) // Обработчик события валидации формы
        {
            // Здесь можно добавить логику валидации формы, если необходимо
        }

        private void textBoxStatusName_Validating(object sender, CancelEventArgs e) // Обработчик события валидации текстового поля
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text)) // Проверка, пустое ли поле
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым!"); // Установка сообщения об ошибке
                btnSaveChangeStatus.Enabled = false; // Отключение кнопки сохранения
            }
            else
            {
                errorProvider.Clear(); // Очистка сообщения об ошибке
                btnSaveChangeStatus.Enabled = true; // Включение кнопки сохранения
            }
        }

        private void TextBoxStatusName_TextChanged(object sender, EventArgs e) // Обработчик события изменения текста в текстовом поле
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text)) // Проверка, пустое ли поле
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым!"); // Установка сообщения об ошибке
                btnSaveChangeStatus.Enabled = false; // Отключение кнопки сохранения
            }
            else
            {
                errorProvider.Clear(); // Очистка сообщения об ошибке
                btnSaveChangeStatus.Enabled = true; // Включение кнопки сохранения
            }
            FormAddStatus formAddStatus = new FormAddStatus(); // Создание нового экземпляра формы (не обязательно)
            string newStatusAnime = textBoxStatusName.Text; // Сохранение текста в переменную newStatusAnime

            bool exists = db.Statuses.Any(t => t.StatusName == newStatusAnime); // Проверка, существует ли статус с таким именем
            if (exists) // Если статус существует
            {
                btnSaveChangeStatus.Enabled = false; // Отключение кнопки сохранения
                errorProvider.SetError(textBoxStatusName, "Такой статус уже есть"); // Установка сообщения об ошибке
            }
            else
            {
                errorProvider.Clear(); // Очистка сообщения об ошибке
                btnSaveChangeStatus.Enabled = true; // Включение кнопки сохранения
            }
        }
    }
}