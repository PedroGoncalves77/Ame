namespace Ame
{
    partial class frmP15
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
            txb_37 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txt_38 = new TextBox();
            lbl_37 = new Label();
            lbl_38 = new Label();
            SuspendLayout();
            // 
            // txb_37
            // 
            txb_37.Location = new Point(34, 64);
            txb_37.Multiline = true;
            txb_37.Name = "txb_37";
            txb_37.Size = new Size(697, 126);
            txb_37.TabIndex = 29;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 391);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 28;
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
            bt_proximo.TabIndex = 27;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txt_38
            // 
            txt_38.Location = new Point(34, 234);
            txt_38.Multiline = true;
            txt_38.Name = "txt_38";
            txt_38.Size = new Size(697, 126);
            txt_38.TabIndex = 26;
            // 
            // lbl_37
            // 
            lbl_37.AutoSize = true;
            lbl_37.Location = new Point(34, 213);
            lbl_37.Name = "lbl_37";
            lbl_37.Size = new Size(402, 15);
            lbl_37.TabIndex = 25;
            lbl_37.Text = "38- Como a mãe se sente em relação a maternidade? Como está o humor? ";
            // 
            // lbl_38
            // 
            lbl_38.AutoSize = true;
            lbl_38.Location = new Point(34, 37);
            lbl_38.Name = "lbl_38";
            lbl_38.Size = new Size(405, 15);
            lbl_38.TabIndex = 24;
            lbl_38.Text = "37- Descreva como pai e mãe se sentem em relação ao sono de seu filho(a).";
            // 
            // frmP15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_37);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_38);
            Controls.Add(lbl_37);
            Controls.Add(lbl_38);
            Name = "frmP15";
            Text = "frmP15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_37;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_38;
        private Label lbl_37;
        private Label lbl_38;
    }
}