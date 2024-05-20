namespace Ame
{
    partial class frm12
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
            txt_31 = new TextBox();
            lbl_31 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            rbt_nao32 = new RadioButton();
            rbt_sim32 = new RadioButton();
            lbl_32 = new Label();
            lbl_32a = new Label();
            txb_32 = new TextBox();
            lbl_33a = new Label();
            txt_33 = new TextBox();
            rbt_nao33 = new RadioButton();
            rbt_sim33 = new RadioButton();
            lbl_33 = new Label();
            SuspendLayout();
            // 
            // txt_31
            // 
            txt_31.Location = new Point(11, 45);
            txt_31.Multiline = true;
            txt_31.Name = "txt_31";
            txt_31.Size = new Size(736, 73);
            txt_31.TabIndex = 70;
            // 
            // lbl_31
            // 
            lbl_31.AutoSize = true;
            lbl_31.Location = new Point(11, 19);
            lbl_31.Name = "lbl_31";
            lbl_31.Size = new Size(500, 15);
            lbl_31.TabIndex = 69;
            lbl_31.Text = "31- Descreva o temperamento do bebê e como normalmente ele reage a mudanças na rotina.";
            // 
            // bt_anterior
            // 
            bt_anterior.Location = new Point(12, 406);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 72;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Location = new Point(647, 406);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 71;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // rbt_nao32
            // 
            rbt_nao32.AutoSize = true;
            rbt_nao32.Location = new Point(367, 132);
            rbt_nao32.Name = "rbt_nao32";
            rbt_nao32.Size = new Size(47, 19);
            rbt_nao32.TabIndex = 75;
            rbt_nao32.TabStop = true;
            rbt_nao32.Text = "Não";
            rbt_nao32.UseVisualStyleBackColor = true;
            rbt_nao32.CheckedChanged += rbt_naoChoro_CheckedChanged;
            // 
            // rbt_sim32
            // 
            rbt_sim32.AutoSize = true;
            rbt_sim32.Location = new Point(316, 132);
            rbt_sim32.Name = "rbt_sim32";
            rbt_sim32.Size = new Size(45, 19);
            rbt_sim32.TabIndex = 74;
            rbt_sim32.TabStop = true;
            rbt_sim32.Text = "Sim";
            rbt_sim32.UseVisualStyleBackColor = true;
            rbt_sim32.CheckedChanged += rbt_sim32_CheckedChanged;
            // 
            // lbl_32
            // 
            lbl_32.AutoSize = true;
            lbl_32.Location = new Point(11, 134);
            lbl_32.Name = "lbl_32";
            lbl_32.Size = new Size(298, 15);
            lbl_32.TabIndex = 73;
            lbl_32.Text = "32- Existe algum horário do dia em que ele chore mais?";
            // 
            // lbl_32a
            // 
            lbl_32a.AutoSize = true;
            lbl_32a.Location = new Point(11, 159);
            lbl_32a.Name = "lbl_32a";
            lbl_32a.Size = new Size(57, 15);
            lbl_32a.TabIndex = 77;
            lbl_32a.Text = "Descreva:";
            // 
            // txb_32
            // 
            txb_32.Enabled = false;
            txb_32.Location = new Point(11, 177);
            txb_32.Multiline = true;
            txb_32.Name = "txb_32";
            txb_32.Size = new Size(736, 85);
            txb_32.TabIndex = 76;
            // 
            // lbl_33a
            // 
            lbl_33a.AutoSize = true;
            lbl_33a.Location = new Point(11, 299);
            lbl_33a.Name = "lbl_33a";
            lbl_33a.Size = new Size(57, 15);
            lbl_33a.TabIndex = 82;
            lbl_33a.Text = "Descreva:";
            // 
            // txt_33
            // 
            txt_33.Enabled = false;
            txt_33.Location = new Point(11, 317);
            txt_33.Multiline = true;
            txt_33.Name = "txt_33";
            txt_33.Size = new Size(736, 73);
            txt_33.TabIndex = 81;
            // 
            // rbt_nao33
            // 
            rbt_nao33.AutoSize = true;
            rbt_nao33.Location = new Point(415, 272);
            rbt_nao33.Name = "rbt_nao33";
            rbt_nao33.Size = new Size(47, 19);
            rbt_nao33.TabIndex = 80;
            rbt_nao33.TabStop = true;
            rbt_nao33.Text = "Não";
            rbt_nao33.UseVisualStyleBackColor = true;
            rbt_nao33.CheckedChanged += rbt_naoAgitado_CheckedChanged;
            // 
            // rbt_sim33
            // 
            rbt_sim33.AutoSize = true;
            rbt_sim33.Location = new Point(364, 272);
            rbt_sim33.Name = "rbt_sim33";
            rbt_sim33.Size = new Size(45, 19);
            rbt_sim33.TabIndex = 79;
            rbt_sim33.TabStop = true;
            rbt_sim33.Text = "Sim";
            rbt_sim33.UseVisualStyleBackColor = true;
            rbt_sim33.CheckedChanged += rbt_sim33_CheckedChanged;
            // 
            // lbl_33
            // 
            lbl_33.AutoSize = true;
            lbl_33.Location = new Point(11, 274);
            lbl_33.Name = "lbl_33";
            lbl_33.Size = new Size(327, 15);
            lbl_33.TabIndex = 78;
            lbl_33.Text = "33- A criança fica muito agitada quando vem visitas na casa?";
            // 
            // frm12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_33a);
            Controls.Add(txt_33);
            Controls.Add(rbt_nao33);
            Controls.Add(rbt_sim33);
            Controls.Add(lbl_33);
            Controls.Add(lbl_32a);
            Controls.Add(txb_32);
            Controls.Add(rbt_nao32);
            Controls.Add(rbt_sim32);
            Controls.Add(lbl_32);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_31);
            Controls.Add(lbl_31);
            Name = "frm12";
            Text = "frmP12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_31;
        private Label lbl_31;
        private Button bt_anterior;
        private Button bt_proximo;
        private RadioButton rbt_nao32;
        private RadioButton rbt_sim32;
        private Label lbl_32;
        private Label lbl_32a;
        private TextBox txb_32;
        private Label lbl_33a;
        private TextBox txt_33;
        private RadioButton rbt_nao33;
        private RadioButton rbt_sim33;
        private Label lbl_33;
    }
}