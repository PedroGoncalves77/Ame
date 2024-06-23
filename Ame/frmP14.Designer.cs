using Ame.Modelo;

namespace Ame
{
    partial class frmP14
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
            txt_35 = new TextBox();
            txt_36 = new TextBox();
            lbl_36 = new Label();
            lbl_35 = new Label();
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
            bt_anterior.Click += bt_anterior_Click;
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
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txt_35
            // 
            txt_35.Location = new Point(34, 53);
            txt_35.Multiline = true;
            txt_35.Name = "txt_35";
            txt_35.Size = new Size(697, 126);
            txt_35.TabIndex = 33;
            // 
            // txt_36
            // 
            txt_36.Location = new Point(34, 223);
            txt_36.Multiline = true;
            txt_36.Name = "txt_36";
            txt_36.Size = new Size(697, 126);
            txt_36.TabIndex = 32;
            // 
            // lbl_36
            // 
            lbl_36.AutoSize = true;
            lbl_36.Location = new Point(34, 202);
            lbl_36.Name = "lbl_36";
            lbl_36.Size = new Size(331, 15);
            lbl_36.TabIndex = 31;
            lbl_36.Text = "36- Qual foi a maior dificuldade dos pais em relação ao bebê?";
            // 
            // lbl_35
            // 
            lbl_35.AutoSize = true;
            lbl_35.Location = new Point(34, 26);
            lbl_35.Name = "lbl_35";
            lbl_35.Size = new Size(263, 15);
            lbl_35.TabIndex = 30;
            lbl_35.Text = "35- Como foi a gestação, parto e amamentação?";
            // 
            // frmP14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_35);
            Controls.Add(txt_36);
            Controls.Add(lbl_36);
            Controls.Add(lbl_35);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP14";
            Text = "frmP14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txt_35;
        private TextBox txt_36;
        private Label lbl_36;
        private Label lbl_35;
        private FichaBebeTresMeses Ficha { get; set; }
        private SobrePais SobrePais { get; set; }
    }
}