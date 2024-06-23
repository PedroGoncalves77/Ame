using Ame.Modelo;

namespace Ame
{
    partial class frmP20
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
            lbl_48 = new Label();
            txt_50 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            lbl_49 = new Label();
            lbl_48a = new Label();
            rbt_nao48 = new RadioButton();
            rbt_sim48 = new RadioButton();
            txt_48 = new TextBox();
            txt_49 = new TextBox();
            lbl_50 = new Label();
            SuspendLayout();
            // 
            // lbl_48
            // 
            lbl_48.AutoSize = true;
            lbl_48.Location = new Point(34, 20);
            lbl_48.Name = "lbl_48";
            lbl_48.Size = new Size(185, 15);
            lbl_48.TabIndex = 57;
            lbl_48.Text = "48- Mãe em licença maternidade?";
            lbl_48.Click += lbl_45_Click;
            // 
            // txt_50
            // 
            txt_50.Location = new Point(34, 289);
            txt_50.Multiline = true;
            txt_50.Name = "txt_50";
            txt_50.Size = new Size(733, 72);
            txt_50.TabIndex = 67;
            txt_50.TextChanged += txt_50_TextChanged;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 407);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 61;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(653, 407);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 60;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // lbl_49
            // 
            lbl_49.AutoSize = true;
            lbl_49.Location = new Point(34, 158);
            lbl_49.Name = "lbl_49";
            lbl_49.Size = new Size(489, 15);
            lbl_49.TabIndex = 58;
            lbl_49.Text = "49-\tQuantas horas por dia, por turno mãe e pai passam com a criança? Descreva os horários.";
            // 
            // lbl_48a
            // 
            lbl_48a.AutoSize = true;
            lbl_48a.Location = new Point(34, 46);
            lbl_48a.Name = "lbl_48a";
            lbl_48a.Size = new Size(345, 15);
            lbl_48a.TabIndex = 72;
            lbl_48a.Text = "Descreva os horários que mãe e pai saem e chegam do trabalho.";
            // 
            // rbt_nao48
            // 
            rbt_nao48.AutoSize = true;
            rbt_nao48.Location = new Point(271, 16);
            rbt_nao48.Name = "rbt_nao48";
            rbt_nao48.Size = new Size(47, 19);
            rbt_nao48.TabIndex = 74;
            rbt_nao48.TabStop = true;
            rbt_nao48.Text = "Não";
            rbt_nao48.UseVisualStyleBackColor = true;
            rbt_nao48.CheckedChanged += rbt_nao48_CheckedChanged;
            // 
            // rbt_sim48
            // 
            rbt_sim48.AutoSize = true;
            rbt_sim48.Location = new Point(220, 16);
            rbt_sim48.Name = "rbt_sim48";
            rbt_sim48.Size = new Size(45, 19);
            rbt_sim48.TabIndex = 73;
            rbt_sim48.TabStop = true;
            rbt_sim48.Text = "Sim";
            rbt_sim48.UseVisualStyleBackColor = true;
            rbt_sim48.CheckedChanged += rbt_sim48_CheckedChanged;
            // 
            // txt_48
            // 
            txt_48.Location = new Point(34, 64);
            txt_48.Multiline = true;
            txt_48.Name = "txt_48";
            txt_48.Size = new Size(733, 72);
            txt_48.TabIndex = 75;
            txt_48.Enabled = false;
            // 
            // txt_49
            // 
            txt_49.Location = new Point(34, 176);
            txt_49.Multiline = true;
            txt_49.Name = "txt_49";
            txt_49.Size = new Size(733, 72);
            txt_49.TabIndex = 76;
            // 
            // lbl_50
            // 
            lbl_50.AutoSize = true;
            lbl_50.Location = new Point(34, 271);
            lbl_50.Name = "lbl_50";
            lbl_50.Size = new Size(435, 15);
            lbl_50.TabIndex = 77;
            lbl_50.Text = "50- Quem fica responsável pelo cuidado do bebê durante a noite e durante o dia?";
            // 
            // frmP20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_50);
            Controls.Add(txt_49);
            Controls.Add(txt_48);
            Controls.Add(rbt_nao48);
            Controls.Add(rbt_sim48);
            Controls.Add(lbl_48a);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_50);
            Controls.Add(lbl_49);
            Controls.Add(lbl_48);
            Name = "frmP20";
            Text = "frmP20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbt_nao47;
        private RadioButton rbt_sim47;
        private TextBox txt_47b;
        private Label lbl_47b;
        private Label lbl_47a;
        private TextBox txt_47a;
        private Label lbl_48;
        private TextBox txb_45;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_46;
        private Label lbl_49;
        private Label lbl_45;
        private Label lbl_48a;
        private RadioButton rbt_nao48;
        private RadioButton rbt_sim48;
        private TextBox txt_50;
        private TextBox txt_48;
        private TextBox txt_49;
        private Label lbl_50;
        private FichaBebeTresMeses Ficha { get; set; }
        private DinamicaFamiliar DinamicaFamiliar { get; set; }
    }
}