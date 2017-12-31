//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShootingRanges
    {
        public ShootingRanges()
        {
            this.Cups = new HashSet<Cups>();
            this.ShooterClubs = new HashSet<ShooterClubs>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string Info { get; set; }
        public int IdRegion { get; set; }
        public string Town { get; set; }
        public int IdUser { get; set; }
    
        public virtual ICollection<Cups> Cups { get; set; }
        public virtual ICollection<ShooterClubs> ShooterClubs { get; set; }
        public virtual Users Users { get; set; }
        public virtual Regions Regions { get; set; }
    }
}
