using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.VISTA;

namespace CRUD_tablas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void cRUDClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocumento documento = new FrmDocumento();
            documento.MdiParent = this;
            documento.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void clickParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acercaDe = new FrmAcercaDe();
            acercaDe.MdiParent = this;
            acercaDe.Show();
        }
    }
}
