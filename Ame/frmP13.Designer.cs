using Ame.Modelo;

namespace Ame
{
    partial class frmP13
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
            txtBox3 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txtBox4 = new TextBox();
            lbl_35 = new Label();
            lbl_34 = new Label();
            SuspendLayout();
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(34, 64);
            txtBox3.Multiline = true;
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(697, 126);
            txtBox3.TabIndex = 17;
            txtBox3.TextChanged += txtBox3_TextChanged;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 391);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 16;
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
            bt_proximo.TabIndex = 15;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txtBox4
            // 
            txtBox4.Location = new Point(34, 234);
            txtBox4.Multiline = true;
            txtBox4.Name = "txtBox4";
            txtBox4.Size = new Size(697, 126);
            txtBox4.TabIndex = 14;
            txtBox4.TextChanged += txtBox4_TextChanged;
            // 
            // lbl_35
            // 
            lbl_35.AutoSize = true;
            lbl_35.Location = new Point(34, 213);
            lbl_35.Name = "lbl_35";
            lbl_35.Size = new Size(260, 15);
            lbl_35.TabIndex = 13;
            lbl_35.Text = "35-\tComo foi a gestação, parto e amamentação?";
            // 
            // lbl_34
            // 
            lbl_34.AutoSize = true;
            lbl_34.Location = new Point(34, 37);
            lbl_34.Name = "lbl_34";
            lbl_34.Size = new Size(343, 15);
            lbl_34.TabIndex = 12;
            lbl_34.Text = "34-\tDescreva um pouco sobre o temperamento do pai e da mãe.";
            // 
            // frmP13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox3);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txtBox4);
            Controls.Add(lbl_35);
            Controls.Add(lbl_34);
            Name = "frmP13";
            Text = "frmP13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox3;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txtBox4;
        private Label lbl_35;
        private Label lbl_34;
        private FichaBebeTresMeses Ficha { get; set; }
        private SobrePais SobrePais { get; set; }
    }
}