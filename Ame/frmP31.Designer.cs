namespace Ame
{
    partial class frmP31
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
            rbt_nao84 = new RadioButton();
            rbt_sim84 = new RadioButton();
            txt_85 = new TextBox();
            lbl_84 = new Label();
            lbl_85 = new Label();
            lbl_83 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            rbt_nao83 = new RadioButton();
            rbt_sim83 = new RadioButton();
            txt_86 = new TextBox();
            lbl_86 = new Label();
            SuspendLayout();
            // 
            // rbt_nao84
            // 
            rbt_nao84.AutoSize = true;
            rbt_nao84.Location = new Point(81, 85);
            rbt_nao84.Name = "rbt_nao84";
            rbt_nao84.Size = new Size(47, 19);
            rbt_nao84.TabIndex = 242;
            rbt_nao84.TabStop = true;
            rbt_nao84.Text = "Não";
            rbt_nao84.UseVisualStyleBackColor = true;
            // 
            // rbt_sim84
            // 
            rbt_sim84.AutoSize = true;
            rbt_sim84.Location = new Point(30, 85);
            rbt_sim84.Name = "rbt_sim84";
            rbt_sim84.Size = new Size(45, 19);
            rbt_sim84.TabIndex = 241;
            rbt_sim84.TabStop = true;
            rbt_sim84.Text = "Sim";
            rbt_sim84.UseVisualStyleBackColor = true;
            // 
            // txt_85
            // 
            txt_85.Enabled = false;
            txt_85.Location = new Point(24, 134);
            txt_85.Multiline = true;
            txt_85.Name = "txt_85";
            txt_85.Size = new Size(755, 87);
            txt_85.TabIndex = 240;
            // 
            // lbl_84
            // 
            lbl_84.AutoSize = true;
            lbl_84.Location = new Point(24, 69);
            lbl_84.Name = "lbl_84";
            lbl_84.Size = new Size(287, 15);
            lbl_84.TabIndex = 239;
            lbl_84.Text = "84- Liga música ou ruído branco para o bebê dormir?";
            // 
            // lbl_85
            // 
            lbl_85.AutoSize = true;
            lbl_85.Location = new Point(24, 116);
            lbl_85.Name = "lbl_85";
            lbl_85.Size = new Size(380, 15);
            lbl_85.TabIndex = 236;
            lbl_85.Text = "85- Qual material de limpeza você usa para limpar o quarto da criança?";
            // 
            // lbl_83
            // 
            lbl_83.Location = new Point(23, 13);
            lbl_83.Name = "lbl_83";
            lbl_83.Size = new Size(755, 39);
            lbl_83.TabIndex = 234;
            lbl_83.Text = "83- Há algum travesseiro, manta, brinquedos, protetores de berço ou alguma outra coisa que fique no berço quando seu filho(a) está dormindo?";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(23, 415);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 233;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(664, 415);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 232;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // rbt_nao83
            // 
            rbt_nao83.AutoSize = true;
            rbt_nao83.Location = new Point(81, 46);
            rbt_nao83.Name = "rbt_nao83";
            rbt_nao83.Size = new Size(47, 19);
            rbt_nao83.TabIndex = 245;
            rbt_nao83.TabStop = true;
            rbt_nao83.Text = "Não";
            rbt_nao83.UseVisualStyleBackColor = true;
            // 
            // rbt_sim83
            // 
            rbt_sim83.AutoSize = true;
            rbt_sim83.Location = new Point(30, 46);
            rbt_sim83.Name = "rbt_sim83";
            rbt_sim83.Size = new Size(45, 19);
            rbt_sim83.TabIndex = 244;
            rbt_sim83.TabStop = true;
            rbt_sim83.Text = "Sim";
            rbt_sim83.UseVisualStyleBackColor = true;
            // 
            // txt_86
            // 
            txt_86.Enabled = false;
            txt_86.Location = new Point(23, 259);
            txt_86.Multiline = true;
            txt_86.Name = "txt_86";
            txt_86.Size = new Size(755, 87);
            txt_86.TabIndex = 247;
            // 
            // lbl_86
            // 
            lbl_86.AutoSize = true;
            lbl_86.Location = new Point(23, 241);
            lbl_86.Name = "lbl_86";
            lbl_86.Size = new Size(699, 15);
            lbl_86.TabIndex = 246;
            lbl_86.Text = "86- Você diria que a temperatura do quarto é agradável? Possui ar condicionado, aquecedor, ventilador, umidificador de ambiente? ";
            // 
            // frmP31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_86);
            Controls.Add(lbl_86);
            Controls.Add(rbt_nao83);
            Controls.Add(rbt_sim83);
            Controls.Add(rbt_nao84);
            Controls.Add(rbt_sim84);
            Controls.Add(txt_85);
            Controls.Add(lbl_84);
            Controls.Add(lbl_85);
            Controls.Add(lbl_83);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP31";
            Text = "frmP31";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_69a;
        private RadioButton rbt_nao84;
        private RadioButton rbt_sim84;
        private TextBox txt_85;
        private Label lbl_84;
        private Label lbl_85;
        private Label lbl_83;
        private Button bt_anterior;
        private Button bt_proximo;
        private RadioButton rbt_nao83;
        private RadioButton rbt_sim83;
        private TextBox txt_86;
        private Label lbl_86;
    }
}