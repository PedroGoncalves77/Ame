using Ame.Modelo;

namespace Ame
{
    partial class frmP22
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
            txt_56 = new TextBox();
            lbl_56a = new Label();
            rbt_nao56 = new RadioButton();
            rbt_sim56 = new RadioButton();
            lbl_56 = new Label();
            txt_55 = new TextBox();
            lbl_55 = new Label();
            txt_54 = new TextBox();
            lbl_54 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            SuspendLayout();
            // 
            // txt_56
            // 
            txt_56.Location = new Point(23, 309);
            txt_56.Multiline = true;
            txt_56.Name = "txt_56";
            txt_56.Size = new Size(755, 84);
            txt_56.TabIndex = 98;
            txt_56.Enabled = false;
            // 
            // lbl_56a
            // 
            lbl_56a.AutoSize = true;
            lbl_56a.Location = new Point(23, 291);
            lbl_56a.Name = "lbl_56a";
            lbl_56a.Size = new Size(293, 15);
            lbl_56a.TabIndex = 97;
            lbl_56a.Text = "Descreva como é essa ajuda, dias da semana, horários.";
            // 
            // rbt_nao56
            // 
            rbt_nao56.AutoSize = true;
            rbt_nao56.Location = new Point(391, 274);
            rbt_nao56.Name = "rbt_nao56";
            rbt_nao56.Size = new Size(47, 19);
            rbt_nao56.TabIndex = 96;
            rbt_nao56.TabStop = true;
            rbt_nao56.Text = "Não";
            rbt_nao56.UseVisualStyleBackColor = true;
            rbt_nao56.CheckedChanged += rbt_nao56_CheckedChanged;
            // 
            // rbt_sim56
            // 
            rbt_sim56.AutoSize = true;
            rbt_sim56.Location = new Point(340, 274);
            rbt_sim56.Name = "rbt_sim56";
            rbt_sim56.Size = new Size(45, 19);
            rbt_sim56.TabIndex = 95;
            rbt_sim56.TabStop = true;
            rbt_sim56.Text = "Sim";
            rbt_sim56.UseVisualStyleBackColor = true;
            rbt_sim56.CheckedChanged += rbt_sim56_CheckedChanged;
            // 
            // lbl_56
            // 
            lbl_56.AutoSize = true;
            lbl_56.Location = new Point(23, 276);
            lbl_56.Name = "lbl_56";
            lbl_56.Size = new Size(316, 15);
            lbl_56.TabIndex = 94;
            lbl_56.Text = "56-\tVocê possui ajuda de alguém com tarefas fixas da casa?";
            // 
            // txt_55
            // 
            txt_55.Location = new Point(23, 162);
            txt_55.Multiline = true;
            txt_55.Name = "txt_55";
            txt_55.Size = new Size(755, 70);
            txt_55.TabIndex = 93;
            // 
            // lbl_55
            // 
            lbl_55.AutoSize = true;
            lbl_55.Location = new Point(23, 144);
            lbl_55.Name = "lbl_55";
            lbl_55.Size = new Size(678, 15);
            lbl_55.TabIndex = 86;
            lbl_55.Text = "55- Como ele responde a estímulos sensoriais? Muito sensível à luz, chora com barulhos não muito altos, se assusta facilmente?";
            // 
            // txt_54
            // 
            txt_54.Location = new Point(23, 40);
            txt_54.Multiline = true;
            txt_54.Name = "txt_54";
            txt_54.Size = new Size(755, 68);
            txt_54.TabIndex = 85;
            // 
            // lbl_54
            // 
            lbl_54.AutoSize = true;
            lbl_54.Location = new Point(23, 20);
            lbl_54.Name = "lbl_54";
            lbl_54.Size = new Size(290, 15);
            lbl_54.TabIndex = 84;
            lbl_54.Text = "54- Com que frequência você recebe visitas em casa? ";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(23, 410);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 83;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(664, 410);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 82;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // frmP22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_56);
            Controls.Add(lbl_56a);
            Controls.Add(rbt_nao56);
            Controls.Add(rbt_sim56);
            Controls.Add(lbl_56);
            Controls.Add(txt_55);
            Controls.Add(lbl_55);
            Controls.Add(txt_54);
            Controls.Add(lbl_54);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP22";
            Text = "frmP22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_56;
        private Label lbl_56a;
        private RadioButton rbt_nao56;
        private RadioButton rbt_sim56;
        private Label lbl_56;
        private TextBox txt_55;
        private Label lbl_55;
        private TextBox txt_54;
        private Label lbl_54;
        private Button bt_anterior;
        private Button bt_proximo;
        private FichaBebeTresMeses Ficha { get; set; }
        private DinamicaFamiliar DinamicaFamiliar { get; set; }
    }
}