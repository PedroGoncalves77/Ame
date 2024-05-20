namespace Ame
{
    partial class frm_zeroaTresMeses
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
            txb_data = new TextBox();
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
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            bt_iniciarForm = new Button();
            SuspendLayout();
            // 
            // lbl_nomeMae
            // 
            lbl_nomeMae.AutoSize = true;
            lbl_nomeMae.Location = new Point(39, 94);
            lbl_nomeMae.Name = "lbl_nomeMae";
            lbl_nomeMae.Size = new Size(85, 15);
            lbl_nomeMae.TabIndex = 0;
            lbl_nomeMae.Text = "Nome da mãe:";
            lbl_nomeMae.Click += lbl_nomeMae_Click;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Location = new Point(39, 50);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(34, 15);
            lbl_data.TabIndex = 1;
            lbl_data.Text = "Data:";
            // 
            // lbl_profissaoMae
            // 
            lbl_profissaoMae.AutoSize = true;
            lbl_profissaoMae.Location = new Point(351, 94);
            lbl_profissaoMae.Name = "lbl_profissaoMae";
            lbl_profissaoMae.Size = new Size(58, 15);
            lbl_profissaoMae.TabIndex = 2;
            lbl_profissaoMae.Text = "Profissão:";
            lbl_profissaoMae.Click += lbl_profissaoMae_Click;
            // 
            // lbl_pai
            // 
            lbl_pai.AutoSize = true;
            lbl_pai.Location = new Point(39, 138);
            lbl_pai.Name = "lbl_pai";
            lbl_pai.Size = new Size(79, 15);
            lbl_pai.TabIndex = 3;
            lbl_pai.Text = "Nome do pai:";
            // 
            // lbl_profissaoPai
            // 
            lbl_profissaoPai.AutoSize = true;
            lbl_profissaoPai.Location = new Point(351, 138);
            lbl_profissaoPai.Name = "lbl_profissaoPai";
            lbl_profissaoPai.Size = new Size(58, 15);
            lbl_profissaoPai.TabIndex = 4;
            lbl_profissaoPai.Text = "Profissão:";
            lbl_profissaoPai.Click += label5_Click;
            // 
            // lbl_endereco
            // 
            lbl_endereco.AutoSize = true;
            lbl_endereco.Location = new Point(39, 179);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(59, 15);
            lbl_endereco.TabIndex = 5;
            lbl_endereco.Text = "Endereço:";
            // 
            // txb_data
            // 
            txb_data.Location = new Point(79, 42);
            txb_data.Name = "txb_data";
            txb_data.Size = new Size(100, 23);
            txb_data.TabIndex = 6;
            // 
            // txb_profissaoMae
            // 
            txb_profissaoMae.Location = new Point(415, 91);
            txb_profissaoMae.Name = "txb_profissaoMae";
            txb_profissaoMae.Size = new Size(183, 23);
            txb_profissaoMae.TabIndex = 7;
            txb_profissaoMae.TextChanged += txb_profissaoMae_TextChanged;
            // 
            // txb_profissaoPai
            // 
            txb_profissaoPai.Location = new Point(409, 135);
            txb_profissaoPai.Name = "txb_profissaoPai";
            txb_profissaoPai.Size = new Size(189, 23);
            txb_profissaoPai.TabIndex = 8;
            // 
            // txb_nomePai
            // 
            txb_nomePai.Location = new Point(124, 135);
            txb_nomePai.Name = "txb_nomePai";
            txb_nomePai.Size = new Size(221, 23);
            txb_nomePai.TabIndex = 9;
            // 
            // txb_endereco
            // 
            txb_endereco.Location = new Point(104, 176);
            txb_endereco.Name = "txb_endereco";
            txb_endereco.Size = new Size(388, 23);
            txb_endereco.TabIndex = 10;
            // 
            // txb_nomeMae
            // 
            txb_nomeMae.Location = new Point(124, 91);
            txb_nomeMae.Name = "txb_nomeMae";
            txb_nomeMae.Size = new Size(221, 23);
            txb_nomeMae.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 222);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 12;
            label1.Text = "DADOS DA CRIANÇA";
            label1.Click += label1_Click;
            // 
            // lbl_NomeBebe
            // 
            lbl_NomeBebe.AutoSize = true;
            lbl_NomeBebe.Location = new Point(39, 260);
            lbl_NomeBebe.Name = "lbl_NomeBebe";
            lbl_NomeBebe.Size = new Size(43, 15);
            lbl_NomeBebe.TabIndex = 13;
            lbl_NomeBebe.Text = "Nome:";
            // 
            // lbl_IdadeBebe
            // 
            lbl_IdadeBebe.AutoSize = true;
            lbl_IdadeBebe.Location = new Point(39, 297);
            lbl_IdadeBebe.Name = "lbl_IdadeBebe";
            lbl_IdadeBebe.Size = new Size(39, 15);
            lbl_IdadeBebe.TabIndex = 14;
            lbl_IdadeBebe.Text = "Idade:";
            // 
            // lbl_dataDeNascimentoBebe
            // 
            lbl_dataDeNascimentoBebe.AutoSize = true;
            lbl_dataDeNascimentoBebe.Location = new Point(144, 296);
            lbl_dataDeNascimentoBebe.Name = "lbl_dataDeNascimentoBebe";
            lbl_dataDeNascimentoBebe.Size = new Size(115, 15);
            lbl_dataDeNascimentoBebe.TabIndex = 15;
            lbl_dataDeNascimentoBebe.Text = "Data de nascimento:";
            lbl_dataDeNascimentoBebe.Click += lbl_dataDeNascimentoBebe_Click;
            // 
            // lbl_pediatra
            // 
            lbl_pediatra.AutoSize = true;
            lbl_pediatra.Location = new Point(39, 330);
            lbl_pediatra.Name = "lbl_pediatra";
            lbl_pediatra.Size = new Size(53, 15);
            lbl_pediatra.TabIndex = 16;
            lbl_pediatra.Text = "Pediatra:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(348, 23);
            textBox4.TabIndex = 20;
            // 
            // bt_iniciarForm
            // 
            bt_iniciarForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_iniciarForm.Location = new Point(306, 395);
            bt_iniciarForm.Name = "bt_iniciarForm";
            bt_iniciarForm.Size = new Size(170, 23);
            bt_iniciarForm.TabIndex = 21;
            bt_iniciarForm.Text = "Iniciar formulário";
            bt_iniciarForm.UseVisualStyleBackColor = true;
            bt_iniciarForm.Click += bt_iniciarForm_Click;
            // 
            // frm_zeroaTresMeses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_iniciarForm);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Controls.Add(txb_data);
            Controls.Add(lbl_endereco);
            Controls.Add(lbl_profissaoPai);
            Controls.Add(lbl_pai);
            Controls.Add(lbl_profissaoMae);
            Controls.Add(lbl_data);
            Controls.Add(lbl_nomeMae);
            Name = "frm_zeroaTresMeses";
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
        private TextBox txb_data;
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
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button bt_iniciarForm;
    }
}