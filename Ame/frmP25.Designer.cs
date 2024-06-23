using Ame.Modelo;

namespace Ame
{
    partial class frmP25
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
            txt_65 = new TextBox();
            lbl_65 = new Label();
            txt_64 = new TextBox();
            lbl_64 = new Label();
            txt_63 = new TextBox();
            lbl_63 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            SuspendLayout();
            // 
            // txt_65
            // 
            txt_65.Location = new Point(23, 298);
            txt_65.Multiline = true;
            txt_65.Name = "txt_65";
            txt_65.Size = new Size(755, 93);
            txt_65.TabIndex = 131;
            // 
            // lbl_65
            // 
            lbl_65.AutoSize = true;
            lbl_65.Location = new Point(23, 280);
            lbl_65.Name = "lbl_65";
            lbl_65.Size = new Size(727, 15);
            lbl_65.TabIndex = 130;
            lbl_65.Text = "65- Sobre o sono noturno: Quem coloca a criança para dormir? Que horas ela é colocada no berço/cama? Que horas dorme de verdade? ";
            // 
            // txt_64
            // 
            txt_64.Location = new Point(23, 160);
            txt_64.Multiline = true;
            txt_64.Name = "txt_64";
            txt_64.Size = new Size(755, 93);
            txt_64.TabIndex = 129;
            // 
            // lbl_64
            // 
            lbl_64.AutoSize = true;
            lbl_64.Location = new Point(23, 141);
            lbl_64.Name = "lbl_64";
            lbl_64.Size = new Size(351, 15);
            lbl_64.TabIndex = 128;
            lbl_64.Text = "64- Quem coloca a criança para fazer as sonecas? Como faz isso? ";
            // 
            // txt_63
            // 
            txt_63.Location = new Point(23, 39);
            txt_63.Multiline = true;
            txt_63.Name = "txt_63";
            txt_63.Size = new Size(755, 82);
            txt_63.TabIndex = 127;
            // 
            // lbl_63
            // 
            lbl_63.AutoSize = true;
            lbl_63.Location = new Point(23, 19);
            lbl_63.Name = "lbl_63";
            lbl_63.Size = new Size(394, 15);
            lbl_63.TabIndex = 126;
            lbl_63.Text = "63- Sobre as sonecas do dia: descreva os horários e duração de cada uma.";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(23, 409);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 125;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(664, 409);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 124;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // frmP25
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_65);
            Controls.Add(lbl_65);
            Controls.Add(txt_64);
            Controls.Add(lbl_64);
            Controls.Add(txt_63);
            Controls.Add(lbl_63);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP25";
            Text = "frmP25";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_65;
        private Label lbl_65;
        private TextBox txt_64;
        private Label lbl_64;
        private TextBox txt_63;
        private Label lbl_63;
        private Button bt_anterior;
        private Button bt_proximo;
        private FichaBebeTresMeses Ficha { get; set; }
        private ProblemaSono ProblemaSono { get; set; }
    }
}