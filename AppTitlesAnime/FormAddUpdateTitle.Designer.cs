﻿namespace AppTitlesAnime
{
    partial class FormAddUpdateTitle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFill = new Panel();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxStudio = new TextBox();
            labelStudio = new Label();
            numUpDownDuration = new NumericUpDown();
            labelDuration = new Label();
            numUpDownCountSeries = new NumericUpDown();
            labelCountSeries = new Label();
            comboBoxType = new ComboBox();
            labelType = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            textBoxOriginalName = new TextBox();
            labelOriginalName = new Label();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSeries).BeginInit();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxDescription);
            panelFill.Controls.Add(labelDescription);
            panelFill.Controls.Add(textBoxStudio);
            panelFill.Controls.Add(labelStudio);
            panelFill.Controls.Add(numUpDownDuration);
            panelFill.Controls.Add(labelDuration);
            panelFill.Controls.Add(numUpDownCountSeries);
            panelFill.Controls.Add(labelCountSeries);
            panelFill.Controls.Add(comboBoxType);
            panelFill.Controls.Add(labelType);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(flowLayoutPanelBottom);
            panelFill.Controls.Add(textBoxOriginalName);
            panelFill.Controls.Add(labelOriginalName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(884, 581);
            panelFill.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(10, 383);
            textBoxDescription.Margin = new Padding(3, 15, 3, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(854, 127);
            textBoxDescription.TabIndex = 14;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Location = new Point(10, 358);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 13;
            labelDescription.Text = "Описание";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Dock = DockStyle.Top;
            textBoxStudio.Location = new Point(10, 325);
            textBoxStudio.Margin = new Padding(3, 15, 3, 3);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(854, 33);
            textBoxStudio.TabIndex = 12;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Dock = DockStyle.Top;
            labelStudio.Location = new Point(10, 300);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 11;
            labelStudio.Text = "Студия";
            // 
            // numUpDownDuration
            // 
            numUpDownDuration.Dock = DockStyle.Top;
            numUpDownDuration.Location = new Point(10, 267);
            numUpDownDuration.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numUpDownDuration.Name = "numUpDownDuration";
            numUpDownDuration.Size = new Size(854, 33);
            numUpDownDuration.TabIndex = 10;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Dock = DockStyle.Top;
            labelDuration.Location = new Point(10, 242);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(296, 25);
            labelDuration.TabIndex = 9;
            labelDuration.Text = "Продолжительность серии, мин.";
            // 
            // numUpDownCountSeries
            // 
            numUpDownCountSeries.Dock = DockStyle.Top;
            numUpDownCountSeries.Location = new Point(10, 209);
            numUpDownCountSeries.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDownCountSeries.Name = "numUpDownCountSeries";
            numUpDownCountSeries.Size = new Size(854, 33);
            numUpDownCountSeries.TabIndex = 8;
            // 
            // labelCountSeries
            // 
            labelCountSeries.AutoSize = true;
            labelCountSeries.Dock = DockStyle.Top;
            labelCountSeries.Location = new Point(10, 184);
            labelCountSeries.Name = "labelCountSeries";
            labelCountSeries.Size = new Size(171, 25);
            labelCountSeries.TabIndex = 7;
            labelCountSeries.Text = "Количество серий";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Top;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(10, 151);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(854, 33);
            comboBoxType.TabIndex = 6;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Location = new Point(10, 126);
            labelType.Name = "labelType";
            labelType.Size = new Size(44, 25);
            labelType.TabIndex = 5;
            labelType.Text = "Тип";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(10, 93);
            textBoxName.Margin = new Padding(3, 15, 3, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(854, 33);
            textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(10, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(109, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Имя аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(10, 510);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(854, 61);
            flowLayoutPanelBottom.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Location = new Point(10, 35);
            textBoxOriginalName.Margin = new Padding(3, 15, 3, 3);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(854, 33);
            textBoxOriginalName.TabIndex = 1;
            // 
            // labelOriginalName
            // 
            labelOriginalName.AutoSize = true;
            labelOriginalName.Dock = DockStyle.Top;
            labelOriginalName.Location = new Point(10, 10);
            labelOriginalName.Name = "labelOriginalName";
            labelOriginalName.Size = new Size(178, 25);
            labelOriginalName.TabIndex = 0;
            labelOriginalName.Text = "Оригинальное имя";
            // 
            // FormAddUpdateTitle
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(884, 581);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddUpdateTitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация об аниме";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSeries).EndInit();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxOriginalName;
        private Label labelOriginalName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelName;
        protected internal TextBox textBoxName;
        private Label labelCountSeries;
        private Label labelType;
        private Label labelDuration;
        protected internal TextBox textBoxDescription;
        private Label labelDescription;
        protected internal TextBox textBoxStudio;
        private Label labelStudio;
        protected internal NumericUpDown numUpDownCountSeries;
        protected internal ComboBox comboBoxType;
        protected internal NumericUpDown numUpDownDuration;
    }
}