//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinal.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecetaAgroquimica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecetaAgroquimica()
        {
            this.RecetaAgroquimicaDetalle = new HashSet<RecetaAgroquimicaDetalle>();
        }
    
        public int id { get; set; }
        public System.DateTime fechaReceta { get; set; }
        public string diagnostico { get; set; }
        public string estado { get; set; }
        public bool entregado { get; set; }
        public int fkCampoFinca { get; set; }
        public int fkProductor { get; set; }
        public int fkAgenteFitosanitario { get; set; }
        public int fkVendedor { get; set; }
    
        public virtual AgenteFitosanitario AgenteFitosanitario { get; set; }
        public virtual CampoFinca CampoFinca { get; set; }
        public virtual Productor Productor { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecetaAgroquimicaDetalle> RecetaAgroquimicaDetalle { get; set; }
    }
}
