using Database.Repositorios;
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

namespace WindowsForms.Telas.Funcinarios
{
    public partial class CargoView : Form
    {
        public CargoView()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            gbCargoNovo.Visible = !gbCargoNovo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;

            var novoCargo = new Cargo(nome, status);

            var cargoRepositorio = new CargoRepositorio();

            var resultado = cargoRepositorio.Inserir(novoCargo);

            if (resultado)
            {
                MessageBox.Show("Cargo foi cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível implementar o cargo");
            }

            gvCargos.Visible = !gvCargos.Visible;

        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            var cargoRepositorio = new CargoRepositorio();
            var dataTable = cargoRepositorio.ObterTodos();
            gvCargos.DataSource = dataTable;

        }

        private void gvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gbCargoNovo.Show();
                DataGridViewRow row = gvCargos.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();


                object cellValue = row.Cells[2].Value;
                if (cellValue != null && cellValue != DBNull.Value && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    chkStatus.Checked = Convert.ToBoolean(cellValue);
                }
                else
                {
                    chkStatus.Checked = false;
                }

            }
        }
    }
}
