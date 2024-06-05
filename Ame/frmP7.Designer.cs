using Ame.Modelo;

namespace Ame
{
    partial class frmP7
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
            txb_exposicaoLuz = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txb_bebeAtivo = new TextBox();
            lbl_15 = new Label();
            lbl_14 = new Label();
            rbt_sim14 = new RadioButton();
            rbt_nao14 = new RadioButton();
            rbt_sim15 = new RadioButton();
            rbt_nao15 = new RadioButton();
            lbl_14a = new Label();
            lbl_15a = new Label();
            SuspendLayout();
            // 
            // txb_exposicaoLuz
            // 
            txb_exposicaoLuz.Enabled = false;
            txb_exposicaoLuz.Location = new Point(34, 76);
            txb_exposicaoLuz.Multiline = true;
            txb_exposicaoLuz.Name = "txb_exposicaoLuz";
            txb_exposicaoLuz.Size = new Size(697, 103);
            txb_exposicaoLuz.TabIndex = 29;
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
            bt_anterior.Click += button2_Click;
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
            bt_proximo.Click += button1_Click;
            // 
            // txb_bebeAtivo
            // 
            txb_bebeAtivo.Enabled = false;
            txb_bebeAtivo.Location = new Point(34, 233);
            txb_bebeAtivo.Multiline = true;
            txb_bebeAtivo.Name = "txb_bebeAtivo";
            txb_bebeAtivo.Size = new Size(697, 103);
            txb_bebeAtivo.TabIndex = 26;
            // 
            // lbl_15
            // 
            lbl_15.AutoSize = true;
            lbl_15.Location = new Point(34, 197);
            lbl_15.Name = "lbl_15";
            lbl_15.Size = new Size(114, 15);
            lbl_15.TabIndex = 25;
            lbl_15.Text = "15-É um bebê ativo?";
            lbl_15.Click += lbl_4_Click;
            // 
            // lbl_14
            // 
            lbl_14.AutoSize = true;
            lbl_14.Location = new Point(34, 37);
            lbl_14.Name = "lbl_14";
            lbl_14.Size = new Size(324, 15);
            lbl_14.TabIndex = 24;
            lbl_14.Text = "14-\tSeu filho costuma ficar exposto a luz do dia diariamente?";
            // 
            // rbt_sim14
            // 
            rbt_sim14.AutoSize = true;
            rbt_sim14.Location = new Point(364, 35);
            rbt_sim14.Name = "rbt_sim14";
            rbt_sim14.Size = new Size(45, 19);
            rbt_sim14.TabIndex = 30;
            rbt_sim14.TabStop = true;
            rbt_sim14.Text = "Sim";
            rbt_sim14.UseVisualStyleBackColor = true;
            rbt_sim14.CheckedChanged += rbt_simExposicaoLuz_CheckedChanged;
            // 
            // rbt_nao14
            // 
            rbt_nao14.AutoSize = true;
            rbt_nao14.Location = new Point(415, 35);
            rbt_nao14.Name = "rbt_nao14";
            rbt_nao14.Size = new Size(47, 19);
            rbt_nao14.TabIndex = 31;
            rbt_nao14.TabStop = true;
            rbt_nao14.Text = "Não";
            rbt_nao14.UseVisualStyleBackColor = true;
            rbt_nao14.CheckedChanged += rbt_naoExposicaoLuz_CheckedChanged;
            // 
            // rbt_sim15
            // 
            rbt_sim15.AutoSize = true;
            rbt_sim15.Location = new Point(154, 195);
            rbt_sim15.Name = "rbt_sim15";
            rbt_sim15.Size = new Size(45, 19);
            rbt_sim15.TabIndex = 32;
            rbt_sim15.TabStop = true;
            rbt_sim15.Text = "Sim";
            rbt_sim15.UseVisualStyleBackColor = true;
            rbt_sim15.CheckedChanged += rbt_simBebeAtivo_CheckedChanged;
            // 
            // rbt_nao15
            // 
            rbt_nao15.AutoSize = true;
            rbt_nao15.Location = new Point(205, 195);
            rbt_nao15.Name = "rbt_nao15";
            rbt_nao15.Size = new Size(47, 19);
            rbt_nao15.TabIndex = 33;
            rbt_nao15.TabStop = true;
            rbt_nao15.Text = "Não";
            rbt_nao15.UseVisualStyleBackColor = true;
            rbt_nao15.CheckedChanged += rbt_naoBebeAtivo_CheckedChanged;
            // 
            // lbl_14a
            // 
            lbl_14a.AutoSize = true;
            lbl_14a.Location = new Point(34, 56);
            lbl_14a.Name = "lbl_14a";
            lbl_14a.Size = new Size(54, 15);
            lbl_14a.TabIndex = 34;
            lbl_14a.Text = "Descreva";
            // 
            // lbl_15a
            // 
            lbl_15a.AutoSize = true;
            lbl_15a.Location = new Point(34, 212);
            lbl_15a.Name = "lbl_15a";
            lbl_15a.Size = new Size(54, 15);
            lbl_15a.TabIndex = 35;
            lbl_15a.Text = "Descreva";
            // 
            // frmP7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_15a);
            Controls.Add(lbl_14a);
            Controls.Add(rbt_nao15);
            Controls.Add(rbt_sim15);
            Controls.Add(rbt_nao14);
            Controls.Add(rbt_sim14);
            Controls.Add(txb_exposicaoLuz);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txb_bebeAtivo);
            Controls.Add(lbl_15);
            Controls.Add(lbl_14);
            Name = "frmP7";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_exposicaoLuz;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txb_bebeAtivo;
        private Label lbl_15;
        private Label lbl_14;
        private RadioButton rbt_sim14;
        private RadioButton rbt_nao14;
        private RadioButton rbt_sim15;
        private RadioButton rbt_nao15;
        private Label lbl_14a;
        private Label lbl_15a;
        private FichaBebeTresMeses Ficha { get; set; }
        
    }
}