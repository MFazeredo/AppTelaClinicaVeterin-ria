
namespace AppTelaClinicaVeterinária
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.TxtListar = new System.Windows.Forms.Button();
            this.dgListar = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstNome = new System.Windows.Forms.TextBox();
            this.tstEmail = new System.Windows.Forms.TextBox();
            this.tstSenha = new System.Windows.Forms.TextBox();
            this.tstConfSenha = new System.Windows.Forms.TextBox();
            this.tstEndereco = new System.Windows.Forms.TextBox();
            this.tstPEt = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.tstTelefone = new System.Windows.Forms.TextBox();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(34, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(96, 15);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome Completo";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(34, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(36, 15);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Location = new System.Drawing.Point(34, 84);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(39, 15);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.AutoSize = true;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(34, 114);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(96, 15);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AutoSize = true;
            this.txtEndereco.Location = new System.Drawing.Point(34, 152);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(56, 15);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.Text = "Endereço";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(0, 0);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtNomePet
            // 
            this.txtNomePet.AutoSize = true;
            this.txtNomePet.Location = new System.Drawing.Point(34, 217);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(60, 15);
            this.txtNomePet.TabIndex = 6;
            this.txtNomePet.Text = "Nome Pet";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(34, 249);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(129, 249);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(75, 23);
            this.txtExcluir.TabIndex = 15;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // TxtListar
            // 
            this.TxtListar.Location = new System.Drawing.Point(319, 249);
            this.TxtListar.Name = "TxtListar";
            this.TxtListar.Size = new System.Drawing.Size(75, 23);
            this.TxtListar.TabIndex = 17;
            this.TxtListar.Text = "Listar";
            this.TxtListar.UseVisualStyleBackColor = true;
            this.TxtListar.Click += new System.EventHandler(this.TxtListar_Click);
            // 
            // dgListar
            // 
            this.dgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Endereço,
            this.Telefone,
            this.NomePet});
            this.dgListar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgListar.Location = new System.Drawing.Point(34, 338);
            this.dgListar.Name = "dgListar";
            this.dgListar.ReadOnly = true;
            this.dgListar.RowTemplate.Height = 25;
            this.dgListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListar.Size = new System.Drawing.Size(553, 100);
            this.dgListar.TabIndex = 19;
            this.dgListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListar_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // NomePet
            // 
            this.NomePet.HeaderText = "Nome do Pet";
            this.NomePet.Name = "NomePet";
            this.NomePet.ReadOnly = true;
            // 
            // tstNome
            // 
            this.tstNome.Location = new System.Drawing.Point(161, 17);
            this.tstNome.Name = "tstNome";
            this.tstNome.Size = new System.Drawing.Size(329, 23);
            this.tstNome.TabIndex = 29;
            // 
            // tstEmail
            // 
            this.tstEmail.Location = new System.Drawing.Point(161, 47);
            this.tstEmail.Name = "tstEmail";
            this.tstEmail.Size = new System.Drawing.Size(329, 23);
            this.tstEmail.TabIndex = 30;
            // 
            // tstSenha
            // 
            this.tstSenha.Location = new System.Drawing.Point(161, 76);
            this.tstSenha.Name = "tstSenha";
            this.tstSenha.PasswordChar = '*';
            this.tstSenha.Size = new System.Drawing.Size(329, 23);
            this.tstSenha.TabIndex = 31;
            // 
            // tstConfSenha
            // 
            this.tstConfSenha.Location = new System.Drawing.Point(161, 111);
            this.tstConfSenha.Name = "tstConfSenha";
            this.tstConfSenha.PasswordChar = '*';
            this.tstConfSenha.Size = new System.Drawing.Size(329, 23);
            this.tstConfSenha.TabIndex = 32;
            // 
            // tstEndereco
            // 
            this.tstEndereco.Location = new System.Drawing.Point(161, 149);
            this.tstEndereco.Name = "tstEndereco";
            this.tstEndereco.Size = new System.Drawing.Size(329, 23);
            this.tstEndereco.TabIndex = 33;
            // 
            // tstPEt
            // 
            this.tstPEt.Location = new System.Drawing.Point(161, 209);
            this.tstPEt.Name = "tstPEt";
            this.tstPEt.Size = new System.Drawing.Size(329, 23);
            this.tstPEt.TabIndex = 34;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(34, 181);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(51, 15);
            this.lbTel.TabIndex = 35;
            this.lbTel.Text = "Telefone";
            // 
            // tstTelefone
            // 
            this.tstTelefone.Location = new System.Drawing.Point(161, 178);
            this.tstTelefone.Name = "tstTelefone";
            this.tstTelefone.Size = new System.Drawing.Size(329, 23);
            this.tstTelefone.TabIndex = 36;
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.Location = new System.Drawing.Point(415, 249);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(75, 23);
            this.btnVerSenha.TabIndex = 37;
            this.btnVerSenha.Text = "Limpar";
            this.btnVerSenha.UseVisualStyleBackColor = true;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(603, 195);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 23);
            this.txtId.TabIndex = 38;
            this.txtId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnVerSenha);
            this.Controls.Add(this.tstTelefone);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.tstPEt);
            this.Controls.Add(this.tstEndereco);
            this.Controls.Add(this.tstConfSenha);
            this.Controls.Add(this.tstSenha);
            this.Controls.Add(this.tstEmail);
            this.Controls.Add(this.tstNome);
            this.Controls.Add(this.dgListar);
            this.Controls.Add(this.TxtListar);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtConfirmarSenha;
        private System.Windows.Forms.Label txtEndereco;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.Label txtNomePet;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Button TxtListar;
        private System.Windows.Forms.DataGridView dgListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePet;
        private System.Windows.Forms.TextBox tstNome;
        private System.Windows.Forms.TextBox tstEmail;
        private System.Windows.Forms.TextBox tstSenha;
        private System.Windows.Forms.TextBox tstConfSenha;
        private System.Windows.Forms.TextBox tstEndereco;
        private System.Windows.Forms.TextBox tstPEt;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tstTelefone;
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.TextBox txtId;
    }
}

