namespace Ame
{
    partial class frmP18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmP18));
            txb_42 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txt_42 = new TextBox();
            lbl_44 = new Label();
            lbl_43 = new Label();
            SuspendLayout();
            // 
            // txb_42
            // 
            txb_42.Location = new Point(34, 52);
            txb_42.Multiline = true;
            txb_42.Name = "txb_42";
            txb_42.Size = new Size(733, 69);
            txb_42.TabIndex = 41;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 391);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 40;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(653, 391);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 39;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txt_42
            // 
            txt_42.Location = new Point(34, 198);
            txt_42.Multiline = true;
            txt_42.Name = "txt_42";
            txt_42.Size = new Size(733, 154);
            txt_42.TabIndex = 38;
            // 
            // lbl_44
            // 
            lbl_44.Location = new Point(34, 142);
            lbl_44.Name = "lbl_44";
            lbl_44.Size = new Size(733, 53);
            lbl_44.TabIndex = 37;
            lbl_44.Text = resources.GetString("lbl_44.Text");
            lbl_44.Click += lbl_44_Click;
            // 
            // lbl_43
            // 
            lbl_43.AutoSize = true;
            lbl_43.Location = new Point(34, 24);
            lbl_43.Name = "lbl_43";
            lbl_43.Size = new Size(436, 15);
            lbl_43.TabIndex = 36;
            lbl_43.Text = "43-\tComo vocês descreveriam o estilo de paternidade/maternidade que praticam?";
            // 
            // frmP18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_42);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_42);
            Controls.Add(lbl_44);
            Controls.Add(lbl_43);
            Name = "frmP18";
            Text = "frmP18";
            Load += frmP18_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_42;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_42;
        private Label lbl_44;
        private Label lbl_43;
    }
}