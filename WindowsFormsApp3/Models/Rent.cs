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
    
    public partial class Rent
    {
        public int ID { get; set; }
        public Nullable<int> ID_tenan { get; set; }
        public Nullable<int> ID_Mall { get; set; }
        public Nullable<int> ID_workers { get; set; }
        public string Num_pav { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Start_rent { get; set; }
        public System.DateTime End_rent { get; set; }
    
        public virtual Mall Mall { get; set; }
        public virtual Pavilion Pavilion { get; set; }
        public virtual Tenants Tenants { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
