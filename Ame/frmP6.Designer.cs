using Ame.Modelo;

namespace Ame
{
    partial class frmP6
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
            txb_suplementacao = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txb_problemaRespiracao = new TextBox();
            lbl_13 = new Label();
            lbl_12 = new Label();
            rbt_sim12 = new RadioButton();
            rbt_nao12 = new RadioButton();
            rbt_sim13 = new RadioButton();
            rbt_nao13 = new RadioButton();
            SuspendLayout();
            // 
            // txb_suplementacao
            // 
            txb_suplementacao.Enabled = false;
            txb_suplementacao.Location = new Point(34, 64);
            txb_suplementacao.Multiline = true;
            txb_suplementacao.Name = "txb_suplementacao";
            txb_suplementacao.Size = new Size(733, 126);
            txb_suplementacao.TabIndex = 23;
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
            bt_anterior.Click += button2_Click;
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
            bt_proximo.Click += button1_Click;
            // 
            // txb_problemaRespiracao
            // 
            txb_problemaRespiracao.Enabled = false;
            txb_problemaRespiracao.Location = new Point(34, 225);
            txb_problemaRespiracao.Multiline = true;
            txb_problemaRespiracao.Name = "txb_problemaRespiracao";
            txb_problemaRespiracao.Size = new Size(733, 142);
            txb_problemaRespiracao.TabIndex = 20;
            // 
            // lbl_13
            // 
            lbl_13.AutoSize = true;
            lbl_13.Location = new Point(34, 202);
            lbl_13.Name = "lbl_13";
            lbl_13.Size = new Size(476, 15);
            lbl_13.TabIndex = 19;
            lbl_13.Text = "13-\tVocê reparou se seu filho ronca, tem problemas de respiração ou sono muito agitado?";
            // 
            // lbl_12
            // 
            lbl_12.AutoSize = true;
            lbl_12.Location = new Point(34, 37);
            lbl_12.Name = "lbl_12";
            lbl_12.Size = new Size(362, 15);
            lbl_12.TabIndex = 18;
            lbl_12.Text = "12-\tToma alguma medicação ou suplementação de vitamina, quais?";
            // 
            // rbt_sim12
            // 
            rbt_sim12.AutoSize = true;
            rbt_sim12.Location = new Point(402, 35);
            rbt_sim12.Name = "rbt_sim12";
            rbt_sim12.Size = new Size(45, 19);
            rbt_sim12.TabIndex = 24;
            rbt_sim12.TabStop = true;
            rbt_sim12.Text = "Sim";
            rbt_sim12.UseVisualStyleBackColor = true;
            rbt_sim12.CheckedChanged += rbt_simSuplementacao_CheckedChanged;
            // 
            // rbt_nao12
            // 
            rbt_nao12.AutoSize = true;
            rbt_nao12.Location = new Point(453, 35);
            rbt_nao12.Name = "rbt_nao12";
            rbt_nao12.Size = new Size(47, 19);
            rbt_nao12.TabIndex = 25;
            rbt_nao12.TabStop = true;
            rbt_nao12.Text = "Não";
            rbt_nao12.UseVisualStyleBackColor = true;
            rbt_nao12.CheckedChanged += rbt_naoSuplementacao_CheckedChanged;
            // 
            // rbt_sim13
            // 
            rbt_sim13.AutoSize = true;
            rbt_sim13.Location = new Point(516, 200);
            rbt_sim13.Name = "rbt_sim13";
            rbt_sim13.Size = new Size(45, 19);
            rbt_sim13.TabIndex = 26;
            rbt_sim13.TabStop = true;
            rbt_sim13.Text = "Sim";
            rbt_sim13.UseVisualStyleBackColor = true;
            rbt_sim13.CheckedChanged += rbt_simProblemaRespiracao_CheckedChanged;
            // 
            // rbt_nao13
            // 
            rbt_nao13.AutoSize = true;
            rbt_nao13.Location = new Point(567, 200);
            rbt_nao13.Name = "rbt_nao13";
            rbt_nao13.Size = new Size(47, 19);
            rbt_nao13.TabIndex = 27;
            rbt_nao13.TabStop = true;
            rbt_nao13.Text = "Não";
            rbt_nao13.UseVisualStyleBackColor = true;
            rbt_nao13.CheckedChanged += rbt_naoProblemaRespiracao_CheckedChanged;
            // 
            // frmP6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_nao13);
            Controls.Add(rbt_sim13);
            Controls.Add(rbt_nao12);
            Controls.Add(rbt_sim12);
            Controls.Add(txb_suplementacao);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txb_problemaRespiracao);
            Controls.Add(lbl_13);
            Controls.Add(lbl_12);
            Name = "frmP6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_suplementacao;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txb_problemaRespiracao;
        private Label lbl_13;
        private Label lbl_12;
        private RadioButton rbt_sim12;
        private RadioButton rbt_nao12;
        private RadioButton rbt_sim13;
        private RadioButton rbt_nao13;
        private FichaBebeTresMeses Ficha { get; set; }
        private SaudeDaCrianca SaudeDaCrianca { get; set; }
    }
}