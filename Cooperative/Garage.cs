//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cooperative
{
    using System;
    using System.Collections.Generic;
    
    public partial class Garage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Garage()
        {
            this.RentLog = new HashSet<RentLog>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Id_Owner { get; set; }
    
        public virtual Owner Owner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentLog> RentLog { get; set; }
    }
}
