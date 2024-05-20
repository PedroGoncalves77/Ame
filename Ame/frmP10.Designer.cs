namespace Ame
{
    partial class frmP10
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
            bt_anterior = new Button();
            lbl_22 = new Label();
            lbl_22a = new Label();
            lbl_23 = new Label();
            rbt_sim22 = new RadioButton();
            rbt_nao22 = new RadioButton();
            txt_22 = new TextBox();
            lbl_24 = new Label();
            rbt_sim23 = new RadioButton();
            rbt_nao23 = new RadioButton();
            rbt_sim24 = new RadioButton();
            rbt_nao24 = new RadioButton();
            lbl_24a = new Label();
            txt_24 = new TextBox();
            lbl_25 = new Label();
            txt_25 = new TextBox();
            rbt_sim25 = new RadioButton();
            rbt_nao25 = new RadioButton();
            lbl_25a = new Label();
            SuspendLayout();
            // 
            // bt_proximo
            // 
            bt_proximo.Location = new Point(657, 403);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 0;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // bt_anterior
            // 
            bt_anterior.Location = new Point(22, 403);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 1;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // lbl_22
            // 
            lbl_22.AutoSize = true;
            lbl_22.Location = new Point(22, 24);
            lbl_22.Name = "lbl_22";
            lbl_22.Size = new Size(330, 15);
            lbl_22.TabIndex = 2;
            lbl_22.Text = "22-\tSe você amamenta, você consome alimento com cafeína?";
            // 
            // lbl_22a
            // 
            lbl_22a.AutoSize = true;
            lbl_22a.Location = new Point(22, 54);
            lbl_22a.Name = "lbl_22a";
            lbl_22a.Size = new Size(220, 15);
            lbl_22a.TabIndex = 3;
            lbl_22a.Text = "Se sim, em qual quantidade, frequência?";
            // 
            // lbl_23
            // 
            lbl_23.AutoSize = true;
            lbl_23.Location = new Point(22, 173);
            lbl_23.Name = "lbl_23";
            lbl_23.Size = new Size(213, 15);
            lbl_23.TabIndex = 4;
            lbl_23.Text = "23-\tEle mama somente o leite materno?";
            // 
            // rbt_sim22
            // 
            rbt_sim22.AutoSize = true;
            rbt_sim22.Location = new Point(358, 22);
            rbt_sim22.Name = "rbt_sim22";
            rbt_sim22.Size = new Size(45, 19);
            rbt_sim22.TabIndex = 5;
            rbt_sim22.TabStop = true;
            rbt_sim22.Text = "Sim";
            rbt_sim22.UseVisualStyleBackColor = true;
            rbt_sim22.CheckedChanged += rbt_sim22_CheckedChanged;
            // 
            // rbt_nao22
            // 
            rbt_nao22.AutoSize = true;
            rbt_nao22.Location = new Point(409, 22);
            rbt_nao22.Name = "rbt_nao22";
            rbt_nao22.Size = new Size(47, 19);
            rbt_nao22.TabIndex = 6;
            rbt_nao22.TabStop = true;
            rbt_nao22.Text = "Não";
            rbt_nao22.UseVisualStyleBackColor = true;
            rbt_nao22.CheckedChanged += rbt_nao22_CheckedChanged;
            // 
            // txt_22
            // 
            txt_22.Enabled = false;
            txt_22.Location = new Point(22, 81);
            txt_22.Multiline = true;
            txt_22.Name = "txt_22";
            txt_22.Size = new Size(749, 75);
            txt_22.TabIndex = 7;
            txt_22.TextChanged += textBox1_TextChanged;
            // 
            // lbl_24
            // 
            lbl_24.AutoSize = true;
            lbl_24.Location = new Point(22, 202);
            lbl_24.Name = "lbl_24";
            lbl_24.Size = new Size(132, 15);
            lbl_24.TabIndex = 8;
            lbl_24.Text = "24- Tem complemento?";
            // 
            // rbt_sim23
            // 
            rbt_sim23.AutoSize = true;
            rbt_sim23.Location = new Point(241, 171);
            rbt_sim23.Name = "rbt_sim23";
            rbt_sim23.Size = new Size(45, 19);
            rbt_sim23.TabIndex = 9;
            rbt_sim23.TabStop = true;
            rbt_sim23.Text = "Sim";
            rbt_sim23.UseVisualStyleBackColor = true;
            // 
            // rbt_nao23
            // 
            rbt_nao23.AutoSize = true;
            rbt_nao23.Location = new Point(292, 171);
            rbt_nao23.Name = "rbt_nao23";
            rbt_nao23.Size = new Size(47, 19);
            rbt_nao23.TabIndex = 10;
            rbt_nao23.TabStop = true;
            rbt_nao23.Text = "Não";
            rbt_nao23.UseVisualStyleBackColor = true;
            // 
            // rbt_sim24
            // 
            rbt_sim24.AutoSize = true;
            rbt_sim24.Location = new Point(158, 200);
            rbt_sim24.Name = "rbt_sim24";
            rbt_sim24.Size = new Size(45, 19);
            rbt_sim24.TabIndex = 11;
            rbt_sim24.TabStop = true;
            rbt_sim24.Text = "Sim";
            rbt_sim24.UseVisualStyleBackColor = true;
            rbt_sim24.CheckedChanged += rbt_sim24_CheckedChanged;
            // 
            // rbt_nao24
            // 
            rbt_nao24.AutoSize = true;
            rbt_nao24.Location = new Point(209, 200);
            rbt_nao24.Name = "rbt_nao24";
            rbt_nao24.Size = new Size(47, 19);
            rbt_nao24.TabIndex = 12;
            rbt_nao24.TabStop = true;
            rbt_nao24.Text = "Não";
            rbt_nao24.UseVisualStyleBackColor = true;
            rbt_nao24.CheckedChanged += rbt_nao24_CheckedChanged;
            // 
            // lbl_24a
            // 
            lbl_24a.AutoSize = true;
            lbl_24a.Location = new Point(22, 230);
            lbl_24a.Name = "lbl_24a";
            lbl_24a.Size = new Size(289, 15);
            lbl_24a.TabIndex = 13;
            lbl_24a.Text = "Com quantos meses o complemento foi introduzido?";
            // 
            // txt_24
            // 
            txt_24.Enabled = false;
            txt_24.Location = new Point(317, 227);
            txt_24.Name = "txt_24";
            txt_24.Size = new Size(194, 23);
            txt_24.TabIndex = 14;
            // 
            // lbl_25
            // 
            lbl_25.AutoSize = true;
            lbl_25.Location = new Point(22, 259);
            lbl_25.Name = "lbl_25";
            lbl_25.Size = new Size(231, 15);
            lbl_25.TabIndex = 15;
            lbl_25.Text = "25- Foi introduzido algum outro alimento?";
            // 
            // txt_25
            // 
            txt_25.Enabled = false;
            txt_25.Location = new Point(22, 297);
            txt_25.Multiline = true;
            txt_25.Name = "txt_25";
            txt_25.Size = new Size(749, 82);
            txt_25.TabIndex = 16;
            // 
            // rbt_sim25
            // 
            rbt_sim25.AutoSize = true;
            rbt_sim25.Location = new Point(259, 255);
            rbt_sim25.Name = "rbt_sim25";
            rbt_sim25.Size = new Size(45, 19);
            rbt_sim25.TabIndex = 17;
            rbt_sim25.TabStop = true;
            rbt_sim25.Text = "Sim";
            rbt_sim25.UseVisualStyleBackColor = true;
            rbt_sim25.CheckedChanged += rbt_sim25_CheckedChanged;
            // 
            // rbt_nao25
            // 
            rbt_nao25.AutoSize = true;
            rbt_nao25.Location = new Point(309, 255);
            rbt_nao25.Name = "rbt_nao25";
            rbt_nao25.Size = new Size(47, 19);
            rbt_nao25.TabIndex = 18;
            rbt_nao25.TabStop = true;
            rbt_nao25.Text = "Não";
            rbt_nao25.UseVisualStyleBackColor = true;
            rbt_nao25.CheckedChanged += rbt_nao25_CheckedChanged;
            // 
            // lbl_25a
            // 
            lbl_25a.AutoSize = true;
            lbl_25a.Location = new Point(22, 277);
            lbl_25a.Name = "lbl_25a";
            lbl_25a.Size = new Size(57, 15);
            lbl_25a.TabIndex = 19;
            lbl_25a.Text = "Descreva:";
            // 
            // frmP10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_25a);
            Controls.Add(rbt_nao25);
            Controls.Add(rbt_sim25);
            Controls.Add(txt_25);
            Controls.Add(lbl_25);
            Controls.Add(txt_24);
            Controls.Add(lbl_24a);
            Controls.Add(rbt_nao24);
            Controls.Add(rbt_sim24);
            Controls.Add(rbt_nao23);
            Controls.Add(rbt_sim23);
            Controls.Add(lbl_24);
            Controls.Add(txt_22);
            Controls.Add(rbt_nao22);
            Controls.Add(rbt_sim22);
            Controls.Add(lbl_23);
            Controls.Add(lbl_22a);
            Controls.Add(lbl_22);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP10";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmP10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_proximo;
        private Button bt_anterior;
        private Label lbl_22;
        private Label lbl_22a;
        private Label lbl_23;
        private RadioButton rbt_sim22;
        private RadioButton rbt_nao22;
        private TextBox txt_22;
        private Label lbl_24;
        private RadioButton rbt_sim23;
        private RadioButton rbt_nao23;
        private RadioButton rbt_sim24;
        private RadioButton rbt_nao24;
        private Label lbl_24a;
        private TextBox txt_24;
        private Label lbl_25;
        private TextBox txt_25;
        private RadioButton rbt_sim25;
        private RadioButton rbt_nao25;
        private Label lbl_25a;
    }
}