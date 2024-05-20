namespace Ame
{
    partial class frmP3
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
            txt_5 = new TextBox();
            btanterior = new Button();
            bt_proximo = new Button();
            txt_6 = new TextBox();
            lbl_6 = new Label();
            lbl_5 = new Label();
            SuspendLayout();
            // 
            // txt_5
            // 
            txt_5.Location = new Point(34, 64);
            txt_5.Multiline = true;
            txt_5.Name = "txt_5";
            txt_5.Size = new Size(697, 126);
            txt_5.TabIndex = 17;
            // 
            // btanterior
            // 
            btanterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btanterior.Location = new Point(34, 391);
            btanterior.Name = "btanterior";
            btanterior.Size = new Size(114, 23);
            btanterior.TabIndex = 16;
            btanterior.Text = "Anterior";
            btanterior.UseVisualStyleBackColor = true;
            btanterior.Click += button2_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(653, 391);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 15;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += button1_Click;
            // 
            // txt_6
            // 
            txt_6.Location = new Point(34, 234);
            txt_6.Multiline = true;
            txt_6.Name = "txt_6";
            txt_6.Size = new Size(697, 126);
            txt_6.TabIndex = 14;
            // 
            // lbl_6
            // 
            lbl_6.AutoSize = true;
            lbl_6.Location = new Point(34, 213);
            lbl_6.Name = "lbl_6";
            lbl_6.Size = new Size(429, 15);
            lbl_6.TabIndex = 13;
            lbl_6.Text = "6- Algum sinal de refluxo agora ou no passado? Se sim, chegou a ser medicado?";
            // 
            // lbl_5
            // 
            lbl_5.AutoSize = true;
            lbl_5.Location = new Point(34, 37);
            lbl_5.Name = "lbl_5";
            lbl_5.Size = new Size(484, 15);
            lbl_5.TabIndex = 12;
            lbl_5.Text = "5- Está se recuperando agora de alguma doença (mesmo uma gripe), cirurgia ou acidente?";
            lbl_5.Click += lbl_3_Click;
            // 
            // frmP3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_5);
            Controls.Add(btanterior);
            Controls.Add(bt_proximo);
            Controls.Add(txt_6);
            Controls.Add(lbl_6);
            Controls.Add(lbl_5);
            Name = "frmP3";
            Text = "frmP3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_5;
        private Button btanterior;
        private Button bt_proximo;
        private TextBox txt_6;
        private Label lbl_6;
        private Label lbl_5;
    }
}