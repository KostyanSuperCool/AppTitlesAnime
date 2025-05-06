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
            btnStatusTypes = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            btnShowTitles = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.BackColor = Color.White;
            btnShowTypes.Location = new Point(3, 3);
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
            btnGenreTypes.Location = new Point(3, 85);
            btnGenreTypes.Name = "btnGenreTypes";
            btnGenreTypes.Size = new Size(306, 35);
            btnGenreTypes.TabIndex = 1;
            btnGenreTypes.Text = "Отобразить список \"Жанры\"";
            btnGenreTypes.UseVisualStyleBackColor = true;
            btnGenreTypes.Click += btnGenreTypes_Click;
            // 
            // btnStatusTypes
            // 
            btnStatusTypes.AutoSize = true;
            btnStatusTypes.Location = new Point(3, 126);
            btnStatusTypes.Name = "btnStatusTypes";
            btnStatusTypes.Size = new Size(301, 35);
            btnStatusTypes.TabIndex = 2;
            btnStatusTypes.Text = "Отобразить список \"Статусы\"";
            btnStatusTypes.UseVisualStyleBackColor = true;
            btnStatusTypes.Click += btnStatusTypes_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(btnShowTypes);
            flowLayoutPanel.Controls.Add(btnShowTitles);
            flowLayoutPanel.Controls.Add(btnGenreTypes);
            flowLayoutPanel.Controls.Add(btnStatusTypes);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(10, 10);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(807, 437);
            flowLayoutPanel.TabIndex = 3;
            // 
            // btnShowTitles
            // 
            btnShowTitles.AutoSize = true;
            btnShowTitles.BackColor = Color.White;
            btnShowTitles.Location = new Point(3, 44);
            btnShowTitles.Name = "btnShowTitles";
            btnShowTitles.Size = new Size(315, 35);
            btnShowTitles.TabIndex = 1;
            btnShowTitles.Text = "Отобразить список \"Аниме\"";
            btnShowTitles.UseVisualStyleBackColor = false;
            btnShowTitles.Click += BtnShowTitles_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(827, 457);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            Load += FormMain_Load;
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowTypes;
        private Button btnGenreTypes;
        private Button btnStatusTypes;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnShowTitles;
    }
}
