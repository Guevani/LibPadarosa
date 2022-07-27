using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAcesso_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length <= 3 && txtSenha.Text.Length <= 3)
            {
                MessageBox.Show("Verifique as informações digitadas! ");
            }
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;
                var resultado = Banco.UsuarioDAO.Logar(u);
                // Verificar se o banco retornou algum dado:
                if(resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário e/ou Senha Incorreta.");
                }
                else
                {
                 // Continuar o Programa:
                 // Guardar as informações vindas do bd:
                 u.NomeCompleto = resultado.Rows[0]["Nome_Completo"].ToString();
                 u.Id = int.Parse(resultado.Rows[0]["Id"].ToString());
                 // Abrir a Janela:
                 var menuprincipal = new Formularios.MenuPrincipal(u);
                 // Esconder a Janela Atual:
                    Hide();
                 // Mostrar a Nova:
                  menuprincipal.ShowDialog();
                 // Ao sair da anterior, Mostrar Novamente:
                    Show();
                 // Limpar os campos do e-mail e senha:
                    txtEmail.Clear();
                    txtSenha.Clear();

                }
            }
        }
    }
}
