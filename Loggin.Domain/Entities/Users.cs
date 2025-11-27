using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggin.Domain.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string UserName {  get; set; }
        [Required]
        [StringLength(60)]
        public string PassWord { get; set; }

        public bool Activo { get; set; }

    }
}
