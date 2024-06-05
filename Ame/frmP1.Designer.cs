using Ame.Modelo;
using System.Runtime.CompilerServices;

namespace Ame
{
    partial class frmP1
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
            lbl_1 = new Label();
            lbl_2 = new Label();
            txt_2 = new TextBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(31, 47);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(224, 15);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "1- Quando foi a última visita ao pediatra?";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(31, 251);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(264, 15);
            lbl_2.TabIndex = 1;
            lbl_2.Text = "2- O que o pediatra diz sobre a saúde da criança?";
            // 
            // txt_2
            // 
            txt_2.Location = new Point(31, 283);
            txt_2.Multiline = true;
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(697, 126);
            txt_2.TabIndex = 3;
            txt_2.TextChanged += txb_sobreSaude_TextChanged;
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
            button1.Enabled = false;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(31, 80);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // frmP1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(txt_2);
            Controls.Add(lbl_2);
            Controls.Add(lbl_1);
            Name = "frmP1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_P1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_1;
        private Label lbl_2;
        private TextBox txt_2;
        private Button button1;
        private FichaBebeTresMeses Ficha;
        private MonthCalendar monthCalendar1;
        public SaudeDaCrianca SaudeDaCrianca{ get; set; }
    }
}