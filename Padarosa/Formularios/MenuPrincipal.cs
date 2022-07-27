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
    public partial class MenuPrincipal : Form
    {
        //Objeto global:
        private Usuario _u;
        private MenuProdutos _p;
        private MenuProdutos p;

        public MenuPrincipal(Usuario u)

        {
            InitializeComponent();
            _u = u;
            _p = p;
            lblFrase.Text = "Olá " + u.NomeCompleto + "! Escolha uma das opções Abaixo:";
            // Ocultar o Botão de usuários de todos, exceto o adm:
            if (u.Id != 1)
            {
                btnUsuario.Visible = false;
            }
        }
        

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var menuusuarios = new MenuUsuarios(_u);    
            menuusuarios.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var menuprodutos = new MenuProdutos(_u);
            menuprodutos.ShowDialog();

        }
    }
}
