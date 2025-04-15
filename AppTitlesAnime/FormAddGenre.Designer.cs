namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            panelFillGenre = new Panel();
            textBoxTypeNameGenre = new TextBox();
            labelTypenNameGenre = new Label();
            flowLayoutPanelBottonGenre = new FlowLayoutPanel();
            btnSaveChangesGenre = new Button();
            btnCancelGenre = new Button();
            errorProviderGenre1 = new ErrorProvider(components);
            panelFillGenre.SuspendLayout();
            flowLayoutPanelBottonGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre1).BeginInit();
            SuspendLayout();
            // 
            // panelFillGenre
            // 
            panelFillGenre.Controls.Add(textBoxTypeNameGenre);
            panelFillGenre.Controls.Add(labelTypenNameGenre);
            panelFillGenre.Dock = DockStyle.Fill;
            panelFillGenre.Location = new Point(0, 0);
            panelFillGenre.Name = "panelFillGenre";
            panelFillGenre.Padding = new Padding(10, 10, 20, 10);
            panelFillGenre.Size = new Size(434, 146);
            panelFillGenre.TabIndex = 0;
            // 
            // textBoxTypeNameGenre
            // 
            textBoxTypeNameGenre.BackColor = Color.White;
            textBoxTypeNameGenre.Dock = DockStyle.Top;
            textBoxTypeNameGenre.Location = new Point(10, 35);
            textBoxTypeNameGenre.Name = "textBoxTypeNameGenre";
            textBoxTypeNameGenre.Size = new Size(404, 33);
            textBoxTypeNameGenre.TabIndex = 1;
            textBoxTypeNameGenre.TextChanged += textBoxTypeNameGenre_TextChanged;
            textBoxTypeNameGenre.Validated += TextBoxTypeNameGenre_Validated;
            // 
            // labelTypenNameGenre
            // 
            labelTypenNameGenre.AutoSize = true;
            labelTypenNameGenre.Dock = DockStyle.Top;
            labelTypenNameGenre.Location = new Point(10, 10);
            labelTypenNameGenre.Name = "labelTypenNameGenre";
            labelTypenNameGenre.Size = new Size(107, 25);
            labelTypenNameGenre.TabIndex = 0;
            labelTypenNameGenre.Text = "Тип Жанра";
            // 
            // flowLayoutPanelBottonGenre
            // 
            flowLayoutPanelBottonGenre.AutoSize = true;
            flowLayoutPanelBottonGenre.Controls.Add(btnSaveChangesGenre);
            flowLayoutPanelBottonGenre.Controls.Add(btnCancelGenre);
            flowLayoutPanelBottonGenre.Dock = DockStyle.Bottom;
            flowLayoutPanelBottonGenre.Location = new Point(0, 85);
            flowLayoutPanelBottonGenre.Name = "flowLayoutPanelBottonGenre";
            flowLayoutPanelBottonGenre.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottonGenre.Size = new Size(434, 61);
            flowLayoutPanelBottonGenre.TabIndex = 1;
            // 
            // btnSaveChangesGenre
            // 
            btnSaveChangesGenre.AutoSize = true;
            btnSaveChangesGenre.DialogResult = DialogResult.OK;
            btnSaveChangesGenre.Location = new Point(13, 13);
            btnSaveChangesGenre.Name = "btnSaveChangesGenre";
            btnSaveChangesGenre.Size = new Size(115, 35);
            btnSaveChangesGenre.TabIndex = 0;
            btnSaveChangesGenre.Text = "Сохранить";
            btnSaveChangesGenre.UseVisualStyleBackColor = true;
            // 
            // btnCancelGenre
            // 
            btnCancelGenre.AutoSize = true;
            btnCancelGenre.DialogResult = DialogResult.Cancel;
            btnCancelGenre.Location = new Point(134, 13);
            btnCancelGenre.Name = "btnCancelGenre";
            btnCancelGenre.Size = new Size(88, 35);
            btnCancelGenre.TabIndex = 1;
            btnCancelGenre.Text = "Отмена";
            btnCancelGenre.UseVisualStyleBackColor = true;
            btnCancelGenre.Click += btnCancelGenre_Click;
            // 
            // errorProviderGenre1
            // 
            errorProviderGenre1.ContainerControl = this;
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(434, 146);
            Controls.Add(flowLayoutPanelBottonGenre);
            Controls.Add(panelFillGenre);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenre";
            Text = "Информация о типе жанра";
            TextChanged += textBoxTypeNameGenre_TextChanged;
            panelFillGenre.ResumeLayout(false);
            panelFillGenre.PerformLayout();
            flowLayoutPanelBottonGenre.ResumeLayout(false);
            flowLayoutPanelBottonGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFillGenre;
        private FlowLayoutPanel flowLayoutPanelBottonGenre;
        private Label labelTypenNameGenre;
        private Button btnSaveChangesGenre;
        private Button btnCancelGenre;
        protected internal TextBox textBoxTypeNameGenre;
        private ErrorProvider errorProviderGenre1;
    }
}