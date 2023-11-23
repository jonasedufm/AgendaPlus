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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.estate_lbl = new System.Windows.Forms.Label();
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
            this.Box_Estado = new System.Windows.Forms.TextBox();
            this.Box_InscriEst = new System.Windows.Forms.TextBox();
            this.Box_Num = new System.Windows.Forms.TextBox();
            this.Box_Bairro = new System.Windows.Forms.TextBox();
            this.Box_Contato = new System.Windows.Forms.TextBox();
            this.Box_Tele1 = new System.Windows.Forms.TextBox();
            this.Box_Tele2 = new System.Windows.Forms.TextBox();
            this.Box_Email = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.title_lbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 145);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(164, 67);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(649, 45);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Agenda Plus - Seja Bem Vindo(a)!";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Agenda_Plus.Properties.Resources.AP_Semfundo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(768, 244);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 55);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Editar Contato";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(768, 372);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 56);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remover Contato";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Green;
            this.btnNew.Location = new System.Drawing.Point(768, 134);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(180, 56);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Cadastrar Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 307);
            this.dataGridView1.TabIndex = 8;
            // 
            // Box_Name
            // 
            this.Box_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Name.Location = new System.Drawing.Point(25, 149);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(406, 28);
            this.Box_Name.TabIndex = 9;
            this.Box_Name.TextChanged += new System.EventHandler(this.Box_Name_TextChanged);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
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
            this.Cnpj_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnpj_lbl.Location = new System.Drawing.Point(451, 120);
            this.Cnpj_lbl.Name = "Cnpj_lbl";
            this.Cnpj_lbl.Size = new System.Drawing.Size(64, 22);
            this.Cnpj_lbl.TabIndex = 11;
            this.Cnpj_lbl.Text = "CNPJ:";
            // 
            // ende_lbl
            // 
            this.ende_lbl.AutoSize = true;
            this.ende_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ende_lbl.Location = new System.Drawing.Point(294, 183);
            this.ende_lbl.Name = "ende_lbl";
            this.ende_lbl.Size = new System.Drawing.Size(104, 22);
            this.ende_lbl.TabIndex = 12;
            this.ende_lbl.Text = "Endereço:";
            // 
            // inscEst_lbl
            // 
            this.inscEst_lbl.AutoSize = true;
            this.inscEst_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscEst_lbl.Location = new System.Drawing.Point(21, 183);
            this.inscEst_lbl.Name = "inscEst_lbl";
            this.inscEst_lbl.Size = new System.Drawing.Size(180, 22);
            this.inscEst_lbl.TabIndex = 13;
            this.inscEst_lbl.Text = "Inscrição Estadual:";
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.Location = new System.Drawing.Point(294, 244);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(84, 22);
            this.city_lbl.TabIndex = 14;
            this.city_lbl.Text = "Cidade:";
            this.city_lbl.Click += new System.EventHandler(this.city_lbl_Click);
            // 
            // estate_lbl
            // 
            this.estate_lbl.AutoSize = true;
            this.estate_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estate_lbl.Location = new System.Drawing.Point(501, 245);
            this.estate_lbl.Name = "estate_lbl";
            this.estate_lbl.Size = new System.Drawing.Size(77, 22);
            this.estate_lbl.TabIndex = 15;
            this.estate_lbl.Text = "Estado:";
            // 
            // cep_lbl
            // 
            this.cep_lbl.AutoSize = true;
            this.cep_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep_lbl.Location = new System.Drawing.Point(570, 183);
            this.cep_lbl.Name = "cep_lbl";
            this.cep_lbl.Size = new System.Drawing.Size(51, 22);
            this.cep_lbl.TabIndex = 16;
            this.cep_lbl.Text = "CEP:";
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb_lbl.Location = new System.Drawing.Point(210, 246);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(36, 22);
            this.numb_lbl.TabIndex = 17;
            this.numb_lbl.Text = "Nº:";
            this.numb_lbl.Click += new System.EventHandler(this.numb_lbl_Click);
            // 
            // bairro_lbl
            // 
            this.bairro_lbl.AutoSize = true;
            this.bairro_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_lbl.Location = new System.Drawing.Point(23, 244);
            this.bairro_lbl.Name = "bairro_lbl";
            this.bairro_lbl.Size = new System.Drawing.Size(66, 22);
            this.bairro_lbl.TabIndex = 18;
            this.bairro_lbl.Text = "Bairro:";
            // 
            // tele1_lbl
            // 
            this.tele1_lbl.AutoSize = true;
            this.tele1_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele1_lbl.Location = new System.Drawing.Point(21, 375);
            this.tele1_lbl.Name = "tele1_lbl";
            this.tele1_lbl.Size = new System.Drawing.Size(108, 22);
            this.tele1_lbl.TabIndex = 19;
            this.tele1_lbl.Text = "Telefone 1:";
            // 
            // tele2_lbl
            // 
            this.tele2_lbl.AutoSize = true;
            this.tele2_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele2_lbl.Location = new System.Drawing.Point(260, 375);
            this.tele2_lbl.Name = "tele2_lbl";
            this.tele2_lbl.Size = new System.Drawing.Size(108, 22);
            this.tele2_lbl.TabIndex = 20;
            this.tele2_lbl.Text = "Telefone 2:";
            // 
            // cont_lbl
            // 
            this.cont_lbl.AutoSize = true;
            this.cont_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_lbl.Location = new System.Drawing.Point(23, 312);
            this.cont_lbl.Name = "cont_lbl";
            this.cont_lbl.Size = new System.Drawing.Size(93, 22);
            this.cont_lbl.TabIndex = 21;
            this.cont_lbl.Text = "Contato:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(260, 311);
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
            this.Box_CNPJ.Location = new System.Drawing.Point(455, 148);
            this.Box_CNPJ.Name = "Box_CNPJ";
            this.Box_CNPJ.Size = new System.Drawing.Size(255, 28);
            this.Box_CNPJ.TabIndex = 23;
            // 
            // Box_Rua
            // 
            this.Box_Rua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Rua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Rua.Location = new System.Drawing.Point(298, 211);
            this.Box_Rua.Name = "Box_Rua";
            this.Box_Rua.Size = new System.Drawing.Size(255, 28);
            this.Box_Rua.TabIndex = 24;
            // 
            // Box_Cep
            // 
            this.Box_Cep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Cep.Location = new System.Drawing.Point(574, 211);
            this.Box_Cep.Name = "Box_Cep";
            this.Box_Cep.Size = new System.Drawing.Size(136, 28);
            this.Box_Cep.TabIndex = 25;
            // 
            // Box_Cidade
            // 
            this.Box_Cidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Cidade.Location = new System.Drawing.Point(298, 272);
            this.Box_Cidade.Name = "Box_Cidade";
            this.Box_Cidade.Size = new System.Drawing.Size(183, 28);
            this.Box_Cidade.TabIndex = 26;
            this.Box_Cidade.TextChanged += new System.EventHandler(this.Box_Cidade_TextChanged);
            // 
            // Box_Estado
            // 
            this.Box_Estado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Estado.Location = new System.Drawing.Point(505, 272);
            this.Box_Estado.MaxLength = 2;
            this.Box_Estado.Name = "Box_Estado";
            this.Box_Estado.Size = new System.Drawing.Size(73, 28);
            this.Box_Estado.TabIndex = 32767;
            // 
            // Box_InscriEst
            // 
            this.Box_InscriEst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_InscriEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_InscriEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_InscriEst.Location = new System.Drawing.Point(25, 212);
            this.Box_InscriEst.Name = "Box_InscriEst";
            this.Box_InscriEst.Size = new System.Drawing.Size(255, 28);
            this.Box_InscriEst.TabIndex = 32768;
            // 
            // Box_Num
            // 
            this.Box_Num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Num.Location = new System.Drawing.Point(214, 272);
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
            this.Box_Bairro.Location = new System.Drawing.Point(27, 272);
            this.Box_Bairro.Name = "Box_Bairro";
            this.Box_Bairro.Size = new System.Drawing.Size(163, 28);
            this.Box_Bairro.TabIndex = 32770;
            // 
            // Box_Contato
            // 
            this.Box_Contato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Contato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Contato.Location = new System.Drawing.Point(27, 340);
            this.Box_Contato.Name = "Box_Contato";
            this.Box_Contato.Size = new System.Drawing.Size(201, 28);
            this.Box_Contato.TabIndex = 32771;
            // 
            // Box_Tele1
            // 
            this.Box_Tele1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Tele1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Tele1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Tele1.Location = new System.Drawing.Point(25, 402);
            this.Box_Tele1.Name = "Box_Tele1";
            this.Box_Tele1.Size = new System.Drawing.Size(183, 28);
            this.Box_Tele1.TabIndex = 32772;
            // 
            // Box_Tele2
            // 
            this.Box_Tele2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Tele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Tele2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Tele2.Location = new System.Drawing.Point(264, 402);
            this.Box_Tele2.Name = "Box_Tele2";
            this.Box_Tele2.Size = new System.Drawing.Size(183, 28);
            this.Box_Tele2.TabIndex = 32773;
            // 
            // Box_Email
            // 
            this.Box_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box_Email.Location = new System.Drawing.Point(264, 338);
            this.Box_Email.Name = "Box_Email";
            this.Box_Email.Size = new System.Drawing.Size(255, 28);
            this.Box_Email.TabIndex = 32774;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 745);
            this.Controls.Add(this.Box_Email);
            this.Controls.Add(this.Box_Tele2);
            this.Controls.Add(this.Box_Tele1);
            this.Controls.Add(this.Box_Contato);
            this.Controls.Add(this.Box_Bairro);
            this.Controls.Add(this.Box_Num);
            this.Controls.Add(this.Box_InscriEst);
            this.Controls.Add(this.Box_Estado);
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
            this.Controls.Add(this.estate_lbl);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.inscEst_lbl);
            this.Controls.Add(this.ende_lbl);
            this.Controls.Add(this.Cnpj_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Plus - Ver. 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Cnpj_lbl;
        private System.Windows.Forms.Label ende_lbl;
        private System.Windows.Forms.Label inscEst_lbl;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Label estate_lbl;
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
        private System.Windows.Forms.TextBox Box_Estado;
        private System.Windows.Forms.TextBox Box_InscriEst;
        private System.Windows.Forms.TextBox Box_Num;
        private System.Windows.Forms.TextBox Box_Bairro;
        private System.Windows.Forms.TextBox Box_Contato;
        private System.Windows.Forms.TextBox Box_Tele1;
        private System.Windows.Forms.TextBox Box_Tele2;
        private System.Windows.Forms.TextBox Box_Email;
    }
}

