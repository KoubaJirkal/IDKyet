using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfcDbInit.Models
{
    public class ChampionsList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Role Role { get; set; }
        public int RoleID { get; set; }

        public ICollection<Summs> Summoners { get; set; }
    }
}