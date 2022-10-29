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
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public EnumServers Server { get; set; }

        public ICollection<Champions> Champions { get; set; }
    }
}