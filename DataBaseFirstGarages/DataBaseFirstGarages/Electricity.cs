//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirstGarages
{
    using System;
    using System.Collections.Generic;
    
    public partial class Electricity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Electricity()
        {
            this.RentLog = new HashSet<RentLog>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Tax { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentLog> RentLog { get; set; }
    }
}
