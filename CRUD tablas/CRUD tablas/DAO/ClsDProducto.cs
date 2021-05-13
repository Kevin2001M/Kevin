using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.MODEL;

namespace CRUD_tablas.DAO
{
    class ClsDProducto
    {
        public List<tb_producto> cargadeDatos()
        {
            List<tb_producto> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_producto.ToList();
            }
            return Lista;
        }
        public void Guardar(tb_producto produc)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto producto = new tb_producto();
                producto.nombreProducto = produc.nombreProducto;
                producto.precioProducto = produc.precioProducto;
                producto.estadoProducto = produc.estadoProducto;
                db.tb_producto.Add(produc);
                db.SaveChanges();
                MessageBox.Show("GUARDADO");
            }
        }
        public void eliminar(int iD)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int Eliminar = Convert.ToInt32(iD);
                tb_producto producto = db.tb_producto.Where(x => x.idProducto == Eliminar).Select(x => x).FirstOrDefault();
                db.tb_producto.Remove(producto);
                db.SaveChanges();
                MessageBox.Show("ELIMINADO");
            }
        }
        public void actualizar(tb_producto producto)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = Convert.ToInt32(producto.idProducto);
                tb_producto produc = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();
                produc.nombreProducto = producto.nombreProducto;
                produc.precioProducto = producto.precioProducto;
                produc.estadoProducto = producto.estadoProducto;
                db.SaveChanges();
                MessageBox.Show("ACTUALIZADO");
            }
        }
    }
}
