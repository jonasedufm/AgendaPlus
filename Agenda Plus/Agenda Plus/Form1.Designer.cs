namespace Agenda_Plus
{
    partial class FormMain
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Cnpj_lbl = new System.Windows.Forms.Label();
            this.ende_lbl = new System.Windows.Forms.Label();
            this.inscEst_lbl = new System.Windows.Forms.Label();
            this.city_lbl = new System.Windows.Forms.Label();
            this.cep_lbl = new System.Windows.Forms.Label();
            this.numb_lbl = new System.Windows.Forms.Label();
            this.bairro_lbl = new System.Windows.Forms.Label();
            this.tele1_lbl = new System.Windows.Forms.Label();
            this.tele2_lbl = new System.Windows.Forms.Label();
            this.cont_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.Box_CNPJ = new System.Windows.Forms.TextBox();
            this.Box_Rua = new System.Windows.Forms.TextBox();
            this.Box_Cep = new System.Windows.Forms.TextBox();
            this.Box_Cidade = new System.Windows.Forms.TextBox();
            this.Box_InscriEst = new System.Windows.Forms.TextBox();
            this.Box_Num = new System.Windows.Forms.TextBox();
            this.Box_Bairro = new System.Windows.Forms.TextBox();
            this.Box_Contato = new System.Windows.Forms.TextBox();
            this.Box_Tele1 = new System.Windows.Forms.TextBox();
            this.Box_Tele2 = new System.Windows.Forms.TextBox();
            this.Box_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(416, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 55);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Editar Contato";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(804, 340);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 56);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remover Contato";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lime;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(25, 339);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 56);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Cadastrar Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 325);
            this.dataGridView1.TabIndex = 8;
            // 
            // Box_Name
            // 
            this.Box_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Name.Location = new System.Drawing.Point(25, 149);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(351, 28);
            this.Box_Name.TabIndex = 9;
            this.Box_Name.TextChanged += new System.EventHandler(this.Box_Name_TextChanged);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Name_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(21, 120);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(121, 22);
            this.Name_lbl.TabIndex = 10;
            this.Name_lbl.Text = "Fornecedor:";
            // 
            // Cnpj_lbl
            // 
            this.Cnpj_lbl.AutoSize = true;
            this.Cnpj_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Cnpj_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnpj_lbl.Location = new System.Drawing.Point(391, 120);
            this.Cnpj_lbl.Name = "Cnpj_lbl";
            this.Cnpj_lbl.Size = new System.Drawing.Size(64, 22);
            this.Cnpj_lbl.TabIndex = 11;
            this.Cnpj_lbl.Text = "CNPJ:";
            // 
            // ende_lbl
            // 
            this.ende_lbl.AutoSize = true;
            this.ende_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ende_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ende_lbl.Location = new System.Drawing.Point(21, 196);
            this.ende_lbl.Name = "ende_lbl";
            this.ende_lbl.Size = new System.Drawing.Size(104, 22);
            this.ende_lbl.TabIndex = 12;
            this.ende_lbl.Text = "Endereço:";
            // 
            // inscEst_lbl
            // 
            this.inscEst_lbl.AutoSize = true;
            this.inscEst_lbl.BackColor = System.Drawing.Color.Transparent;
            this.inscEst_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscEst_lbl.Location = new System.Drawing.Point(737, 120);
            this.inscEst_lbl.Name = "inscEst_lbl";
            this.inscEst_lbl.Size = new System.Drawing.Size(180, 22);
            this.inscEst_lbl.TabIndex = 13;
            this.inscEst_lbl.Text = "Inscrição Estadual:";
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.BackColor = System.Drawing.Color.Transparent;
            this.city_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.Location = new System.Drawing.Point(737, 196);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(154, 22);
            this.city_lbl.TabIndex = 14;
            this.city_lbl.Text = "Cidade/Estado:";
            this.city_lbl.Click += new System.EventHandler(this.city_lbl_Click);
            // 
            // cep_lbl
            // 
            this.cep_lbl.AutoSize = true;
            this.cep_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cep_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep_lbl.Location = new System.Drawing.Point(391, 192);
            this.cep_lbl.Name = "cep_lbl";
            this.cep_lbl.Size = new System.Drawing.Size(51, 22);
            this.cep_lbl.TabIndex = 16;
            this.cep_lbl.Text = "CEP:";
            this.cep_lbl.Click += new System.EventHandler(this.cep_lbl_Click);
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.BackColor = System.Drawing.Color.Transparent;
            this.numb_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb_lbl.Location = new System.Drawing.Point(302, 196);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(36, 22);
            this.numb_lbl.TabIndex = 17;
            this.numb_lbl.Text = "Nº:";
            this.numb_lbl.Click += new System.EventHandler(this.numb_lbl_Click);
            // 
            // bairro_lbl
            // 
            this.bairro_lbl.AutoSize = true;
            this.bairro_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bairro_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_lbl.Location = new System.Drawing.Point(548, 192);
            this.bairro_lbl.Name = "bairro_lbl";
            this.bairro_lbl.Size = new System.Drawing.Size(66, 22);
            this.bairro_lbl.TabIndex = 18;
            this.bairro_lbl.Text = "Bairro:";
            // 
            // tele1_lbl
            // 
            this.tele1_lbl.AutoSize = true;
            this.tele1_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tele1_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele1_lbl.Location = new System.Drawing.Point(532, 267);
            this.tele1_lbl.Name = "tele1_lbl";
            this.tele1_lbl.Size = new System.Drawing.Size(108, 22);
            this.tele1_lbl.TabIndex = 19;
            this.tele1_lbl.Text = "Telefone 1:";
            // 
            // tele2_lbl
            // 
            this.tele2_lbl.AutoSize = true;
            this.tele2_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tele2_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele2_lbl.Location = new System.Drawing.Point(741, 266);
            this.tele2_lbl.Name = "tele2_lbl";
            this.tele2_lbl.Size = new System.Drawing.Size(108, 22);
            this.tele2_lbl.TabIndex = 20;
            this.tele2_lbl.Text = "Telefone 2:";
            // 
            // cont_lbl
            // 
            this.cont_lbl.AutoSize = true;
            this.cont_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cont_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_lbl.Location = new System.Drawing.Point(21, 266);
            this.cont_lbl.Name = "cont_lbl";
            this.cont_lbl.Size = new System.Drawing.Size(93, 22);
            this.cont_lbl.TabIndex = 21;
            this.cont_lbl.Text = "Contato:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.Transparent;
            this.email_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(253, 267);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(67, 22);
            this.email_lbl.TabIndex = 22;
            this.email_lbl.Text = "E-mail:";
            // 
            // Box_CNPJ
            // 
            this.Box_CNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_CNPJ.Location = new System.Drawing.Point(395, 149);
            this.Box_CNPJ.Name = "Box_CNPJ";
            this.Box_CNPJ.Size = new System.Drawing.Size(320, 28);
            this.Box_CNPJ.TabIndex = 23;
            // 
            // Box_Rua
            // 
            this.Box_Rua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Rua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Rua.Location = new System.Drawing.Point(25, 220);
            this.Box_Rua.Name = "Box_Rua";
            this.Box_Rua.Size = new System.Drawing.Size(255, 28);
            this.Box_Rua.TabIndex = 24;
            // 
            // Box_Cep
            // 
            this.Box_Cep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Cep.Location = new System.Drawing.Point(395, 220);
            this.Box_Cep.Name = "Box_Cep";
            this.Box_Cep.Size = new System.Drawing.Size(136, 28);
            this.Box_Cep.TabIndex = 25;
            this.Box_Cep.TextChanged += new System.EventHandler(this.Box_Cep_TextChanged);
            // 
            // Box_Cidade
            // 
            this.Box_Cidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Cidade.Location = new System.Drawing.Point(741, 220);
            this.Box_Cidade.Name = "Box_Cidade";
            this.Box_Cidade.Size = new System.Drawing.Size(243, 28);
            this.Box_Cidade.TabIndex = 26;
            this.Box_Cidade.TextChanged += new System.EventHandler(this.Box_Cidade_TextChanged);
            // 
            // Box_InscriEst
            // 
            this.Box_InscriEst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_InscriEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_InscriEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_InscriEst.Location = new System.Drawing.Point(741, 149);
            this.Box_InscriEst.Name = "Box_InscriEst";
            this.Box_InscriEst.Size = new System.Drawing.Size(243, 28);
            this.Box_InscriEst.TabIndex = 32768;
            // 
            // Box_Num
            // 
            this.Box_Num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Num.Location = new System.Drawing.Point(306, 220);
            this.Box_Num.Name = "Box_Num";
            this.Box_Num.Size = new System.Drawing.Size(66, 28);
            this.Box_Num.TabIndex = 32769;
            this.Box_Num.TextChanged += new System.EventHandler(this.Box_Num_TextChanged);
            // 
            // Box_Bairro
            // 
            this.Box_Bairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Bairro.Location = new System.Drawing.Point(552, 220);
            this.Box_Bairro.Name = "Box_Bairro";
            this.Box_Bairro.Size = new System.Drawing.Size(163, 28);
            this.Box_Bairro.TabIndex = 32770;
            // 
            // Box_Contato
            // 
            this.Box_Contato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Contato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Contato.Location = new System.Drawing.Point(25, 294);
            this.Box_Contato.Name = "Box_Contato";
            this.Box_Contato.Size = new System.Drawing.Size(201, 28);
            this.Box_Contato.TabIndex = 32771;
            // 
            // Box_Tele1
            // 
            this.Box_Tele1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Tele1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Tele1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Tele1.Location = new System.Drawing.Point(536, 294);
            this.Box_Tele1.Name = "Box_Tele1";
            this.Box_Tele1.Size = new System.Drawing.Size(183, 28);
            this.Box_Tele1.TabIndex = 32772;
            // 
            // Box_Tele2
            // 
            this.Box_Tele2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Tele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Tele2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Tele2.Location = new System.Drawing.Point(745, 293);
            this.Box_Tele2.Name = "Box_Tele2";
            this.Box_Tele2.Size = new System.Drawing.Size(239, 28);
            this.Box_Tele2.TabIndex = 32773;
            // 
            // Box_Email
            // 
            this.Box_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Email.Location = new System.Drawing.Point(257, 294);
            this.Box_Email.Name = "Box_Email";
            this.Box_Email.Size = new System.Drawing.Size(255, 28);
            this.Box_Email.TabIndex = 32774;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 32775;
            this.label1.Text = "Made by JEFM - 2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 32776;
            this.label2.Text = "All rights reserved";
            // 
            // btn_About
            // 
            this.btn_About.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.btn_About.Location = new System.Drawing.Point(901, 733);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(96, 28);
            this.btn_About.TabIndex = 32777;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agenda_Plus.Properties.Resources.BackgroundAP;
            this.ClientSize = new System.Drawing.Size(1009, 765);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box_Email);
            this.Controls.Add(this.Box_Tele2);
            this.Controls.Add(this.Box_Tele1);
            this.Controls.Add(this.Box_Contato);
            this.Controls.Add(this.Box_Bairro);
            this.Controls.Add(this.Box_Num);
            this.Controls.Add(this.Box_InscriEst);
            this.Controls.Add(this.Box_Cidade);
            this.Controls.Add(this.Box_Cep);
            this.Controls.Add(this.Box_Rua);
            this.Controls.Add(this.Box_CNPJ);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.cont_lbl);
            this.Controls.Add(this.tele2_lbl);
            this.Controls.Add(this.tele1_lbl);
            this.Controls.Add(this.bairro_lbl);
            this.Controls.Add(this.numb_lbl);
            this.Controls.Add(this.cep_lbl);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.inscEst_lbl);
            this.Controls.Add(this.ende_lbl);
            this.Controls.Add(this.Cnpj_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Plus - Ver. 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Cnpj_lbl;
        private System.Windows.Forms.Label ende_lbl;
        private System.Windows.Forms.Label inscEst_lbl;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Label cep_lbl;
        private System.Windows.Forms.Label numb_lbl;
        private System.Windows.Forms.Label bairro_lbl;
        private System.Windows.Forms.Label tele1_lbl;
        private System.Windows.Forms.Label tele2_lbl;
        private System.Windows.Forms.Label cont_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox Box_CNPJ;
        private System.Windows.Forms.TextBox Box_Rua;
        private System.Windows.Forms.TextBox Box_Cep;
        private System.Windows.Forms.TextBox Box_Cidade;
        private System.Windows.Forms.TextBox Box_InscriEst;
        private System.Windows.Forms.TextBox Box_Num;
        private System.Windows.Forms.TextBox Box_Bairro;
        private System.Windows.Forms.TextBox Box_Contato;
        private System.Windows.Forms.TextBox Box_Tele1;
        private System.Windows.Forms.TextBox Box_Tele2;
        private System.Windows.Forms.TextBox Box_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_About;
    }
}

