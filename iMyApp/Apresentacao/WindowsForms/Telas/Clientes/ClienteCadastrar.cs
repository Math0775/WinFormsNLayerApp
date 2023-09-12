using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Telas.Clientes
{
    public partial class ClienteCadastrar : Form
    {
        public ClienteCadastrar()
        {
            InitializeComponent();

            var cliente = new Cliente();

            var colabarodor = new Colaborador();
        }

        private void btnSalvar_Click(object sender, EventArgs e) 
        {
            
        }
    }
}
