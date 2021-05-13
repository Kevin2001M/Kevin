using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.MODEL;

namespace CRUD_tablas.DAO
{
    class ClsDUsuario
    {
        public List<tb_usuario> cargaDatosUsuario()
        {
            List<tb_usuario> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_usuario.ToList();
            }
            return Lista;
        }

        public void Guardar(tb_usuario user)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario usuario = new tb_usuario();
                usuario.email = user.email;
                usuario.contrasena = user.contrasena;
                db.tb_usuario.Add(usuario);
                db.SaveChanges();
                MessageBox.Show("GUARDADO");
            }
        }
        public void eliminar(int iD)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int Eliminar = Convert.ToInt32(iD);
                tb_usuario usuario = db.tb_usuario.Where(x => x.iDUsuario == Eliminar).Select(x => x).FirstOrDefault();
                db.tb_usuario.Remove(usuario);
                db.SaveChanges();
                MessageBox.Show("ELIMINADO");
            }
        }
        public void actualizar(tb_usuario usuario)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = Convert.ToInt32(usuario.iDUsuario);
                tb_usuario user = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();
                user.email = usuario.email;
                user.contrasena = usuario.contrasena;
                db.SaveChanges();
                MessageBox.Show("ACTUALIZADO");
            }
        }
    }
}
