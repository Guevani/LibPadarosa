namespace Padarosa.Formularios
{
    partial class MenuUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCompletoCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSenhaEdi = new System.Windows.Forms.TextBox();
            this.txtEmailEdi = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoEdi = new System.Windows.Forms.TextBox();
            this.lblNovasenhaEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeCompletoEdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(5, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(995, 398);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtSenhaCad);
            this.grbCadastro.Controls.Add(this.txtEmailCad);
            this.grbCadastro.Controls.Add(this.txtNomeCompletoCad);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblNomeCompletoCad);
            this.grbCadastro.Location = new System.Drawing.Point(12, 435);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(327, 165);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(41, 110);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(245, 39);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(95, 67);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCad.TabIndex = 5;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(95, 41);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCad.TabIndex = 4;
            // 
            // txtNomeCompletoCad
            // 
            this.txtNomeCompletoCad.Location = new System.Drawing.Point(95, 13);
            this.txtNomeCompletoCad.Name = "txtNomeCompletoCad";
            this.txtNomeCompletoCad.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompletoCad.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(7, 74);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(7, 46);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblNomeCompletoCad
            // 
            this.lblNomeCompletoCad.AutoSize = true;
            this.lblNomeCompletoCad.Location = new System.Drawing.Point(7, 20);
            this.lblNomeCompletoCad.Name = "lblNomeCompletoCad";
            this.lblNomeCompletoCad.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompletoCad.TabIndex = 0;
            this.lblNomeCompletoCad.Text = "Nome Completo";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtSenhaEdi);
            this.grbEditar.Controls.Add(this.txtEmailEdi);
            this.grbEditar.Controls.Add(this.txtNomeCompletoEdi);
            this.grbEditar.Controls.Add(this.lblNovasenhaEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(691, 435);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(289, 165);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Cadastro:";
            this.grbEditar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 110);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(245, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSenhaEdi
            // 
            this.txtSenhaEdi.Location = new System.Drawing.Point(95, 74);
            this.txtSenhaEdi.Name = "txtSenhaEdi";
            this.txtSenhaEdi.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaEdi.TabIndex = 5;
            // 
            // txtEmailEdi
            // 
            this.txtEmailEdi.Location = new System.Drawing.Point(95, 46);
            this.txtEmailEdi.Name = "txtEmailEdi";
            this.txtEmailEdi.Size = new System.Drawing.Size(100, 20);
            this.txtEmailEdi.TabIndex = 4;
            // 
            // txtNomeCompletoEdi
            // 
            this.txtNomeCompletoEdi.Location = new System.Drawing.Point(95, 13);
            this.txtNomeCompletoEdi.Name = "txtNomeCompletoEdi";
            this.txtNomeCompletoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompletoEdi.TabIndex = 3;
            // 
            // lblNovasenhaEdi
            // 
            this.lblNovasenhaEdi.AutoSize = true;
            this.lblNovasenhaEdi.Location = new System.Drawing.Point(7, 74);
            this.lblNovasenhaEdi.Name = "lblNovasenhaEdi";
            this.lblNovasenhaEdi.Size = new System.Drawing.Size(70, 13);
            this.lblNovasenhaEdi.TabIndex = 2;
            this.lblNovasenhaEdi.Text = "Nova Senha:";
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(7, 46);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 1;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblNomeCompletoEdi
            // 
            this.lblNomeCompletoEdi.AutoSize = true;
            this.lblNomeCompletoEdi.Location = new System.Drawing.Point(7, 20);
            this.lblNomeCompletoEdi.Name = "lblNomeCompletoEdi";
            this.lblNomeCompletoEdi.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompletoEdi.TabIndex = 0;
            this.lblNomeCompletoEdi.Text = "Nome Completo";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 626);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "MenuUsuarios";
            this.Text = "Gerenciamneto de Usuários";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtNomeCompletoCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCompletoCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSenhaEdi;
        private System.Windows.Forms.TextBox txtEmailEdi;
        private System.Windows.Forms.TextBox txtNomeCompletoEdi;
        private System.Windows.Forms.Label lblNovasenhaEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeCompletoEdi;
    }
}