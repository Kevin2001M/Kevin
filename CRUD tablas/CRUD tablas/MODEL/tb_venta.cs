//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_tablas.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_venta()
        {
            this.tb_detalleVenta = new HashSet<tb_detalleVenta>();
        }
    
        public int iDVenta { get; set; }
        public Nullable<int> iDDocumento { get; set; }
        public Nullable<int> iDCliente { get; set; }
        public Nullable<int> iDUsuario { get; set; }
        public Nullable<decimal> totalVenta { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_detalleVenta> tb_detalleVenta { get; set; }
        public virtual tb_documento tb_documento { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
    }
}
