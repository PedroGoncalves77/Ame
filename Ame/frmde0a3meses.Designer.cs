using Ame.Modelo;

namespace Ame
{
    partial class frmde0a3meses
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
            lbl_nomeMae = new Label();
            lbl_data = new Label();
            lbl_profissaoMae = new Label();
            lbl_pai = new Label();
            lbl_profissaoPai = new Label();
            lbl_endereco = new Label();
            txb_profissaoMae = new TextBox();
            txb_profissaoPai = new TextBox();
            txb_nomePai = new TextBox();
            txb_endereco = new TextBox();
            txb_nomeMae = new TextBox();
            label1 = new Label();
            lbl_NomeBebe = new Label();
            lbl_IdadeBebe = new Label();
            lbl_dataDeNascimentoBebe = new Label();
            lbl_pediatra = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txb_nomeCrianca = new TextBox();
            txb_idadeCrianca = new TextBox();
            txb_pediatra = new TextBox();
            bt_iniciarForm = new Button();
            mtc_Nascimento = new MonthCalendar();
            mtc_Data = new MonthCalendar();
            SuspendLayout();
            // 
            // lbl_nomeMae
            // 
            lbl_nomeMae.AutoSize = true;
            lbl_nomeMae.Location = new Point(4, 47);
            lbl_nomeMae.Name = "lbl_nomeMae";
            lbl_nomeMae.Size = new Size(85, 15);
            lbl_nomeMae.TabIndex = 0;
            lbl_nomeMae.Text = "Nome da mãe:";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Location = new Point(458, 9);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(34, 15);
            lbl_data.TabIndex = 1;
            lbl_data.Text = "Data:";
            // 
            // lbl_profissaoMae
            // 
            lbl_profissaoMae.AutoSize = true;
            lbl_profissaoMae.Location = new Point(25, 86);
            lbl_profissaoMae.Name = "lbl_profissaoMae";
            lbl_profissaoMae.Size = new Size(58, 15);
            lbl_profissaoMae.TabIndex = 2;
            lbl_profissaoMae.Text = "Profissão:";
            // 
            // lbl_pai
            // 
            lbl_pai.AutoSize = true;
            lbl_pai.Location = new Point(4, 128);
            lbl_pai.Name = "lbl_pai";
            lbl_pai.Size = new Size(79, 15);
            lbl_pai.TabIndex = 3;
            lbl_pai.Text = "Nome do pai:";
            // 
            // lbl_profissaoPai
            // 
            lbl_profissaoPai.AutoSize = true;
            lbl_profissaoPai.Location = new Point(30, 173);
            lbl_profissaoPai.Name = "lbl_profissaoPai";
            lbl_profissaoPai.Size = new Size(58, 15);
            lbl_profissaoPai.TabIndex = 4;
            lbl_profissaoPai.Text = "Profissão:";
            // 
            // lbl_endereco
            // 
            lbl_endereco.AutoSize = true;
            lbl_endereco.Location = new Point(30, 218);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(59, 15);
            lbl_endereco.TabIndex = 5;
            lbl_endereco.Text = "Endereço:";
            // 
            // txb_profissaoMae
            // 
            txb_profissaoMae.Location = new Point(95, 78);
            txb_profissaoMae.Name = "txb_profissaoMae";
            txb_profissaoMae.Size = new Size(397, 23);
            txb_profissaoMae.TabIndex = 7;
            // 
            // txb_profissaoPai
            // 
            txb_profissaoPai.Location = new Point(95, 165);
            txb_profissaoPai.Name = "txb_profissaoPai";
            txb_profissaoPai.Size = new Size(397, 23);
            txb_profissaoPai.TabIndex = 8;
            // 
            // txb_nomePai
            // 
            txb_nomePai.Location = new Point(95, 120);
            txb_nomePai.Name = "txb_nomePai";
            txb_nomePai.Size = new Size(397, 23);
            txb_nomePai.TabIndex = 9;
            // 
            // txb_endereco
            // 
            txb_endereco.Location = new Point(95, 210);
            txb_endereco.Name = "txb_endereco";
            txb_endereco.Size = new Size(397, 23);
            txb_endereco.TabIndex = 10;
            // 
            // txb_nomeMae
            // 
            txb_nomeMae.Location = new Point(95, 39);
            txb_nomeMae.Name = "txb_nomeMae";
            txb_nomeMae.Size = new Size(397, 23);
            txb_nomeMae.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 256);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 12;
            label1.Text = "DADOS DA CRIANÇA";
            // 
            // lbl_NomeBebe
            // 
            lbl_NomeBebe.AutoSize = true;
            lbl_NomeBebe.Location = new Point(40, 296);
            lbl_NomeBebe.Name = "lbl_NomeBebe";
            lbl_NomeBebe.Size = new Size(43, 15);
            lbl_NomeBebe.TabIndex = 13;
            lbl_NomeBebe.Text = "Nome:";
            // 
            // lbl_IdadeBebe
            // 
            lbl_IdadeBebe.AutoSize = true;
            lbl_IdadeBebe.Location = new Point(44, 327);
            lbl_IdadeBebe.Name = "lbl_IdadeBebe";
            lbl_IdadeBebe.Size = new Size(39, 15);
            lbl_IdadeBebe.TabIndex = 14;
            lbl_IdadeBebe.Text = "Idade:";
            // 
            // lbl_dataDeNascimentoBebe
            // 
            lbl_dataDeNascimentoBebe.AutoSize = true;
            lbl_dataDeNascimentoBebe.Location = new Point(377, 262);
            lbl_dataDeNascimentoBebe.Name = "lbl_dataDeNascimentoBebe";
            lbl_dataDeNascimentoBebe.Size = new Size(115, 15);
            lbl_dataDeNascimentoBebe.TabIndex = 15;
            lbl_dataDeNascimentoBebe.Text = "Data de nascimento:";
            // 
            // lbl_pediatra
            // 
            lbl_pediatra.AutoSize = true;
            lbl_pediatra.Location = new Point(30, 374);
            lbl_pediatra.Name = "lbl_pediatra";
            lbl_pediatra.Size = new Size(53, 15);
            lbl_pediatra.TabIndex = 16;
            lbl_pediatra.Text = "Pediatra:";
            // 
            // txb_nomeCrianca
            // 
            txb_nomeCrianca.Location = new Point(95, 288);
            txb_nomeCrianca.Name = "txb_nomeCrianca";
            txb_nomeCrianca.Size = new Size(397, 23);
            txb_nomeCrianca.TabIndex = 18;
            // 
            // txb_idadeCrianca
            // 
            txb_idadeCrianca.Location = new Point(95, 327);
            txb_idadeCrianca.Name = "txb_idadeCrianca";
            txb_idadeCrianca.Size = new Size(40, 23);
            txb_idadeCrianca.TabIndex = 19;
            // 
            // txb_pediatra
            // 
            txb_pediatra.Location = new Point(95, 366);
            txb_pediatra.Name = "txb_pediatra";
            txb_pediatra.Size = new Size(397, 23);
            txb_pediatra.TabIndex = 20;
            // 
            // bt_iniciarForm
            // 
            bt_iniciarForm.Enabled = false;
            bt_iniciarForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_iniciarForm.Location = new Point(306, 395);
            bt_iniciarForm.Name = "bt_iniciarForm";
            bt_iniciarForm.Size = new Size(170, 23);
            bt_iniciarForm.TabIndex = 21;
            bt_iniciarForm.Text = "Iniciar formulário";
            bt_iniciarForm.UseVisualStyleBackColor = true;
            bt_iniciarForm.Click += bt_iniciarForm_Click;
            // 
            // mtc_Nascimento
            // 
            mtc_Nascimento.Location = new Point(504, 256);
            mtc_Nascimento.Name = "mtc_Nascimento";
            mtc_Nascimento.TabIndex = 22;
            mtc_Nascimento.DateChanged += mtc_Nascimento_DateChanged;
            // 
            // mtc_Data
            // 
            mtc_Data.Location = new Point(504, 9);
            mtc_Data.Name = "mtc_Data";
            mtc_Data.TabIndex = 23;
            // frmde0a3meses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtc_Data);
            Controls.Add(mtc_Nascimento);
            Controls.Add(bt_iniciarForm);
            Controls.Add(txb_pediatra);
            Controls.Add(txb_idadeCrianca);
            Controls.Add(txb_nomeCrianca);
            Controls.Add(lbl_pediatra);
            Controls.Add(lbl_dataDeNascimentoBebe);
            Controls.Add(lbl_IdadeBebe);
            Controls.Add(lbl_NomeBebe);
            Controls.Add(label1);
            Controls.Add(txb_nomeMae);
            Controls.Add(txb_endereco);
            Controls.Add(txb_nomePai);
            Controls.Add(txb_profissaoPai);
            Controls.Add(txb_profissaoMae);
            Controls.Add(lbl_endereco);
            Controls.Add(lbl_profissaoPai);
            Controls.Add(lbl_pai);
            Controls.Add(lbl_profissaoMae);
            Controls.Add(lbl_data);
            Controls.Add(lbl_nomeMae);
            Name = "frmde0a3meses";
            Text = "Questionário para bebê de 0 a 3 meses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nomeMae;
        private Label lbl_data;
        private Label lbl_profissaoMae;
        private Label lbl_pai;
        private Label lbl_profissaoPai;
        private Label lbl_endereco;
        private TextBox txb_profissaoMae;
        private TextBox txb_profissaoPai;
        private TextBox txb_nomePai;
        private TextBox txb_endereco;
        private TextBox txb_nomeMae;
        private Label label1;
        private Label lbl_NomeBebe;
        private Label lbl_IdadeBebe;
        private Label lbl_dataDeNascimentoBebe;
        private Label lbl_pediatra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txb_nomeCrianca;
        private TextBox txb_idadeCrianca;
        private TextBox txb_pediatra;
        private Button bt_iniciarForm;
        private MonthCalendar mtc_Nascimento;
        private MonthCalendar mtc_Data;
        private FichaBebeTresMeses Ficha { get; set; }
    }
}