using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_tablas.MODEL;

namespace CRUD_tablas.DAO
{
    class ClsDDocumento
    {
        public List<tb_documento> cargaDatosDocumentos()
        {
            List<tb_documento> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_documento.ToList();
            }
            return Lista;
        }
        public void Guardar(tb_documento doc)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento documento = new tb_documento();
                documento.nombreDocumento = doc.nombreDocumento;
                db.tb_documento.Add(doc);
                db.SaveChanges();
                MessageBox.Show("GUARDADO");
            }
        }
        public void eliminar(int iD)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int Eliminar = Convert.ToInt32(iD);
                tb_documento documento = db.tb_documento.Where(x => x.iDDocumento == Eliminar).Select(x => x).FirstOrDefault();
                db.tb_documento.Remove(documento);
                db.SaveChanges();
                MessageBox.Show("ELIMINADO");
            }
        }
        public void actualizar(tb_documento documento)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                int update = Convert.ToInt32(documento.iDDocumento);
                tb_documento doc = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();
                doc.nombreDocumento = documento.nombreDocumento;
                db.SaveChanges();
                MessageBox.Show("ACTUALIZADO");
            }
        }
    }
}
