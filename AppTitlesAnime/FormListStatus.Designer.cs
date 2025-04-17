namespace AppTitlesAnime
{
    partial class FormListStatus
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
            flowLayoutPanelStatus = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatus = new Button();
            dataGridViewStatus = new DataGridView();
            panelFillStatus = new Panel();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            panelFillStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelStatus
            // 
            flowLayoutPanelStatus.AutoSize = true;
            flowLayoutPanelStatus.BackColor = Color.White;
            flowLayoutPanelStatus.Controls.Add(btnAddStatus);
            flowLayoutPanelStatus.Controls.Add(btnUpdateStatus);
            flowLayoutPanelStatus.Controls.Add(btnDeleteStatus);
            flowLayoutPanelStatus.Dock = DockStyle.Top;
            flowLayoutPanelStatus.Location = new Point(0, 0);
            flowLayoutPanelStatus.Name = "flowLayoutPanelStatus";
            flowLayoutPanelStatus.Padding = new Padding(10);
            flowLayoutPanelStatus.Size = new Size(934, 61);
            flowLayoutPanelStatus.TabIndex = 0;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Font = new Font("Segoe UI", 14.25F);
            btnAddStatus.Location = new Point(13, 13);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(106, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Font = new Font("Segoe UI", 14.25F);
            btnUpdateStatus.Location = new Point(125, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(151, 35);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Font = new Font("Segoe UI", 14.25F);
            btnDeleteStatus.Location = new Point(282, 13);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(92, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            btnDeleteStatus.Click += BtnDeleteStatus_Click;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.White;
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(914, 430);
            dataGridViewStatus.TabIndex = 1;
            // 
            // panelFillStatus
            // 
            panelFillStatus.Controls.Add(dataGridViewStatus);
            panelFillStatus.Dock = DockStyle.Fill;
            panelFillStatus.Location = new Point(0, 61);
            panelFillStatus.Name = "panelFillStatus";
            panelFillStatus.Padding = new Padding(10);
            panelFillStatus.Size = new Size(934, 450);
            panelFillStatus.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormListStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFillStatus);
            Controls.Add(flowLayoutPanelStatus);
            Name = "FormListStatus";
            Text = "Список тип статуса";
            flowLayoutPanelStatus.ResumeLayout(false);
            flowLayoutPanelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            panelFillStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelStatus;
        private Button btnAddStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteStatus;
        private DataGridView dataGridViewStatus;
        private Panel panelFillStatus;
        private ErrorProvider errorProvider;
    }
}