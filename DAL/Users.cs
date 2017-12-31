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
    
    public partial class Users
    {
        public Users()
        {
            this.Cups = new HashSet<Cups>();
            this.ShooterClubs = new HashSet<ShooterClubs>();
            this.Shooters = new HashSet<Shooters>();
            this.ShootingRanges = new HashSet<ShootingRanges>();
            this.RecoveredPasswords = new HashSet<RecoveredPasswords>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public System.DateTime DateCreate { get; set; }
        public string E_mail { get; set; }
    
        public virtual ICollection<Cups> Cups { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual ICollection<ShooterClubs> ShooterClubs { get; set; }
        public virtual ICollection<Shooters> Shooters { get; set; }
        public virtual ICollection<ShootingRanges> ShootingRanges { get; set; }
        public virtual ICollection<RecoveredPasswords> RecoveredPasswords { get; set; }
    }
}
