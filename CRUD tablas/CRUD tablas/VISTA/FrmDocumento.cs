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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
            clear();
            carga();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                String Id = dtgDocumento.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtgDocumento.CurrentRow.Cells[1].Value.ToString();

                txtId.Text = Id;
                txtNombreDocumento.Text = Nombre;

            }
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtId.Clear();
            txtNombreDocumento.Clear();
        }
        void carga()
        {
            dtgDocumento.Rows.Clear();
            ClsDDocumento documento = new ClsDDocumento();
            List<tb_documento> Lista = documento.cargaDatosDocumentos();
            foreach (var interacion in Lista)
            {
                dtgDocumento.Rows.Add(interacion.iDDocumento, interacion.nombreDocumento);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDDocumento doc = new ClsDDocumento();
            doc.eliminar(Convert.ToInt32(txtId.Text));
            carga();
            clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDDocumento documento = new ClsDDocumento();
                tb_documento doc = new tb_documento();
                doc.nombreDocumento = txtNombreDocumento.Text;
                documento.Guardar(doc);
            }else
            {
                ClsDDocumento documento = new ClsDDocumento();
                tb_documento doc = new tb_documento();
                doc.iDDocumento = Convert.ToInt32(txtId.Text);
                doc.nombreDocumento = txtNombreDocumento.Text;
                documento.actualizar(doc);
            }
            clear();
            carga();
        }
    }
}
