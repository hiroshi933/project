//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationTechnology.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tariffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tariffs()
        {
            this.Clients = new HashSet<Clients>();
        }
    
        public int IdTarif { get; set; }
        public string TarifName { get; set; }
        public string Internet { get; set; }
        public Nullable<int> CountMinutes { get; set; }
        public Nullable<int> CountSMS { get; set; }
        public Nullable<decimal> Salary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients> Clients { get; set; }
    }
}
