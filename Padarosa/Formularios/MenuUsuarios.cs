using LibPadarosa;
using System;
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
    public partial class MenuUsuarios : Form
    {   

        // Objeto globais:
        private Usuario _u;
        private int _idSelecionado;
        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            // Carregar Dados do Banco para o dgv:
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txtNomeCompletoCad.Text.Length > 5 && txtEmailCad.Text.Length > 6 && txtSenhaCad.Text.Length > 6;
            if (valida)
            {
                u.NomeCompleto = txtNomeCompletoCad.Text;
                u.Email = txtEmailCad.Text;
                u.Senha = txtSenhaCad.Text;
                // Chamar Cadastrar:
                if(Banco.UsuarioDAO.Cadastrar(u) == true)
                {
                    MessageBox.Show("Usuário Cadastrado");
                    // Limpar os Campos:
                    txtNomeCompletoCad.Clear();
                    txtEmailCad.Clear();
                    txtSenhaCad.Clear();
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o GroupBox de editar:
            // grbEditar.Visible = true;

            // Ativar o GroupBox de Editar:
             grbEditar.Enabled = true;

            // Descobrir o número da Linha da célula clicada:
            int numeroLinha = dgvUsuarios.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvUsuarios.Rows[numeroLinha];
            
            //MessageBox.Show(linha.Cells[1].Value.ToString());

            // Atribuir o valores das células aos txb do editar:
            txtNomeCompletoEdi.Text = linha.Cells[1].Value.ToString();
            txtEmailEdi.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            u.NomeCompleto = txtNomeCompletoEdi.Text;
            u.Email = txtEmailEdi.Text;
            u.Senha = txtSenhaEdi.Text;
            u.Id = _idSelecionado;
            

               // Chamar a Alterar:
            if (Banco.UsuarioDAO.Alterar(u))
            {
                MessageBox.Show("Usuário Modificado com Sucesso!");
                // Limpar os Campos;
                txtNomeCompletoEdi.Clear();
                txtEmailEdi.Clear();
                txtSenhaEdi.Clear();
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
    }
}
