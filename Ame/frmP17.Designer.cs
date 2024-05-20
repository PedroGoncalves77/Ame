namespace Ame
{
    partial class frmP17
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
            txb_42 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txt_42 = new TextBox();
            lbl_42 = new Label();
            lbl_41 = new Label();
            SuspendLayout();
            // 
            // txb_42
            // 
            txb_42.Location = new Point(34, 64);
            txb_42.Multiline = true;
            txb_42.Name = "txb_42";
            txb_42.Size = new Size(697, 57);
            txb_42.TabIndex = 35;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 391);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 34;
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
            bt_proximo.TabIndex = 33;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txt_42
            // 
            txt_42.Location = new Point(34, 179);
            txt_42.Multiline = true;
            txt_42.Name = "txt_42";
            txt_42.Size = new Size(697, 126);
            txt_42.TabIndex = 32;
            // 
            // lbl_42
            // 
            lbl_42.AutoSize = true;
            lbl_42.Location = new Point(34, 158);
            lbl_42.Name = "lbl_42";
            lbl_42.Size = new Size(526, 15);
            lbl_42.TabIndex = 31;
            lbl_42.Text = "42- Como se sentem em relação ao parceiro? Ou caso não tenha, como se sente em relação a isso?";
            // 
            // lbl_41
            // 
            lbl_41.AutoSize = true;
            lbl_41.Location = new Point(34, 37);
            lbl_41.Name = "lbl_41";
            lbl_41.Size = new Size(373, 15);
            lbl_41.TabIndex = 30;
            lbl_41.Text = "41- Vocês conseguem dormir uma média de quantas horas por noite?";
            // 
            // frmP17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_42);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_42);
            Controls.Add(lbl_42);
            Controls.Add(lbl_41);
            Name = "frmP17";
            Text = "frm17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_42;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_42;
        private Label lbl_42;
        private Label lbl_41;
    }
}