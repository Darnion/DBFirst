//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirst.Context.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activities()
        {
            this.Users1 = new HashSet<Users>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public int DayNumber { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public int ModeratorId { get; set; }
        public int EventId { get; set; }
    
        public virtual Events Events { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users1 { get; set; }
    }
}
