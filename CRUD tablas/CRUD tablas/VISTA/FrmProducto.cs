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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            clear();
            carga();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtId.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtEstadoProducto.Clear();
        }
        void carga()
        {
            dtgProducto.Rows.Clear();
            ClsDProducto clsdProducto = new ClsDProducto();
            List<tb_producto> Lista = clsdProducto.cargadeDatos();

            foreach (var interacion in Lista)
            {
                dtgProducto.Rows.Add(interacion.idProducto, interacion.nombreProducto, interacion.precioProducto, interacion.estadoProducto);
            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgProducto.CurrentRow.Cells[0].Value.ToString();
            String NombreProducto = dtgProducto.CurrentRow.Cells[1].Value.ToString();
            String PrecioProducto = dtgProducto.CurrentRow.Cells[2].Value.ToString();
            String EstadoProducto = dtgProducto.CurrentRow.Cells[3].Value.ToString();

            txtId.Text = Id;
            txtNombreProducto.Text = NombreProducto;
            txtPrecio.Text = PrecioProducto;
            txtEstadoProducto.Text = EstadoProducto;
            
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDProducto producto = new ClsDProducto();
                tb_producto tb_Producto = new tb_producto();
                tb_Producto.nombreProducto = txtNombreProducto.Text;
                tb_Producto.precioProducto = txtPrecio.Text;
                tb_Producto.estadoProducto = txtEstadoProducto.Text;
                producto.Guardar(tb_Producto);
                
            }
            else
            {
                ClsDProducto producto = new ClsDProducto();
                tb_producto tb_Producto = new tb_producto();
                tb_Producto.idProducto = Convert.ToInt32(txtId.Text);
                tb_Producto.nombreProducto = txtNombreProducto.Text;
                tb_Producto.precioProducto = txtPrecio.Text;
                tb_Producto.estadoProducto = txtEstadoProducto.Text;

                producto.actualizar(tb_Producto);
            }
            clear();
            carga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDProducto producto = new ClsDProducto();
            producto.eliminar(Convert.ToInt32(txtId.Text));
            carga();
            clear();
        }
    }
}
