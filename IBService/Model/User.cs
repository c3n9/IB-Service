//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int GenderId { get; set; }
        public string Post { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string SecretWord { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        public Nullable<System.DateTime> BanTime { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<bool> AddData { get; set; }
        public Nullable<bool> ViewData { get; set; }
        public Nullable<bool> Reports { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Type Type { get; set; }
    }
}
