namespace Padarosa.Formularios
{
    partial class MenuProdutos
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
            this.grbCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.cmbProdutosCad = new System.Windows.Forms.ComboBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtPrecoCad = new System.Windows.Forms.TextBox();
            this.txtNomeProdutoCad = new System.Windows.Forms.TextBox();
            this.lblCategoriaProdutoCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblFrase = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEdi = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNovoPrecoEdi = new System.Windows.Forms.TextBox();
            this.txtNovoNomeEdi = new System.Windows.Forms.TextBox();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.lblCategoriaProdutoEdi = new System.Windows.Forms.Label();
            this.lblNovoNomeEdi = new System.Windows.Forms.Label();
            this.grbCadastrarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCadastrarProduto
            // 
            this.grbCadastrarProduto.Controls.Add(this.cmbProdutosCad);
            this.grbCadastrarProduto.Controls.Add(this.btnCadastro);
            this.grbCadastrarProduto.Controls.Add(this.txtPrecoCad);
            this.grbCadastrarProduto.Controls.Add(this.txtNomeProdutoCad);
            this.grbCadastrarProduto.Controls.Add(this.lblCategoriaProdutoCad);
            this.grbCadastrarProduto.Controls.Add(this.lblPrecoCad);
            this.grbCadastrarProduto.Controls.Add(this.lblNomeCad);
            this.grbCadastrarProduto.Location = new System.Drawing.Point(26, 347);
            this.grbCadastrarProduto.Name = "grbCadastrarProduto";
            this.grbCadastrarProduto.Size = new System.Drawing.Size(359, 202);
            this.grbCadastrarProduto.TabIndex = 7;
            this.grbCadastrarProduto.TabStop = false;
            this.grbCadastrarProduto.Text = "Cadastrar Produto: ";
            // 
            // cmbProdutosCad
            // 
            this.cmbProdutosCad.FormattingEnabled = true;
            this.cmbProdutosCad.Location = new System.Drawing.Point(117, 71);
            this.cmbProdutosCad.Name = "cmbProdutosCad";
            this.cmbProdutosCad.Size = new System.Drawing.Size(121, 21);
            this.cmbProdutosCad.TabIndex = 9;
            this.cmbProdutosCad.SelectedIndexChanged += new System.EventHandler(this.cmbProdutosCad_SelectedIndexChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(51, 141);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(249, 40);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "CADASTRAR PRODUTO";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtPrecoCad
            // 
            this.txtPrecoCad.Location = new System.Drawing.Point(117, 104);
            this.txtPrecoCad.Name = "txtPrecoCad";
            this.txtPrecoCad.Size = new System.Drawing.Size(198, 20);
            this.txtPrecoCad.TabIndex = 7;
            this.txtPrecoCad.TextChanged += new System.EventHandler(this.txtPrecoCad_TextChanged);
            // 
            // txtNomeProdutoCad
            // 
            this.txtNomeProdutoCad.Location = new System.Drawing.Point(117, 27);
            this.txtNomeProdutoCad.Name = "txtNomeProdutoCad";
            this.txtNomeProdutoCad.Size = new System.Drawing.Size(198, 20);
            this.txtNomeProdutoCad.TabIndex = 4;
            this.txtNomeProdutoCad.TextChanged += new System.EventHandler(this.txtNomeProdutoCad_TextChanged);
            // 
            // lblCategoriaProdutoCad
            // 
            this.lblCategoriaProdutoCad.AutoSize = true;
            this.lblCategoriaProdutoCad.Location = new System.Drawing.Point(4, 71);
            this.lblCategoriaProdutoCad.Name = "lblCategoriaProdutoCad";
            this.lblCategoriaProdutoCad.Size = new System.Drawing.Size(113, 13);
            this.lblCategoriaProdutoCad.TabIndex = 2;
            this.lblCategoriaProdutoCad.Text = "Categoria do Produto: ";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Location = new System.Drawing.Point(7, 104);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(41, 13);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço: ";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(7, 30);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(96, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome do Produto: ";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(176, 71);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(529, 25);
            this.lblFrase.TabIndex = 6;
            this.lblFrase.Text = "Olá, Meu Rei!  Escolha umas das opções abaixo:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 109);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(838, 232);
            this.dgvProdutos.TabIndex = 5;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(359, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 39);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Produtos";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtNovoPrecoEdi);
            this.grbEditar.Controls.Add(this.txtNovoNomeEdi);
            this.grbEditar.Controls.Add(this.lblPrecoEdi);
            this.grbEditar.Controls.Add(this.lblCategoriaProdutoEdi);
            this.grbEditar.Controls.Add(this.lblNovoNomeEdi);
            this.grbEditar.Location = new System.Drawing.Point(574, 357);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(276, 191);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // cmbCategoriaEdi
            // 
            this.cmbCategoriaEdi.FormattingEnabled = true;
            this.cmbCategoriaEdi.Location = new System.Drawing.Point(152, 74);
            this.cmbCategoriaEdi.Name = "cmbCategoriaEdi";
            this.cmbCategoriaEdi.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaEdi.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(29, 147);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(222, 38);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR:";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNovoPrecoEdi
            // 
            this.txtNovoPrecoEdi.Location = new System.Drawing.Point(81, 113);
            this.txtNovoPrecoEdi.Name = "txtNovoPrecoEdi";
            this.txtNovoPrecoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtNovoPrecoEdi.TabIndex = 5;
            // 
            // txtNovoNomeEdi
            // 
            this.txtNovoNomeEdi.Location = new System.Drawing.Point(81, 27);
            this.txtNovoNomeEdi.Name = "txtNovoNomeEdi";
            this.txtNovoNomeEdi.Size = new System.Drawing.Size(100, 20);
            this.txtNovoNomeEdi.TabIndex = 3;
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Location = new System.Drawing.Point(6, 116);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(67, 13);
            this.lblPrecoEdi.TabIndex = 2;
            this.lblPrecoEdi.Text = "Novo Preço:";
            // 
            // lblCategoriaProdutoEdi
            // 
            this.lblCategoriaProdutoEdi.AutoSize = true;
            this.lblCategoriaProdutoEdi.Location = new System.Drawing.Point(6, 74);
            this.lblCategoriaProdutoEdi.Name = "lblCategoriaProdutoEdi";
            this.lblCategoriaProdutoEdi.Size = new System.Drawing.Size(139, 13);
            this.lblCategoriaProdutoEdi.TabIndex = 1;
            this.lblCategoriaProdutoEdi.Text = "Nova Categoria do Produto:";
            this.lblCategoriaProdutoEdi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNovoNomeEdi
            // 
            this.lblNovoNomeEdi.AutoSize = true;
            this.lblNovoNomeEdi.Location = new System.Drawing.Point(7, 34);
            this.lblNovoNomeEdi.Name = "lblNovoNomeEdi";
            this.lblNovoNomeEdi.Size = new System.Drawing.Size(67, 13);
            this.lblNovoNomeEdi.TabIndex = 0;
            this.lblNovoNomeEdi.Text = "Novo Nome:";
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrarProduto);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            this.grbCadastrarProduto.ResumeLayout(false);
            this.grbCadastrarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCadastrarProduto;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txtPrecoCad;
        private System.Windows.Forms.TextBox txtNomeProdutoCad;
        private System.Windows.Forms.Label lblCategoriaProdutoCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.Label lblCategoriaProdutoEdi;
        private System.Windows.Forms.Label lblNovoNomeEdi;
        private System.Windows.Forms.TextBox txtNovoPrecoEdi;
        private System.Windows.Forms.TextBox txtNovoNomeEdi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbProdutosCad;
        private System.Windows.Forms.ComboBox cmbCategoriaEdi;
    }
}