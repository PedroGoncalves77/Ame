namespace Ame
{
    partial class frmP5
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
            bt_anterior = new Button();
            bt_proximo = new Button();
            lbl_AlgumaAlergia = new Label();
            lbl_bebeColica = new Label();
            rbt_simAlergia = new RadioButton();
            rbt_naoAlergia = new RadioButton();
            lbl_DorOuvido = new Label();
            rbt_simIntestino = new RadioButton();
            rbt_naoIntestino = new RadioButton();
            rbt_naoCongestao = new RadioButton();
            rbt_simCongestao = new RadioButton();
            txb_alergia = new TextBox();
            txb_Intestino = new TextBox();
            txb_congestao = new TextBox();
            SuspendLayout();
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 391);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 22;
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
            bt_proximo.TabIndex = 21;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += button1_Click;
            // 
            // lbl_AlgumaAlergia
            // 
            lbl_AlgumaAlergia.AutoSize = true;
            lbl_AlgumaAlergia.Location = new Point(34, 269);
            lbl_AlgumaAlergia.Name = "lbl_AlgumaAlergia";
            lbl_AlgumaAlergia.Size = new Size(441, 15);
            lbl_AlgumaAlergia.TabIndex = 19;
            lbl_AlgumaAlergia.Text = "11- Você observou alguma congestão nasal a noite? Se sim, conte um pouco mais.";
            lbl_AlgumaAlergia.Click += lbl_4_Click;
            // 
            // lbl_bebeColica
            // 
            lbl_bebeColica.AutoSize = true;
            lbl_bebeColica.Location = new Point(42, 38);
            lbl_bebeColica.Name = "lbl_bebeColica";
            lbl_bebeColica.Size = new Size(106, 15);
            lbl_bebeColica.TabIndex = 18;
            lbl_bebeColica.Text = "9- Alguma alergia?";
            // 
            // rbt_simAlergia
            // 
            rbt_simAlergia.AutoSize = true;
            rbt_simAlergia.Location = new Point(154, 38);
            rbt_simAlergia.Name = "rbt_simAlergia";
            rbt_simAlergia.Size = new Size(45, 19);
            rbt_simAlergia.TabIndex = 23;
            rbt_simAlergia.TabStop = true;
            rbt_simAlergia.Text = "Sim";
            rbt_simAlergia.UseVisualStyleBackColor = true;
            rbt_simAlergia.CheckedChanged += rbt_simAlergia_CheckedChanged_1;
            // 
            // rbt_naoAlergia
            // 
            rbt_naoAlergia.AutoSize = true;
            rbt_naoAlergia.Location = new Point(205, 38);
            rbt_naoAlergia.Name = "rbt_naoAlergia";
            rbt_naoAlergia.Size = new Size(47, 19);
            rbt_naoAlergia.TabIndex = 24;
            rbt_naoAlergia.TabStop = true;
            rbt_naoAlergia.Text = "Não";
            rbt_naoAlergia.UseVisualStyleBackColor = true;
            rbt_naoAlergia.CheckedChanged += rbt_naoAlergia_CheckedChanged;
            // 
            // lbl_DorOuvido
            // 
            lbl_DorOuvido.AutoSize = true;
            lbl_DorOuvido.Location = new Point(36, 160);
            lbl_DorOuvido.Name = "lbl_DorOuvido";
            lbl_DorOuvido.Size = new Size(167, 15);
            lbl_DorOuvido.TabIndex = 25;
            lbl_DorOuvido.Text = "10- O intestino funciona bem?";
            lbl_DorOuvido.Click += lbl_DorOuvido_Click;
            // 
            // rbt_simIntestino
            // 
            rbt_simIntestino.AutoSize = true;
            rbt_simIntestino.Location = new Point(209, 156);
            rbt_simIntestino.Name = "rbt_simIntestino";
            rbt_simIntestino.Size = new Size(45, 19);
            rbt_simIntestino.TabIndex = 26;
            rbt_simIntestino.TabStop = true;
            rbt_simIntestino.Text = "Sim";
            rbt_simIntestino.UseVisualStyleBackColor = true;
            rbt_simIntestino.CheckedChanged += rbt_simIntestino_CheckedChanged;
            // 
            // rbt_naoIntestino
            // 
            rbt_naoIntestino.AutoSize = true;
            rbt_naoIntestino.Location = new Point(260, 156);
            rbt_naoIntestino.Name = "rbt_naoIntestino";
            rbt_naoIntestino.Size = new Size(47, 19);
            rbt_naoIntestino.TabIndex = 27;
            rbt_naoIntestino.TabStop = true;
            rbt_naoIntestino.Text = "Não";
            rbt_naoIntestino.UseVisualStyleBackColor = true;
            rbt_naoIntestino.CheckedChanged += rbt_naoIntestino_CheckedChanged;
            // 
            // rbt_naoCongestao
            // 
            rbt_naoCongestao.AutoSize = true;
            rbt_naoCongestao.Location = new Point(532, 269);
            rbt_naoCongestao.Name = "rbt_naoCongestao";
            rbt_naoCongestao.Size = new Size(47, 19);
            rbt_naoCongestao.TabIndex = 29;
            rbt_naoCongestao.TabStop = true;
            rbt_naoCongestao.Text = "Não";
            rbt_naoCongestao.UseVisualStyleBackColor = true;
            rbt_naoCongestao.CheckedChanged += rbt_naoCongestao_CheckedChanged;
            // 
            // rbt_simCongestao
            // 
            rbt_simCongestao.AutoSize = true;
            rbt_simCongestao.Location = new Point(481, 269);
            rbt_simCongestao.Name = "rbt_simCongestao";
            rbt_simCongestao.Size = new Size(45, 19);
            rbt_simCongestao.TabIndex = 28;
            rbt_simCongestao.TabStop = true;
            rbt_simCongestao.Text = "Sim";
            rbt_simCongestao.UseVisualStyleBackColor = true;
            rbt_simCongestao.CheckedChanged += rbt_simCongestao_CheckedChanged;
            // 
            // txb_alergia
            // 
            txb_alergia.Enabled = false;
            txb_alergia.Location = new Point(36, 70);
            txb_alergia.Multiline = true;
            txb_alergia.Name = "txb_alergia";
            txb_alergia.Size = new Size(733, 76);
            txb_alergia.TabIndex = 30;
            // 
            // txb_Intestino
            // 
            txb_Intestino.Enabled = false;
            txb_Intestino.Location = new Point(34, 187);
            txb_Intestino.Multiline = true;
            txb_Intestino.Name = "txb_Intestino";
            txb_Intestino.Size = new Size(733, 76);
            txb_Intestino.TabIndex = 31;
            // 
            // txb_congestao
            // 
            txb_congestao.Enabled = false;
            txb_congestao.Location = new Point(34, 298);
            txb_congestao.Multiline = true;
            txb_congestao.Name = "txb_congestao";
            txb_congestao.Size = new Size(733, 76);
            txb_congestao.TabIndex = 32;
            // 
            // frmP5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_congestao);
            Controls.Add(txb_Intestino);
            Controls.Add(txb_alergia);
            Controls.Add(rbt_naoCongestao);
            Controls.Add(rbt_simCongestao);
            Controls.Add(rbt_naoIntestino);
            Controls.Add(rbt_simIntestino);
            Controls.Add(lbl_DorOuvido);
            Controls.Add(rbt_naoAlergia);
            Controls.Add(rbt_simAlergia);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(lbl_AlgumaAlergia);
            Controls.Add(lbl_bebeColica);
            Name = "frmP5";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_anterior;
        private Button bt_proximo;
        private Label lbl_AlgumaAlergia;
        private Label lbl_bebeColica;
        private RadioButton rbt_simAlergia;
        private RadioButton rbt_naoAlergia;
        private Label lbl_DorOuvido;
        private RadioButton rbt_simIntestino;
        private RadioButton rbt_naoIntestino;
        private RadioButton rbt_naoCongestao;
        private RadioButton rbt_simCongestao;
        private TextBox txb_alergia;
        private TextBox txb_Intestino;
        private TextBox txb_congestao;
    }
}