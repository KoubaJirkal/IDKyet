using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreFormSelectDemo.Models
{
    public enum EnumServers
    {
        [Display(Name = "EUNE")]
        EUNE,
        [Display(Name = "EUW")]
        EUW,
        [Display(Name = "BR")]
        BR,
        [Display(Name = "LAN")]
        LAN,
        [Display(Name = "LAS")]
        LAS,
        [Display(Name = "NA")]
        NA,
    }
}