//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mall()
        {
            this.Pavilion = new HashSet<Pavilion>();
            this.Rent = new HashSet<Rent>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Nullable<int> Amount_P { get; set; }
        public string Town { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<double> Coeff_cost { get; set; }
        public Nullable<int> Floor { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pavilion> Pavilion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
