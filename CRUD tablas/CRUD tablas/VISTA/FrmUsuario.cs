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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            clear();
            carga();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtId.Clear();
            txtEmail.Clear();
            txtPass.Clear();
        }
        void carga()
        {
            dtgUsuario.Rows.Clear();
            ClsDUsuario usuario = new ClsDUsuario();
            List<tb_usuario> Lista = usuario.cargaDatosUsuario();

            foreach (var interacion in Lista)
            {
                dtgUsuario.Rows.Add(interacion.iDUsuario, interacion.email, interacion.contrasena);
            }
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                String Id = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
                String Email = dtgUsuario.CurrentRow.Cells[1].Value.ToString();
                String Contrasena = dtgUsuario.CurrentRow.Cells[2].Value.ToString();

                txtId.Text = Id;
                txtEmail.Text = Email;
                txtPass.Text = Contrasena;
            
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDUsuario user = new ClsDUsuario();
            user.eliminar(Convert.ToInt32(txtId.Text));
            carga();
            clear();
            //using (sistema_ventasEntities db = new sistema_ventasEntities())
            //{
            //    int Eliminar = Convert.ToInt32(txtId.Text);
            //    tb_usuario usuario = db.tb_usuario.Where(x => x.iDUsuario == Eliminar).Select(x => x).FirstOrDefault();
            //    db.tb_usuario.Remove(usuario);
            //    db.SaveChanges();
            //    MessageBox.Show("ELIMINADO CORRECTAMENTE");
            //}
            //clear();
            //carga();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDUsuario usuario = new ClsDUsuario();
                tb_usuario user = new tb_usuario();
                user.email = txtEmail.Text;
                user.contrasena = txtPass.Text;
                usuario.Guardar(user);
            }else
            {
                ClsDUsuario usuario = new ClsDUsuario();
                tb_usuario user = new tb_usuario();
                user.iDUsuario = Convert.ToInt32(txtId.Text);
                user.email = txtEmail.Text;
                user.contrasena = txtPass.Text;

                usuario.actualizar(user);
            }
            carga();
            clear();
        }
    }
}
