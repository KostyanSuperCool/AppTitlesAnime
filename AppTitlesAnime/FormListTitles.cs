using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using AppContext = AppTitlesAnime.Models.AppContext;
using Type = AppTitlesAnime.Models.Type;

namespace AppTitlesAnime
{
    public partial class FormListTitles : Form
    {
        private AppContext db;
        public FormListTitles()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitiles.Load();
            this.dataGridViewTitles.DataSource = this.db.AnimeTitiles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();

            //Скрытие столбцов
            dataGridViewTitles.Columns["Id"].Visible = false;

            //Изменение названий заголовков столбцов
            dataGridViewTitles.Columns["TypeName"].HeaderText = "Тип";
            dataGridViewTitles.Columns["OriginalName"].HeaderText = "Оригинальное название";
            dataGridViewTitles.Columns["Name"].HeaderText = "Название";
            dataGridViewTitles.Columns["CountSeries"].HeaderText = "Количество серий";
            dataGridViewTitles.Columns["Duration"].HeaderText = "Продолжительность";
            dataGridViewTitles.Columns["Studio"].HeaderText = "Студия";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            FormAddUpdateTitle formAddUpdateTitle = new FormAddUpdateTitle();

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTitle.comboBoxType.ValueMember = "Id";

            DialogResult result = formAddUpdateTitle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            AnimeTitile animeTitile = new()
            {
                OriginalName = formAddUpdateTitle.textBoxOriginalName.Text,
                Name = formAddUpdateTitle.textBoxName.Text,
                CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSeries.Value),
                Duration = Convert.ToInt16(formAddUpdateTitle.numUpDownDuration.Value),
                Studio = formAddUpdateTitle.textBoxStudio.Text,
                Description = formAddUpdateTitle.textBoxDescription.Text
            };

            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
            animeTitile.IdType = type.Id;
            db.AnimeTitiles.Add(animeTitile);
            db.SaveChanges();
            MessageBox.Show("Новый объект добавлен",
                "Добавлен",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.dataGridViewTitles.DataSource = this.db.AnimeTitiles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                })
                .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();
        }

        private void BtnUpdateTitle_Click(object sender, EventArgs e)
        {
            if(dataGridViewTitles.SelectedRows.Count == 0) 
                return;

            int index = dataGridViewTitles.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewTitles[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeTitile animeTitile = db.AnimeTitiles.Find(id)!;
            FormAddUpdateTitle formAddUpdateTitle = new();

            formAddUpdateTitle.textBoxOriginalName.Text = animeTitile.OriginalName;
            formAddUpdateTitle.textBoxName.Text = animeTitile.Name;
            formAddUpdateTitle.numUpDownCountSeries.Value = animeTitile.CountSeries;
            formAddUpdateTitle.numUpDownDuration.Value = animeTitile.Duration;
            formAddUpdateTitle.textBoxStudio.Text = animeTitile.Studio;
            formAddUpdateTitle.textBoxDescription.Text = animeTitile.Description;

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTitle.comboBoxType.ValueMember = "Id";

            formAddUpdateTitle.comboBoxType.SelectedItem = animeTitile.Type;

            DialogResult result = formAddUpdateTitle.ShowDialog();

            if(result == DialogResult.Cancel)
                return;


            animeTitile.OriginalName = formAddUpdateTitle.textBoxOriginalName.Text;
            animeTitile.Name = formAddUpdateTitle.textBoxName.Text;
            animeTitile.CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSeries.Value);
            animeTitile.Duration = Convert.ToInt16(formAddUpdateTitle.numUpDownDuration.Value);
            animeTitile.Studio = formAddUpdateTitle.textBoxStudio.Text;
            animeTitile.Description = formAddUpdateTitle.textBoxDescription.Text;
          

            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
            animeTitile.IdType = type.Id;

            db.AnimeTitiles.Update(animeTitile);
            db.SaveChanges();

            MessageBox.Show("Объект изменён",
                "Изменён",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.dataGridViewTitles.DataSource = this.db.AnimeTitiles
               .Include(i => i.Type)
               .Select(i => new
               {
                   i.Id,
                   i.Type.TypeName,
                   i.OriginalName,
                   i.Name,
                   i.CountSeries,
                   i.Duration,
                   i.Studio
               })
               .OrderBy(i => i.TypeName).ThenBy(i => i.OriginalName).ToList();
        
        }
    }
}
