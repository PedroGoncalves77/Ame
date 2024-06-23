using Ame.Modelo;

namespace Ame
{
    partial class frmP16
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
            rbt_40nao = new RadioButton();
            rbt_40sim = new RadioButton();
            txb_39 = new TextBox();
            bt_anterior = new Button();
            bt_proximo = new Button();
            txb_40a = new TextBox();
            lbl_40 = new Label();
            lbl_39 = new Label();
            lbl_40a = new Label();
            lbl_40b = new Label();
            rbt_40bNao = new RadioButton();
            rbt_40bSim = new RadioButton();
            SuspendLayout();
            // 
            // rbt_40nao
            // 
            rbt_40nao.AutoSize = true;
            rbt_40nao.Location = new Point(596, 171);
            rbt_40nao.Name = "rbt_40nao";
            rbt_40nao.Size = new Size(47, 19);
            rbt_40nao.TabIndex = 37;
            rbt_40nao.TabStop = true;
            rbt_40nao.Text = "Não";
            rbt_40nao.UseVisualStyleBackColor = true;
            rbt_40nao.CheckedChanged += rbt_40nao_CheckedChanged;
            // 
            // rbt_40sim
            // 
            rbt_40sim.AutoSize = true;
            rbt_40sim.Location = new Point(545, 171);
            rbt_40sim.Name = "rbt_40sim";
            rbt_40sim.Size = new Size(45, 19);
            rbt_40sim.TabIndex = 36;
            rbt_40sim.TabStop = true;
            rbt_40sim.Text = "Sim";
            rbt_40sim.UseVisualStyleBackColor = true;
            rbt_40sim.CheckedChanged += rbt_40sim_CheckedChanged;
            // 
            // txb_39
            // 
            txb_39.Enabled = true;
            txb_39.Location = new Point(34, 65);
            txb_39.Multiline = true;
            txb_39.Name = "txb_39";
            txb_39.Size = new Size(733, 91);
            txb_39.TabIndex = 33;
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(34, 392);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 32;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(653, 392);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 31;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // txb_40a
            // 
            txb_40a.Enabled = false;
            txb_40a.Location = new Point(34, 212);
            txb_40a.Multiline = true;
            txb_40a.Name = "txb_40a";
            txb_40a.Size = new Size(733, 94);
            txb_40a.TabIndex = 30;
            // 
            // lbl_40
            // 
            lbl_40.AutoSize = true;
            lbl_40.Location = new Point(34, 173);
            lbl_40.Name = "lbl_40";
            lbl_40.Size = new Size(508, 15);
            lbl_40.TabIndex = 29;
            lbl_40.Text = "40- Vocês tentaram melhorar o sono do seu filho tomando atitudes diferentes a cada dia/noite?";
            // 
            // lbl_39
            // 
            lbl_39.AutoSize = true;
            lbl_39.Location = new Point(34, 38);
            lbl_39.Name = "lbl_39";
            lbl_39.Size = new Size(377, 15);
            lbl_39.TabIndex = 28;
            lbl_39.Text = "39- Qual é o seu nível de estresse? Que horas se sente mais estressada?";
            // 
            // lbl_40a
            // 
            lbl_40a.AutoSize = true;
            lbl_40a.Location = new Point(34, 194);
            lbl_40a.Name = "lbl_40a";
            lbl_40a.Size = new Size(186, 15);
            lbl_40a.TabIndex = 38;
            lbl_40a.Text = "O que já fizeram como tentativas?";
            // 
            // lbl_40b
            // 
            lbl_40b.AutoSize = true;
            lbl_40b.Location = new Point(34, 316);
            lbl_40b.Name = "lbl_40b";
            lbl_40b.Size = new Size(430, 15);
            lbl_40b.TabIndex = 39;
            lbl_40b.Text = "Acham que podem ter colaborado sem perceber para algum problema de sono?";
            // 
            // rbt_40bNao
            // 
            rbt_40bNao.AutoSize = true;
            rbt_40bNao.Location = new Point(522, 316);
            rbt_40bNao.Name = "rbt_40bNao";
            rbt_40bNao.Size = new Size(47, 19);
            rbt_40bNao.TabIndex = 41;
            rbt_40bNao.TabStop = true;
            rbt_40bNao.Text = "Não";
            rbt_40bNao.UseVisualStyleBackColor = true;
            rbt_40bNao.CheckedChanged += rbt_40bNao_CheckedChanged;
            // 
            // rbt_40bSim
            // 
            rbt_40bSim.AutoSize = true;
            rbt_40bSim.Location = new Point(471, 316);
            rbt_40bSim.Name = "rbt_40bSim";
            rbt_40bSim.Size = new Size(45, 19);
            rbt_40bSim.TabIndex = 40;
            rbt_40bSim.TabStop = true;
            rbt_40bSim.Text = "Sim";
            rbt_40bSim.UseVisualStyleBackColor = true;
            rbt_40bSim.CheckedChanged += rbt_40bSim_CheckedChanged;
            // 
            // frmP16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_40bNao);
            Controls.Add(rbt_40bSim);
            Controls.Add(lbl_40b);
            Controls.Add(lbl_40a);
            Controls.Add(rbt_40nao);
            Controls.Add(rbt_40sim);
            Controls.Add(txb_39);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Controls.Add(txb_40a);
            Controls.Add(lbl_40);
            Controls.Add(lbl_39);
            Name = "frmP16";
            Text = "frmP16";
            Load += frmP16_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbt_40nao;
        private RadioButton rbt_40sim;
        private TextBox txb_39;
        private Button bt_anterior;
        private Button bt_proximo;
        private TextBox txb_40a;
        private Label lbl_40;
        private Label lbl_39;
        private Label lbl_40a;
        private Label lbl_40b;
        private RadioButton rbt_40bNao;
        private RadioButton rbt_40bSim;
        private FichaBebeTresMeses Ficha { get; set; }
        private SobrePais SobrePais { get; set; }
    }
}