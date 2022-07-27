using LibPadarosa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class MenuProdutos : Form
    {
        // objetos globais: 

        int _IdSelecionado;
        private Usuario _u;
        private MenuProdutos _p;
        

        public MenuProdutos(Usuario u)
        {
            
            InitializeComponent();
            _u = u;
            AtualizarDgv();
            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            cmbProdutosCad.DataSource = rows;
            cmbCategoriaEdi.DataSource = rows.Clone();
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            {
                var p = new Produto();
                var valida = txtNomeProdutoCad.Text.Length >= 1;
                if (valida)
                {
                    p.Nome = txtNomeProdutoCad.Text;
                    p.IdCategoria = obterIddaString(cmbProdutosCad.Text);
                    p.Preco = double.Parse(txtPrecoCad.Text);
                    p.IdRespCadastro = _u.Id;
                    // Chamar Cadastrar:
                    if (Banco.ProdutoDAO.Cadastrar(p) == true)
                    {
                        MessageBox.Show("Produto Cadastrado");
                        // Limpar os Campos:
                        txtNomeProdutoCad.Clear();
                        cmbProdutosCad.Text = "";
                        txtPrecoCad.Clear();
                        // Atualizar o dgv:
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro no sistema." + "Verifique as informações digitadas!");
                    }

                }
                else
                {
                    MessageBox.Show("Houve um erro no sistema.");

                }
                
            }
            
        }
        private int obterIddaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }


        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProdutoCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            p.NomeProduto = txtNovoNomeEdi.Text;
            p.IdCategoria = obterIddaString(cmbCategoriaEdi.Text);
            p.Preco = double.Parse(txtNovoPrecoEdi.Text);
            p.Id = _IdSelecionado;
           

             // Chamar o Alterar:
             if (Banco.ProdutoDAO.Alterar(p))
            {
                MessageBox.Show("Produto Modificado com Sucesso!");
                // Limpar os Campos;
                txtNomeProdutoCad.Clear();
                cmbProdutosCad.Text = "";
                txtPrecoCad.Clear();
                // Atualizar o dgv:
                AtualizarDgv();
                // Esconder o GroupBox de editar:
                // grbEditar.Visible = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                
            }
        }

        private void txtPrecoCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProdutosCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o GroupBox de editar:
            // grbEditar.Visible = true;

            // Ativar o GroupBox de Editar:
            grbEditar.Enabled = true;

            // Descobrir o número da Linha da célula clicada:
            int numeroLinha = dgvProdutos.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvProdutos.Rows[numeroLinha];

            //MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtNovoNomeEdi.Text = linha.Cells[1].Value.ToString();
            cmbCategoriaEdi.Text = linha.Cells[4].Value.ToString();
            _IdSelecionado = int.Parse(linha.Cells[3].Value.ToString());
        }
    }
}
