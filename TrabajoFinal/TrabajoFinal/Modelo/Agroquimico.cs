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
    
    public partial class Agroquimico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agroquimico()
        {
            this.RecetaAgroquimicaDetalle = new HashSet<RecetaAgroquimicaDetalle>();
        }
    
        public int id { get; set; }
        public string marcaComercial { get; set; }
        public string codigo { get; set; }
        public string principioActivo { get; set; }
        public string tipoEnvase { get; set; }
        public double capacidadEnvase { get; set; }
        public string unidadMedida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecetaAgroquimicaDetalle> RecetaAgroquimicaDetalle { get; set; }
    }
}