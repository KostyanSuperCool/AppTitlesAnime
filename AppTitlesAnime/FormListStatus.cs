using System.Data; // Подключение пространства имен для работы с данными
using AppTitlesAnime.Models; // Подключение моделей приложения
using Microsoft.EntityFrameworkCore; // Подключение Entity Framework Core
using AppContext = AppTitlesAnime.Models.AppContext; // Создание псевдонима для контекста приложения

namespace AppTitlesAnime // Определение пространства имен
{
    public partial class FormListStatus : Form // Определение класса формы для списка статусов
    {
        private AppContext db; // Объявление переменной для контекста базы данных

        public FormListStatus() // Конструктор формы
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        protected override void OnLoad(EventArgs e) // Переопределение метода загрузки формы
        {
            base.OnLoad(e); // Вызов базового метода
            this.db = new AppContext(); // Инициализация контекста базы данных
            this.db.Statuses.Load(); // Загрузка статусов из базы данных
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Установка источника данных для DataGridView

            dataGridViewStatus.Columns["Id"].Visible = false; // Скрытие колонки Id
            dataGridViewStatus.Columns["TitlesStatuses"].Visible = false; // Скрытие колонки TitlesStatuses

            dataGridViewStatus.Columns["StatusName"].HeaderText = "Тип статуса"; // Изменение заголовка колонки StatusName
        }

        protected override void OnClosed(EventArgs e) // Переопределение метода закрытия формы
        {
            base.OnClosed(e); // Вызов базового метода
            this.db?.Dispose(); // Освобождение ресурсов контекста базы данных
            this.db = null; // Установка контекста в null
        }

        private void BtnAddStatus_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки добавления статуса
        {
            FormAddStatus formAddStatus = new(); // Создание новой формы для добавления статуса
            DialogResult result = formAddStatus.ShowDialog(this); // Показ формы как диалогового окна
            if (result == DialogResult.Cancel) // Проверка, была ли форма закрыта с помощью кнопки "Отмена"
                return;

            Status status = new Status(); // Создание нового объекта статуса
            status.StatusName = formAddStatus.textBoxStatusName.Text; // Установка имени статуса из текстового поля

            db.Statuses.Add(status); // Добавление нового статуса в контекст базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Новый Статус добавлен"); // Сообщение об успешном добавлении статуса

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновление источника данных для DataGridView
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки обновления статуса
        {
            if (dataGridViewStatus.SelectedRows.Count == 0) // Проверка, выбрана ли хотя бы одна строка
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Объявление переменной для хранения идентификатора статуса
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id); // Попытка преобразовать значение в идентификатор
            if (!converted) // Проверка успешности преобразования
                return;

            Status status = db.Statuses.Find(id); // Поиск статуса по идентификатору
            FormAddStatus formAddStatus = new(); // Создание новой формы для редактирования статуса
            formAddStatus.textBoxStatusName.Text = status.StatusName; // Установка имени статуса в текстовое поле

            DialogResult result = formAddStatus.ShowDialog(this); // Показ формы как диалогового окна

            if (result == DialogResult.Cancel) // Проверка, была ли форма закрыта с помощью кнопки "Отмена"
                return;

            status.StatusName = formAddStatus.textBoxStatusName.Text; // Обновление имени статуса
            db.Statuses.Update(status); // Обновление статуса в контексте базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Статус изменен"); // Сообщение об успешном обновлении статуса

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновление источника данных для DataGridView
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки удаления статуса
        {
            if (dataGridViewStatus.SelectedRows.Count == 0) // Проверка, выбрана ли хотя бы одна строка
                return;

            // Запрос подтверждения удаления
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить эту строку? \nВсе связанные данные будут удалены.", // Сообщение для пользователя
                "", // Заголовок окна
                MessageBoxButtons.YesNo, // Кнопки "Да" и "Нет"
                MessageBoxIcon.Question // Иконка вопроса
            );

            if (result == DialogResult.No) // Проверка, выбрал ли пользователь "Нет"
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index; // Получение индекса выбранной строки
            short id = 0; // Объявление переменной для хранения идентификатора статуса
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id); // Попытка преобразовать значение в идентификатор
            if (!converted) // Проверка успешности преобразования
                return;

            Status status = db.Statuses.Find(id); // Поиск статуса по идентификатору
            db.Statuses.Remove(status); // Удаление статуса из контекста базы данных
            db.SaveChanges(); // Сохранение изменений в базе данных

            MessageBox.Show("Строка удалена "); // Сообщение об успешном удалении статуса
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновление источника данных для DataGridView
        }
    }
}
