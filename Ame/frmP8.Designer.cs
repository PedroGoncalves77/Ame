namespace Ame
{
    partial class frmP8
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
            txt_16 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txt_18 = new TextBox();
            lbl_16 = new Label();
            lbl_17 = new Label();
            lbl_18 = new Label();
            lbl_19 = new Label();
            txt_19 = new TextBox();
            rbt_sim17 = new RadioButton();
            rbt_nao17 = new RadioButton();
            SuspendLayout();
            // 
            // txt_16
            // 
            txt_16.Location = new Point(34, 37);
            txt_16.Name = "txt_16";
            txt_16.Size = new Size(697, 23);
            txt_16.TabIndex = 29;
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
            // txt_18
            // 
            txt_18.Enabled = false;
            txt_18.Location = new Point(34, 133);
            txt_18.Multiline = true;
            txt_18.Name = "txt_18";
            txt_18.Size = new Size(697, 92);
            txt_18.TabIndex = 26;
            // 
            // lbl_16
            // 
            lbl_16.AutoSize = true;
            lbl_16.Location = new Point(34, 19);
            lbl_16.Name = "lbl_16";
            lbl_16.Size = new Size(147, 15);
            lbl_16.TabIndex = 25;
            lbl_16.Text = "16- Onde tem TV em casa?";
            // 
            // lbl_17
            // 
            lbl_17.AutoSize = true;
            lbl_17.Location = new Point(34, 72);
            lbl_17.Name = "lbl_17";
            lbl_17.Size = new Size(111, 15);
            lbl_17.TabIndex = 24;
            lbl_17.Text = "17-Ele assiste telas? ";
            // 
            // lbl_18
            // 
            lbl_18.AutoSize = true;
            lbl_18.Location = new Point(34, 103);
            lbl_18.Name = "lbl_18";
            lbl_18.Size = new Size(143, 15);
            lbl_18.TabIndex = 30;
            lbl_18.Text = "18- Com que frequência? ";
            // 
            // lbl_19
            // 
            lbl_19.AutoSize = true;
            lbl_19.Location = new Point(34, 238);
            lbl_19.Name = "lbl_19";
            lbl_19.Size = new Size(177, 15);
            lbl_19.TabIndex = 31;
            lbl_19.Text = "19- Em quais momentos do dia?";
            lbl_19.Click += label2_Click;
            // 
            // txt_19
            // 
            txt_19.Enabled = false;
            txt_19.Location = new Point(34, 268);
            txt_19.Multiline = true;
            txt_19.Name = "txt_19";
            txt_19.Size = new Size(697, 92);
            txt_19.TabIndex = 32;
            // 
            // rbt_sim17
            // 
            rbt_sim17.AutoSize = true;
            rbt_sim17.Location = new Point(151, 70);
            rbt_sim17.Name = "rbt_sim17";
            rbt_sim17.Size = new Size(45, 19);
            rbt_sim17.TabIndex = 33;
            rbt_sim17.TabStop = true;
            rbt_sim17.Text = "Sim";
            rbt_sim17.UseVisualStyleBackColor = true;
            rbt_sim17.CheckedChanged += rbt_simAssisteTela_CheckedChanged;
            // 
            // rbt_nao17
            // 
            rbt_nao17.AutoSize = true;
            rbt_nao17.Location = new Point(202, 70);
            rbt_nao17.Name = "rbt_nao17";
            rbt_nao17.Size = new Size(47, 19);
            rbt_nao17.TabIndex = 34;
            rbt_nao17.TabStop = true;
            rbt_nao17.Text = "Não";
            rbt_nao17.UseVisualStyleBackColor = true;
            rbt_nao17.CheckedChanged += rbt_naoAssisteTela_CheckedChanged;
            // 
            // frmP8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_nao17);
            Controls.Add(rbt_sim17);
            Controls.Add(txt_19);
            Controls.Add(lbl_19);
            Controls.Add(lbl_18);
            Controls.Add(txt_16);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_18);
            Controls.Add(lbl_16);
            Controls.Add(lbl_17);
            Name = "frmP8";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_16;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_18;
        private Label lbl_16;
        private Label lbl_17;
        private Label lbl_18;
        private Label lbl_19;
        private TextBox txt_19;
        private RadioButton rbt_sim17;
        private RadioButton rbt_nao17;
    }
}