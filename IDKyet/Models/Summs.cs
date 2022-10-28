using ASPCoreFormSelectDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace EfcDbInit.Models
{
    public class Summs
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public EnumServers Server { get; set; }

        public ICollection<ChampionsList> Champions { get; set; }
    }
}