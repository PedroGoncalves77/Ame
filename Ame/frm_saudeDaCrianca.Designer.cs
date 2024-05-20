namespace Ame
{
    partial class frm_P1
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
            label1 = new Label();
            label2 = new Label();
            txb_ultimaVisita = new TextBox();
            txb_sobreSaude = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 0;
            label1.Text = "Quando foi a última visita ao pediatra?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(250, 15);
            label2.TabIndex = 1;
            label2.Text = "O que o pediatra diz sobre a saúde da criança?";
            // 
            // txb_ultimaVisita
            // 
            txb_ultimaVisita.Location = new Point(46, 64);
            txb_ultimaVisita.Name = "txb_ultimaVisita";
            txb_ultimaVisita.Size = new Size(128, 23);
            txb_ultimaVisita.TabIndex = 2;
            // 
            // txb_sobreSaude
            // 
            txb_sobreSaude.Location = new Point(46, 113);
            txb_sobreSaude.Multiline = true;
            txb_sobreSaude.Name = "txb_sobreSaude";
            txb_sobreSaude.Size = new Size(697, 126);
            txb_sobreSaude.TabIndex = 3;
            txb_sobreSaude.TextChanged += txb_sobreSaude_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(665, 415);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 4;
            button1.Text = "Próximo";
            button1.UseVisualStyleBackColor = true;
            // 
            // frm_P1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txb_sobreSaude);
            Controls.Add(txb_ultimaVisita);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_P1";
            Text = "Saúde da criança";
            Load += frm_P1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_ultimaVisita;
        private TextBox txb_sobreSaude;
        private Button button1;
    }
}