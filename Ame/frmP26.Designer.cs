using Ame.Modelo;

namespace Ame
{
    partial class frmP26
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
            rbt_nao66 = new RadioButton();
            rbt_sim66 = new RadioButton();
            txt_61 = new TextBox();
            lbl_58 = new Label();
            txt_66 = new TextBox();
            lbl_66 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            lbl_66a = new Label();
            txt_67 = new TextBox();
            lbl_67 = new Label();
            txt_68 = new TextBox();
            lbl_68 = new Label();
            SuspendLayout();
            // 
            // rbt_nao66
            // 
            rbt_nao66.AutoSize = true;
            rbt_nao66.Location = new Point(592, 17);
            rbt_nao66.Name = "rbt_nao66";
            rbt_nao66.Size = new Size(47, 19);
            rbt_nao66.TabIndex = 136;
            rbt_nao66.TabStop = true;
            rbt_nao66.Text = "Não";
            rbt_nao66.UseVisualStyleBackColor = true;
            rbt_nao66.CheckedChanged += rbt_nao66_CheckedChanged;
            // 
            // rbt_sim66
            // 
            rbt_sim66.AutoSize = true;
            rbt_sim66.Location = new Point(541, 17);
            rbt_sim66.Name = "rbt_sim66";
            rbt_sim66.Size = new Size(45, 19);
            rbt_sim66.TabIndex = 135;
            rbt_sim66.TabStop = true;
            rbt_sim66.Text = "Sim";
            rbt_sim66.UseVisualStyleBackColor = true;
            rbt_sim66.CheckedChanged += rbt_sim66_CheckedChanged;
            // 
            // txt_61
            // 
            txt_61.Location = new Point(0, 0);
            txt_61.Name = "txt_61";
            txt_61.Size = new Size(100, 23);
            txt_61.TabIndex = 0;
            // 
            // lbl_58
            // 
            lbl_58.AutoSize = true;
            lbl_58.Location = new Point(23, 282);
            lbl_58.Name = "lbl_58";
            lbl_58.Size = new Size(240, 15);
            lbl_58.TabIndex = 130;
            lbl_58.Text = "68- Que horas a criança acorda pela manhã?";
            // 
            // txt_66
            // 
            txt_66.Location = new Point(23, 60);
            txt_66.Multiline = true;
            txt_66.Name = "txt_66";
            txt_66.Size = new Size(755, 68);
            txt_66.TabIndex = 127;
            txt_66.Enabled = false; 
            // 
            // lbl_66
            // 
            lbl_66.AutoSize = true;
            lbl_66.Location = new Point(23, 19);
            lbl_66.Name = "lbl_66";
            lbl_66.Size = new Size(511, 15);
            lbl_66.TabIndex = 126;
            lbl_66.Text = "66- Existe algum ritual para as sonecas e sono noturno que seja feito todo dia da mesma forma?";
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
            // lbl_66a
            // 
            lbl_66a.AutoSize = true;
            lbl_66a.Location = new Point(23, 36);
            lbl_66a.Name = "lbl_66a";
            lbl_66a.Size = new Size(57, 15);
            lbl_66a.TabIndex = 137;
            lbl_66a.Text = "Descreva:";
            // 
            // txt_67
            // 
            txt_67.Location = new Point(23, 191);
            txt_67.Multiline = true;
            txt_67.Name = "txt_67";
            txt_67.Size = new Size(755, 77);
            txt_67.TabIndex = 139;
            // 
            // lbl_67
            // 
            lbl_67.Location = new Point(23, 150);
            lbl_67.Name = "lbl_67";
            lbl_67.Size = new Size(755, 38);
            lbl_67.TabIndex = 138;
            lbl_67.Text = "67- Descreva quem cuida da criança de madrugada e como isso acontece (se a criança chora, como ela é atendida/confortada/como volta a dormir).";
            // 
            // txt_68
            // 
            txt_68.Location = new Point(23, 301);
            txt_68.Multiline = true;
            txt_68.Name = "txt_68";
            txt_68.Size = new Size(755, 80);
            txt_68.TabIndex = 144;
            // 
            // lbl_68
            // 
            lbl_68.AutoSize = true;
            lbl_68.Location = new Point(23, 283);
            lbl_68.Name = "lbl_68";
            lbl_68.Size = new Size(243, 15);
            lbl_68.TabIndex = 143;
            lbl_68.Text = "68- Que horas a criança acorda pela manhã? ";
            // 
            // frmP26
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_68);
            Controls.Add(lbl_68);
            Controls.Add(txt_67);
            Controls.Add(lbl_67);
            Controls.Add(lbl_66a);
            Controls.Add(rbt_nao66);
            Controls.Add(rbt_sim66);
            Controls.Add(txt_66);
            Controls.Add(lbl_66);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP26";
            Text = "frmP26";
            Load += frmP26_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_61a;
        private RadioButton rbt_nao61b;
        private RadioButton rbt_sim61b;
        private RadioButton rbt_nao66;
        private RadioButton rbt_sim66;
        private TextBox txt_62;
        private Label lbl_59;
        private TextBox txt_61;
        private Label lbl_58;
        private TextBox txt_66;
        private Label lbl_66;
        private Button bt_anterior;
        private Button bt_proximo;
        private Label lbl_66a;
        private TextBox txt_67;
        private Label lbl_67;
        private TextBox txt_68;
        private Label lbl_68;
        private FichaBebeTresMeses Ficha { get; set; }
        private ProblemaSono ProblemaSono { get; set; }
    }
}