namespace AppTitlesAnime
{
    partial class FormListGenres
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
            components = new System.ComponentModel.Container();
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddGenreType = new Button();
            btnUpdateGenreType = new Button();
            btnDeleteGenreType = new Button();
            dataGridViewTypes = new DataGridView();
            panelFill = new Panel();
            errorProviderGenre = new ErrorProvider(components);
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(btnAddGenreType);
            flowLayoutPanelTop.Controls.Add(btnUpdateGenreType);
            flowLayoutPanelTop.Controls.Add(btnDeleteGenreType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddGenreType
            // 
            btnAddGenreType.AutoSize = true;
            btnAddGenreType.BackColor = Color.White;
            btnAddGenreType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddGenreType.Location = new Point(13, 13);
            btnAddGenreType.Name = "btnAddGenreType";
            btnAddGenreType.Size = new Size(106, 35);
            btnAddGenreType.TabIndex = 0;
            btnAddGenreType.Text = "Добавить";
            btnAddGenreType.UseVisualStyleBackColor = false;
            btnAddGenreType.Click += BtnAddGenreType_Click;
            // 
            // btnUpdateGenreType
            // 
            btnUpdateGenreType.AutoSize = true;
            btnUpdateGenreType.BackColor = Color.White;
            btnUpdateGenreType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdateGenreType.Location = new Point(125, 13);
            btnUpdateGenreType.Name = "btnUpdateGenreType";
            btnUpdateGenreType.Size = new Size(151, 35);
            btnUpdateGenreType.TabIndex = 1;
            btnUpdateGenreType.Text = "Редактировать";
            btnUpdateGenreType.UseVisualStyleBackColor = false;
            btnUpdateGenreType.Click += BtnUpdateGenreType_Click;
            // 
            // btnDeleteGenreType
            // 
            btnDeleteGenreType.AutoSize = true;
            btnDeleteGenreType.BackColor = Color.White;
            btnDeleteGenreType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteGenreType.Location = new Point(282, 13);
            btnDeleteGenreType.Name = "btnDeleteGenreType";
            btnDeleteGenreType.Size = new Size(92, 35);
            btnDeleteGenreType.TabIndex = 2;
            btnDeleteGenreType.Text = "Удалить";
            btnDeleteGenreType.UseVisualStyleBackColor = false;
            btnDeleteGenreType.Click += btnDeleteGenreType_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.GridColor = Color.DimGray;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(914, 430);
            dataGridViewTypes.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 450);
            panelFill.TabIndex = 2;
            // 
            // errorProviderGenre
            // 
            errorProviderGenre.ContainerControl = this;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormListGenres";
            Text = "Список Тип жанра";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddGenreType;
        private Button btnUpdateGenreType;
        private Button btnDeleteGenreType;
        private DataGridView dataGridViewTypes;
        private Panel panelFill;
        private ErrorProvider errorProviderGenre;
    }
}