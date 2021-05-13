using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.MODEL;

namespace CRUD_tablas.DAO
{
    class ClsDCliente
    {
        public List<tb_cliente> cargadeDatos()
        {
            List<tb_cliente> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();
            }
            return Lista;
        }

        public void GuardarDato (tb_cliente user)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente cliente = new tb_cliente();

                cliente.nombreCliente = user.nombreCliente;
                cliente.direccionCliente = user.direccionCliente;
                cliente.duiCliente = user.duiCliente;
                db.tb_cliente.Add(cliente);
                db.SaveChanges();
                MessageBox.Show("GUARDADO");
            }
        }
        public void deleteUser(int iD)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int Eliminar = Convert.ToInt32(iD);
                tb_cliente cliente = db.tb_cliente.Where(x => x.iDCliente == Eliminar).Select(x => x).FirstOrDefault();
                db.tb_cliente.Remove(cliente);
                db.SaveChanges();
                MessageBox.Show("ELIMINADO");
            }
        }
        public void actualizar(tb_cliente cliente)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = Convert.ToInt32(cliente.iDCliente);
                tb_cliente tb_Cliente = db.tb_cliente.Where(x => x.iDCliente == update).Select(x => x).FirstOrDefault();
                tb_Cliente.nombreCliente = cliente.nombreCliente;
                tb_Cliente.direccionCliente = cliente.direccionCliente;
                tb_Cliente.duiCliente = cliente.duiCliente;
                db.SaveChanges();
                MessageBox.Show("ACTUALIZADO");
            }
        }
    }
}
