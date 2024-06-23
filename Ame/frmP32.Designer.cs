using Ame.Modelo;

namespace Ame
{
    partial class frmP32
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
            txt_89b = new TextBox();
            lbl_89b = new Label();
            rbt_nao87 = new RadioButton();
            rbt_sim87 = new RadioButton();
            rbt_nao88 = new RadioButton();
            rbt_sim88 = new RadioButton();
            txt_89a = new TextBox();
            lbl_88 = new Label();
            lbl_89 = new Label();
            lbl_87 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            lbl_89a = new Label();
            rbt_nao89 = new RadioButton();
            rbt_sim89 = new RadioButton();
            SuspendLayout();
            // 
            // txt_89b
            // 
            txt_89b.Enabled = false;
            txt_89b.Location = new Point(21, 268);
            txt_89b.Multiline = true;
            txt_89b.Name = "txt_89b";
            txt_89b.Size = new Size(755, 87);
            txt_89b.TabIndex = 259;
            // 
            // lbl_89b
            // 
            lbl_89b.AutoSize = true;
            lbl_89b.Location = new Point(21, 250);
            lbl_89b.Name = "lbl_89b";
            lbl_89b.Size = new Size(113, 15);
            lbl_89b.TabIndex = 258;
            lbl_89b.Text = "Em que momentos?";
            // 
            // rbt_nao87
            // 
            rbt_nao87.AutoSize = true;
            rbt_nao87.Location = new Point(80, 31);
            rbt_nao87.Name = "rbt_nao87";
            rbt_nao87.Size = new Size(47, 19);
            rbt_nao87.TabIndex = 257;
            rbt_nao87.TabStop = true;
            rbt_nao87.Text = "Não";
            rbt_nao87.UseVisualStyleBackColor = true;
            rbt_nao87.CheckedChanged += rbt_nao87_CheckedChanged;
            // 
            // rbt_sim87
            // 
            rbt_sim87.AutoSize = true;
            rbt_sim87.Location = new Point(29, 31);
            rbt_sim87.Name = "rbt_sim87";
            rbt_sim87.Size = new Size(45, 19);
            rbt_sim87.TabIndex = 256;
            rbt_sim87.TabStop = true;
            rbt_sim87.Text = "Sim";
            rbt_sim87.UseVisualStyleBackColor = true;
            rbt_sim87.CheckedChanged += rbt_sim87_CheckedChanged;
            // 
            // rbt_nao88
            // 
            rbt_nao88.AutoSize = true;
            rbt_nao88.Location = new Point(80, 69);
            rbt_nao88.Name = "rbt_nao88";
            rbt_nao88.Size = new Size(47, 19);
            rbt_nao88.TabIndex = 255;
            rbt_nao88.TabStop = true;
            rbt_nao88.Text = "Não";
            rbt_nao88.UseVisualStyleBackColor = true;
            rbt_nao88.CheckedChanged += rbt_nao88_CheckedChanged;
            // 
            // rbt_sim88
            // 
            rbt_sim88.AutoSize = true;
            rbt_sim88.Location = new Point(29, 69);
            rbt_sim88.Name = "rbt_sim88";
            rbt_sim88.Size = new Size(45, 19);
            rbt_sim88.TabIndex = 254;
            rbt_sim88.TabStop = true;
            rbt_sim88.Text = "Sim";
            rbt_sim88.UseVisualStyleBackColor = true;
            rbt_sim88.CheckedChanged += rbt_sim88_CheckedChanged;
            // 
            // txt_89a
            // 
            txt_89a.Enabled = false;
            txt_89a.Location = new Point(22, 160);
            txt_89a.Multiline = true;
            txt_89a.Name = "txt_89a";
            txt_89a.Size = new Size(755, 87);
            txt_89a.TabIndex = 253;
            // 
            // lbl_88
            // 
            lbl_88.AutoSize = true;
            lbl_88.Location = new Point(23, 53);
            lbl_88.Name = "lbl_88";
            lbl_88.Size = new Size(173, 15);
            lbl_88.TabIndex = 252;
            lbl_88.Text = "88- Onde o bebê dorme de dia?";
            // 
            // lbl_89
            // 
            lbl_89.AutoSize = true;
            lbl_89.Location = new Point(24, 99);
            lbl_89.Name = "lbl_89";
            lbl_89.Size = new Size(156, 15);
            lbl_89.TabIndex = 251;
            lbl_89.Text = "89- Possui mobile no berço?";
            // 
            // lbl_87
            // 
            lbl_87.AutoSize = true;
            lbl_87.Location = new Point(22, 13);
            lbl_87.Name = "lbl_87";
            lbl_87.Size = new Size(177, 15);
            lbl_87.TabIndex = 250;
            lbl_87.Text = "87- Onde o bebê dorme a noite?";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(22, 415);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 249;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(663, 415);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 248;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // lbl_89a
            // 
            lbl_89a.AutoSize = true;
            lbl_89a.Location = new Point(23, 142);
            lbl_89a.Name = "lbl_89a";
            lbl_89a.Size = new Size(143, 15);
            lbl_89a.TabIndex = 260;
            lbl_89a.Text = "Liga com que frequência?";
            // 
            // rbt_nao89
            // 
            rbt_nao89.AutoSize = true;
            rbt_nao89.Location = new Point(81, 117);
            rbt_nao89.Name = "rbt_nao89";
            rbt_nao89.Size = new Size(47, 19);
            rbt_nao89.TabIndex = 262;
            rbt_nao89.TabStop = true;
            rbt_nao89.Text = "Não";
            rbt_nao89.UseVisualStyleBackColor = true;
            rbt_nao89.CheckedChanged += rbt_nao89_CheckedChanged;
            // 
            // rbt_sim89
            // 
            rbt_sim89.AutoSize = true;
            rbt_sim89.Location = new Point(30, 117);
            rbt_sim89.Name = "rbt_sim89";
            rbt_sim89.Size = new Size(45, 19);
            rbt_sim89.TabIndex = 261;
            rbt_sim89.TabStop = true;
            rbt_sim89.Text = "Sim";
            rbt_sim89.UseVisualStyleBackColor = true;
            rbt_sim89.CheckedChanged += rbt_sim89_CheckedChanged;
            // 
            // frmP32
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_nao89);
            Controls.Add(rbt_sim89);
            Controls.Add(lbl_89a);
            Controls.Add(txt_89b);
            Controls.Add(lbl_89b);
            Controls.Add(rbt_nao87);
            Controls.Add(rbt_sim87);
            Controls.Add(rbt_nao88);
            Controls.Add(rbt_sim88);
            Controls.Add(txt_89a);
            Controls.Add(lbl_88);
            Controls.Add(lbl_89);
            Controls.Add(lbl_87);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP32";
            Text = "frmP32";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_89b;
        private Label lbl_89b;
        private RadioButton rbt_nao87;
        private RadioButton rbt_sim87;
        private RadioButton rbt_nao88;
        private RadioButton rbt_sim88;
        private TextBox txt_89a;
        private Label lbl_88;
        private Label lbl_89;
        private Label lbl_87;
        private Button bt_anterior;
        private Button bt_proximo;
        private Label lbl_89a;
        private RadioButton rbt_nao89;
        private RadioButton rbt_sim89;
        private FichaBebeTresMeses Ficha { get; set; }
        private AmbienteSono AmbienteSono { get; set; }
    }
}