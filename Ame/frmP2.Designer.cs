using Ame.Modelo;

namespace Ame
{
    partial class frmP2
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
            bt_proximo = new Button();
            txt_4 = new TextBox();
            lbl_4 = new Label();
            lbl_3 = new Label();
            bt_anterior = new Button();
            txt_3 = new TextBox();
            SuspendLayout();
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(653, 398);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 9;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += button1_Click;
            // 
            // txt_4
            // 
            txt_4.Location = new Point(34, 241);
            txt_4.Multiline = true;
            txt_4.Name = "txt_4";
            txt_4.Size = new Size(697, 126);
            txt_4.TabIndex = 8;
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Location = new Point(34, 220);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(415, 15);
            lbl_4.TabIndex = 6;
            lbl_4.Text = "4- No momento está em processo de aprendizado de alguma nova atividade?";
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Location = new Point(34, 44);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(314, 15);
            lbl_3.TabIndex = 5;
            lbl_3.Text = "3- A criança tem atingido os marcos do desenvolvimento?";
            lbl_3.Click += label1_Click;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 398);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 10;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += button2_Click;
            // 
            // txt_3
            // 
            txt_3.Location = new Point(34, 71);
            txt_3.Multiline = true;
            txt_3.Name = "txt_3";
            txt_3.Size = new Size(697, 126);
            txt_3.TabIndex = 11;
            // 
            // frmP2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_3);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_4);
            Controls.Add(lbl_4);
            Controls.Add(lbl_3);
            Name = "frmP2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_proximo;
        private TextBox txt_4;
        private Label lbl_4;
        private Label lbl_3;
        private Button bt_anterior;
        private TextBox txt_3;
        private FichaBebeTresMeses Ficha;
    }
}