using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfcDbInit.Models
{
    public class Champions
    {
        public int ChampionsId { get; set; }
        public int RoleID { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }


        

    }
}