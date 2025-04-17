namespace AppTitlesAnime
{
    partial class FormAddStatus
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
            panelFillStatus = new Panel();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            flowLayoutPanelBottomStatus = new FlowLayoutPanel();
            btnSaveChangeStatus = new Button();
            btnCancelStatus = new Button();
            errorProvider = new ErrorProvider(components);
            panelFillStatus.SuspendLayout();
            flowLayoutPanelBottomStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFillStatus
            // 
            panelFillStatus.AutoSize = true;
            panelFillStatus.Controls.Add(textBoxStatusName);
            panelFillStatus.Controls.Add(labelStatusName);
            panelFillStatus.Dock = DockStyle.Fill;
            panelFillStatus.Location = new Point(0, 0);
            panelFillStatus.Name = "panelFillStatus";
            panelFillStatus.Padding = new Padding(10, 10, 20, 10);
            panelFillStatus.Size = new Size(498, 140);
            panelFillStatus.TabIndex = 0;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxStatusName.Location = new Point(10, 35);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(468, 33);
            textBoxStatusName.TabIndex = 1;
            textBoxStatusName.TextChanged += TextBoxStatusName_TextChanged;
            textBoxStatusName.Validating += textBoxStatusName_Validating;
            // 
            // labelStatusName
            // 
            labelStatusName.AutoSize = true;
            labelStatusName.Dock = DockStyle.Top;
            labelStatusName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStatusName.Location = new Point(10, 10);
            labelStatusName.Name = "labelStatusName";
            labelStatusName.Size = new Size(102, 25);
            labelStatusName.TabIndex = 0;
            labelStatusName.Text = "Тип статус";
            // 
            // flowLayoutPanelBottomStatus
            // 
            flowLayoutPanelBottomStatus.AutoSize = true;
            flowLayoutPanelBottomStatus.Controls.Add(btnSaveChangeStatus);
            flowLayoutPanelBottomStatus.Controls.Add(btnCancelStatus);
            flowLayoutPanelBottomStatus.Dock = DockStyle.Bottom;
            flowLayoutPanelBottomStatus.Location = new Point(0, 79);
            flowLayoutPanelBottomStatus.Name = "flowLayoutPanelBottomStatus";
            flowLayoutPanelBottomStatus.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottomStatus.Size = new Size(498, 61);
            flowLayoutPanelBottomStatus.TabIndex = 1;
            // 
            // btnSaveChangeStatus
            // 
            btnSaveChangeStatus.AutoSize = true;
            btnSaveChangeStatus.DialogResult = DialogResult.OK;
            btnSaveChangeStatus.Font = new Font("Segoe UI", 14.25F);
            btnSaveChangeStatus.Location = new Point(13, 13);
            btnSaveChangeStatus.Name = "btnSaveChangeStatus";
            btnSaveChangeStatus.Size = new Size(115, 35);
            btnSaveChangeStatus.TabIndex = 0;
            btnSaveChangeStatus.Text = "Сохранить";
            btnSaveChangeStatus.UseVisualStyleBackColor = true;
            // 
            // btnCancelStatus
            // 
            btnCancelStatus.AutoSize = true;
            btnCancelStatus.DialogResult = DialogResult.Cancel;
            btnCancelStatus.Font = new Font("Segoe UI", 14.25F);
            btnCancelStatus.Location = new Point(134, 13);
            btnCancelStatus.Name = "btnCancelStatus";
            btnCancelStatus.Size = new Size(88, 35);
            btnCancelStatus.TabIndex = 1;
            btnCancelStatus.Text = "Отмена";
            btnCancelStatus.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(498, 140);
            Controls.Add(flowLayoutPanelBottomStatus);
            Controls.Add(panelFillStatus);
            Name = "FormAddStatus";
            Text = "Информация о типе статусов";
            Validating += FormAddStatus_Validating;
            panelFillStatus.ResumeLayout(false);
            panelFillStatus.PerformLayout();
            flowLayoutPanelBottomStatus.ResumeLayout(false);
            flowLayoutPanelBottomStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFillStatus;
        private TextBox textBox1;
        private Label labelStatusName;
        private FlowLayoutPanel flowLayoutPanelBottomStatus;
        private Button btnSaveChangeStatus;
        private Button btnCancelStatus;
        protected internal TextBox textBoxStatusName;
        private ErrorProvider errorProvider;
    }
}