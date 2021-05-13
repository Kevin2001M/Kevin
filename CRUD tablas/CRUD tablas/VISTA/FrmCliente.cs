using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.DAO;
using CRUD_tablas.MODEL;

namespace CRUD_tablas.VISTA
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            carga();
            clear();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtDUI.Clear();
        }
        void carga()
        {
            dtgCliente.Rows.Clear();
            ClsDCliente clsdCliente = new ClsDCliente();
            List<tb_cliente> Lista = clsdCliente.cargadeDatos();

            foreach (var interacion in Lista)
            {
                dtgCliente.Rows.Add(interacion.iDCliente, interacion.nombreCliente, interacion.direccionCliente, interacion.duiCliente);
            }
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgCliente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgCliente.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgCliente.CurrentRow.Cells[2].Value.ToString();
            String Dui = dtgCliente.CurrentRow.Cells[3].Value.ToString();

            txtId.Text = Id;
            txtNombre.Text = Nombre;
            txtDireccion.Text = Direccion;
            txtDUI.Text = Dui;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDCliente cliente = new ClsDCliente();
            cliente.deleteUser(Convert.ToInt32(txtId.Text));
            carga();
            clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDCliente cliente = new ClsDCliente();
                tb_cliente tb_Cliente = new tb_cliente();
                tb_Cliente.nombreCliente = txtNombre.Text;
                tb_Cliente.direccionCliente = txtDireccion.Text;
                tb_Cliente.duiCliente = txtDUI.Text;
                cliente.GuardarDato(tb_Cliente);

            }
            else
            {
                ClsDCliente cliente = new ClsDCliente();
                tb_cliente tb_Cliente = new tb_cliente();
                tb_Cliente.iDCliente = Convert.ToInt32(txtId.Text);
                tb_Cliente.nombreCliente = txtNombre.Text;
                tb_Cliente.direccionCliente = txtDireccion.Text;
                tb_Cliente.duiCliente = txtDUI.Text;
                

                cliente.actualizar(tb_Cliente);
            }
            carga();
            clear();
        }
        
    }
}
