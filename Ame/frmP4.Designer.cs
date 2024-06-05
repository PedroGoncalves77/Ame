using Ame.Modelo;

namespace Ame
{
    partial class frmP4
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
            txt_7 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txt_8 = new TextBox();
            lbl_7 = new Label();
            lbl_8 = new Label();
            lbl_7a = new Label();
            rbt_sim8 = new RadioButton();
            rbt_nao8 = new RadioButton();
            lbl_8a = new Label();
            rbt_sim7 = new RadioButton();
            rbt_nao7 = new RadioButton();
            SuspendLayout();
            // 
            // txt_7
            // 
            txt_7.Enabled = false;
            txt_7.Location = new Point(34, 86);
            txt_7.Multiline = true;
            txt_7.Name = "txt_7";
            txt_7.Size = new Size(697, 102);
            txt_7.TabIndex = 23;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 402);
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
            bt_proximo.Location = new Point(653, 402);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 21;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += button1_Click;
            // 
            // txt_8
            // 
            txt_8.Enabled = false;
            txt_8.Location = new Point(34, 249);
            txt_8.Multiline = true;
            txt_8.Name = "txt_8";
            txt_8.Size = new Size(697, 126);
            txt_8.TabIndex = 20;
            // 
            // lbl_7
            // 
            lbl_7.AutoSize = true;
            lbl_7.Location = new Point(34, 37);
            lbl_7.Name = "lbl_7";
            lbl_7.Size = new Size(128, 15);
            lbl_7.TabIndex = 18;
            lbl_7.Text = "7-O bebê teve cólicas ?";
            lbl_7.Click += lbl_bebeColica_Click;
            // 
            // lbl_8
            // 
            lbl_8.AutoSize = true;
            lbl_8.Location = new Point(34, 203);
            lbl_8.Name = "lbl_8";
            lbl_8.Size = new Size(168, 15);
            lbl_8.TabIndex = 24;
            lbl_8.Text = "8-\tDores de ouvido frequentes?";
            lbl_8.Click += lbl_dorOuvido_Click;
            // 
            // lbl_7a
            // 
            lbl_7a.AutoSize = true;
            lbl_7a.Location = new Point(34, 68);
            lbl_7a.Name = "lbl_7a";
            lbl_7a.Size = new Size(57, 15);
            lbl_7a.TabIndex = 25;
            lbl_7a.Text = "Descreva:";
            // 
            // rbt_sim8
            // 
            rbt_sim8.AutoSize = true;
            rbt_sim8.Location = new Point(208, 199);
            rbt_sim8.Name = "rbt_sim8";
            rbt_sim8.Size = new Size(45, 19);
            rbt_sim8.TabIndex = 26;
            rbt_sim8.TabStop = true;
            rbt_sim8.Text = "Sim";
            rbt_sim8.UseVisualStyleBackColor = true;
            rbt_sim8.CheckedChanged += rbt_simOuvido_CheckedChanged;
            // 
            // rbt_nao8
            // 
            rbt_nao8.AutoSize = true;
            rbt_nao8.Location = new Point(259, 199);
            rbt_nao8.Name = "rbt_nao8";
            rbt_nao8.Size = new Size(47, 19);
            rbt_nao8.TabIndex = 27;
            rbt_nao8.TabStop = true;
            rbt_nao8.Text = "Não";
            rbt_nao8.UseVisualStyleBackColor = true;
            rbt_nao8.CheckedChanged += rbt_naoOuvido_CheckedChanged;
            // 
            // lbl_8a
            // 
            lbl_8a.AutoSize = true;
            lbl_8a.Location = new Point(34, 231);
            lbl_8a.Name = "lbl_8a";
            lbl_8a.Size = new Size(57, 15);
            lbl_8a.TabIndex = 28;
            lbl_8a.Text = "Descreva:";
            // 
            // rbt_sim7
            // 
            rbt_sim7.AutoSize = true;
            rbt_sim7.Location = new Point(168, 35);
            rbt_sim7.Name = "rbt_sim7";
            rbt_sim7.Size = new Size(45, 19);
            rbt_sim7.TabIndex = 29;
            rbt_sim7.TabStop = true;
            rbt_sim7.Text = "Sim";
            rbt_sim7.UseVisualStyleBackColor = true;
            rbt_sim7.CheckedChanged += rbt_simColica_CheckedChanged;
            // 
            // rbt_nao7
            // 
            rbt_nao7.AutoSize = true;
            rbt_nao7.Location = new Point(219, 37);
            rbt_nao7.Name = "rbt_nao7";
            rbt_nao7.Size = new Size(47, 19);
            rbt_nao7.TabIndex = 30;
            rbt_nao7.TabStop = true;
            rbt_nao7.Text = "Não";
            rbt_nao7.UseVisualStyleBackColor = true;
            rbt_nao7.CheckedChanged += rbt_naoColica_CheckedChanged;
            // 
            // frmP4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_nao7);
            Controls.Add(rbt_sim7);
            Controls.Add(lbl_8a);
            Controls.Add(rbt_nao8);
            Controls.Add(rbt_sim8);
            Controls.Add(lbl_7a);
            Controls.Add(lbl_8);
            Controls.Add(txt_7);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_8);
            Controls.Add(lbl_7);
            Name = "frmP4";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmP4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_7;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_8;
        private Label lbl_7;
        private Label lbl_8;
        private Label lbl_7a;
        private RadioButton rbt_sim8;
        private RadioButton rbt_nao8;
        private Label lbl_8a;
        private RadioButton rbt_sim7;
        private RadioButton rbt_nao7;
        private FichaBebeTresMeses Ficha { get; set; }
        private SaudeDaCrianca SaudeDaCrianca { get; set; }
        
    }
}