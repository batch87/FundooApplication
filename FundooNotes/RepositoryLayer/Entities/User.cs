﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryLayer.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Userid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int phone { get; set; }
        public string adddress { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cpassword { get; set; }
        public DateTime registereddate { get; set; }
        public DateTime  modifieddate { get; set; }

       

        public virtual IList<UserAddress> Addressess { get; set; }
        public virtual IList<Collabarator> Collabarators { get; set; }

        public virtual ICollection<Notes> Notes { get; set; }

        public virtual ICollection<Label> Labels { get; set; }

    }
}
