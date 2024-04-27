using System.ComponentModel.DataAnnotations;

namespace LAB12.Models
{
    public class Player
    {
        [Display(Name = "Usuario")]
        public string username { get; set; }
        
        [Display(Name = "Region")]
        public string region { get; set; }

        [Display(Name = "Skin")]
        public string skin { get; set; }
    }
}
