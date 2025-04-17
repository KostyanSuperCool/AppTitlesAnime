namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            btnGenreTypes = new Button();
            btnStausTypes = new Button();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.BackColor = Color.White;
            btnShowTypes.Location = new Point(12, 12);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(315, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы Аниме\"";
            btnShowTypes.UseVisualStyleBackColor = false;
            btnShowTypes.Click += BtnShowTypes_Click_1;
            // 
            // btnGenreTypes
            // 
            btnGenreTypes.AutoSize = true;
            btnGenreTypes.Location = new Point(12, 68);
            btnGenreTypes.Name = "btnGenreTypes";
            btnGenreTypes.Size = new Size(306, 35);
            btnGenreTypes.TabIndex = 1;
            btnGenreTypes.Text = "Отобразить список \"Типы Жанр\"";
            btnGenreTypes.UseVisualStyleBackColor = true;
            btnGenreTypes.Click += btnGenreTypes_Click;
            // 
            // btnStausTypes
            // 
            btnStausTypes.AutoSize = true;
            btnStausTypes.Location = new Point(12, 123);
            btnStausTypes.Name = "btnStausTypes";
            btnStausTypes.Size = new Size(293, 35);
            btnStausTypes.TabIndex = 2;
            btnStausTypes.Text = "Отобраить список \"Тип Статус\"";
            btnStausTypes.UseVisualStyleBackColor = true;
            btnStausTypes.Click += btnStausTypes_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(502, 457);
            Controls.Add(btnStausTypes);
            Controls.Add(btnGenreTypes);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
        private Button btnGenreTypes;
        private Button btnStausTypes;
    }
}
