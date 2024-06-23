using Ame.Modelo;

namespace Ame
{
    partial class frmP23
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
            txt_59 = new TextBox();
            lbl_59 = new Label();
            txt_58 = new TextBox();
            lbl_58 = new Label();
            txt_57 = new TextBox();
            lbl_57 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            SuspendLayout();
            // 
            // txt_59
            // 
            txt_59.Location = new Point(23, 293);
            txt_59.Multiline = true;
            txt_59.Name = "txt_59";
            txt_59.Size = new Size(755, 84);
            txt_59.TabIndex = 109;
            // 
            // lbl_59
            // 
            lbl_59.AutoSize = true;
            lbl_59.Location = new Point(23, 275);
            lbl_59.Name = "lbl_59";
            lbl_59.Size = new Size(403, 15);
            lbl_59.TabIndex = 105;
            lbl_59.Text = "59- Se a criança dorme no quarto dela, a noite você fecha a porta? E de dia?";
            // 
            // txt_58
            // 
            txt_58.Location = new Point(23, 161);
            txt_58.Multiline = true;
            txt_58.Name = "txt_58";
            txt_58.Size = new Size(755, 70);
            txt_58.TabIndex = 104;
            // 
            // lbl_58
            // 
            lbl_58.AutoSize = true;
            lbl_58.Location = new Point(23, 143);
            lbl_58.Name = "lbl_58";
            lbl_58.Size = new Size(424, 15);
            lbl_58.TabIndex = 103;
            lbl_58.Text = "58- Como é o ambiente em sua residência durante a noite? Agitado? Tranquilo?";
            // 
            // txt_57
            // 
            txt_57.Location = new Point(23, 39);
            txt_57.Multiline = true;
            txt_57.Name = "txt_57";
            txt_57.Size = new Size(755, 68);
            txt_57.TabIndex = 102;
            // 
            // lbl_57
            // 
            lbl_57.AutoSize = true;
            lbl_57.Location = new Point(23, 19);
            lbl_57.Name = "lbl_57";
            lbl_57.Size = new Size(213, 15);
            lbl_57.TabIndex = 101;
            lbl_57.Text = "57- Você considera sua família agitada?";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(23, 409);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 100;
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
            bt_proximo.TabIndex = 99;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // frmP23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_59);
            Controls.Add(lbl_59);
            Controls.Add(txt_58);
            Controls.Add(lbl_58);
            Controls.Add(txt_57);
            Controls.Add(lbl_57);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP23";
            Text = "frmP23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_59;
        private Label lbl_59;
        private TextBox txt_58;
        private Label lbl_58;
        private TextBox txt_57;
        private Label lbl_57;
        private Button bt_anterior;
        private Button bt_proximo;
        private FichaBebeTresMeses Ficha { get; set; }
        private DinamicaFamiliar DinamicaFamiliar { get; set; }
    }
}