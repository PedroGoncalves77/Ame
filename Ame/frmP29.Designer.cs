﻿using Ame.Modelo;

namespace Ame
{
    partial class frmP29
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
            rbt_nao82 = new RadioButton();
            rbt_sim82 = new RadioButton();
            lbl_82 = new Label();
            txt_80 = new TextBox();
            lbl_74 = new Label();
            bt_anterior = new Button();
            bt_proximo = new Button();
            lbl_69a = new Label();
            rbt_nao81 = new RadioButton();
            rbt_sim81 = new RadioButton();
            txt_81 = new TextBox();
            lbl_69 = new Label();
            SuspendLayout();
            // 
            // rbt_nao82
            // 
            rbt_nao82.AutoSize = true;
            rbt_nao82.Location = new Point(71, 325);
            rbt_nao82.Name = "rbt_nao82";
            rbt_nao82.Size = new Size(47, 19);
            rbt_nao82.TabIndex = 213;
            rbt_nao82.TabStop = true;
            rbt_nao82.Text = "Não";
            rbt_nao82.UseVisualStyleBackColor = true;
            rbt_nao82.CheckedChanged += rbt_nao82_CheckedChanged;
            // 
            // rbt_sim82
            // 
            rbt_sim82.AutoSize = true;
            rbt_sim82.Location = new Point(24, 325);
            rbt_sim82.Name = "rbt_sim82";
            rbt_sim82.Size = new Size(45, 19);
            rbt_sim82.TabIndex = 212;
            rbt_sim82.TabStop = true;
            rbt_sim82.Text = "Sim";
            rbt_sim82.UseVisualStyleBackColor = true;
            rbt_sim82.CheckedChanged += rbt_sim82_CheckedChanged;
            // 
            // lbl_82
            // 
            lbl_82.AutoSize = true;
            lbl_82.Location = new Point(23, 307);
            lbl_82.Name = "lbl_82";
            lbl_82.Size = new Size(492, 15);
            lbl_82.TabIndex = 211;
            lbl_82.Text = "82- Seu filho (a) gosta do quarto, berço? Os pais brincam com o bebê no ambiente de sono?";
            // 
            // txt_80
            // 
            txt_80.Location = new Point(23, 44);
            txt_80.Multiline = true;
            txt_80.Name = "txt_80";
            txt_80.Size = new Size(755, 94);
            txt_80.TabIndex = 194;
            // 
            // lbl_74
            // 
            lbl_74.Location = new Point(23, 13);
            lbl_74.Name = "lbl_74";
            lbl_74.Size = new Size(755, 39);
            lbl_74.TabIndex = 193;
            lbl_74.Text = "80- Descreva o ambiente onde ele dorme. Tem muitos brinquedos no quarto? Prateleiras com brinquedos? Você acredita que isso o atrapalhe a dormir?";
            // 
            // bt_anterior
            // 
            bt_anterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_anterior.Location = new Point(23, 415);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(114, 23);
            bt_anterior.TabIndex = 192;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            bt_anterior.Click += bt_anterior_Click;
            // 
            // bt_proximo
            // 
            bt_proximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_proximo.Location = new Point(664, 415);
            bt_proximo.Name = "bt_proximo";
            bt_proximo.Size = new Size(114, 23);
            bt_proximo.TabIndex = 191;
            bt_proximo.Text = "Próximo";
            bt_proximo.UseVisualStyleBackColor = true;
            bt_proximo.Click += bt_proximo_Click;
            // 
            // lbl_69a
            // 
            lbl_69a.AutoSize = true;
            lbl_69a.Location = new Point(23, 189);
            lbl_69a.Name = "lbl_69a";
            lbl_69a.Size = new Size(57, 15);
            lbl_69a.TabIndex = 219;
            lbl_69a.Text = "Descreva:";
            // 
            // rbt_nao81
            // 
            rbt_nao81.AutoSize = true;
            rbt_nao81.Location = new Point(80, 167);
            rbt_nao81.Name = "rbt_nao81";
            rbt_nao81.Size = new Size(47, 19);
            rbt_nao81.TabIndex = 218;
            rbt_nao81.TabStop = true;
            rbt_nao81.Text = "Não";
            rbt_nao81.UseVisualStyleBackColor = true;
            rbt_nao81.CheckedChanged += rbt_nao81_CheckedChanged;
            // 
            // rbt_sim81
            // 
            rbt_sim81.AutoSize = true;
            rbt_sim81.Location = new Point(29, 167);
            rbt_sim81.Name = "rbt_sim81";
            rbt_sim81.Size = new Size(45, 19);
            rbt_sim81.TabIndex = 217;
            rbt_sim81.TabStop = true;
            rbt_sim81.Text = "Sim";
            rbt_sim81.UseVisualStyleBackColor = true;
            rbt_sim81.CheckedChanged += rbt_sim81_CheckedChanged;
            // 
            // txt_81
            // 
            txt_81.Enabled = false;
            txt_81.Location = new Point(22, 217);
            txt_81.Multiline = true;
            txt_81.Name = "txt_81";
            txt_81.Size = new Size(755, 87);
            txt_81.TabIndex = 216;
            // 
            // lbl_69
            // 
            lbl_69.Location = new Point(23, 154);
            lbl_69.Name = "lbl_69";
            lbl_69.Size = new Size(754, 35);
            lbl_69.TabIndex = 215;
            lbl_69.Text = "81- Tem alguma luz de abajur, babá eletrônica, som, aquecedor, etc que fica acesa durante a noite deixando o ambiente mais claro?";
            // 
            // frmP29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_69a);
            Controls.Add(rbt_nao81);
            Controls.Add(rbt_sim81);
            Controls.Add(txt_81);
            Controls.Add(lbl_69);
            Controls.Add(rbt_nao82);
            Controls.Add(rbt_sim82);
            Controls.Add(lbl_82);
            Controls.Add(txt_80);
            Controls.Add(lbl_74);
            Controls.Add(bt_anterior);
            Controls.Add(bt_proximo);
            Name = "frmP29";
            Text = "frmP29";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbt_ambos79;
        private RadioButton rbt_noite79;
        private RadioButton rbt_dia79;
        private Label lbl_82;
        private TextBox txt_80;
        private Label lbl_74;
        private Button bt_anterior;
        private Button bt_proximo;
        private Label lbl_69a;
        private RadioButton rbt_nao81;
        private RadioButton rbt_sim81;
        private TextBox txt_81;
        private Label lbl_69;
        private RadioButton rbt_nao82;
        private RadioButton rbt_sim82;
        private FichaBebeTresMeses Ficha { get; set; }
        private AmbienteSono AmbienteSono { get; set; }
    }
}