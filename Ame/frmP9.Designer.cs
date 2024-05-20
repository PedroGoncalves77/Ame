namespace Ame
{
    partial class frmP9
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
            txt_21 = new TextBox();
            lbl_21 = new Label();
            lbl_20 = new Label();
            rbt_nao20 = new RadioButton();
            rbt_sim20 = new RadioButton();
            SuspendLayout();
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
            // txt_21
            // 
            txt_21.Location = new Point(34, 123);
            txt_21.Multiline = true;
            txt_21.Name = "txt_21";
            txt_21.Size = new Size(697, 126);
            txt_21.TabIndex = 26;
            // 
            // lbl_21
            // 
            lbl_21.AutoSize = true;
            lbl_21.Location = new Point(34, 89);
            lbl_21.Name = "lbl_21";
            lbl_21.Size = new Size(274, 15);
            lbl_21.TabIndex = 25;
            lbl_21.Text = "21-\tComo é a rotina de atividades a partir das 17hs?";
            // 
            // lbl_20
            // 
            lbl_20.AutoSize = true;
            lbl_20.Location = new Point(34, 37);
            lbl_20.Name = "lbl_20";
            lbl_20.Size = new Size(126, 15);
            lbl_20.TabIndex = 24;
            lbl_20.Text = "20-Ele brinca no chão?";
            lbl_20.Click += lbl_3_Click;
            // 
            // rbt_nao20
            // 
            rbt_nao20.AutoSize = true;
            rbt_nao20.Location = new Point(88, 55);
            rbt_nao20.Name = "rbt_nao20";
            rbt_nao20.Size = new Size(47, 19);
            rbt_nao20.TabIndex = 140;
            rbt_nao20.TabStop = true;
            rbt_nao20.Text = "Não";
            rbt_nao20.UseVisualStyleBackColor = true;
            // 
            // rbt_sim20
            // 
            rbt_sim20.AutoSize = true;
            rbt_sim20.Location = new Point(37, 55);
            rbt_sim20.Name = "rbt_sim20";
            rbt_sim20.Size = new Size(45, 19);
            rbt_sim20.TabIndex = 139;
            rbt_sim20.TabStop = true;
            rbt_sim20.Text = "Sim";
            rbt_sim20.UseVisualStyleBackColor = true;
            // 
            // frmP9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_nao20);
            Controls.Add(rbt_sim20);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_21);
            Controls.Add(lbl_21);
            Controls.Add(lbl_20);
            Name = "frmP9";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_21;
        private Label lbl_21;
        private Label lbl_20;
        private RadioButton rbt_nao20;
        private RadioButton rbt_sim20;
    }
}