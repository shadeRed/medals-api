using System.ComponentModel.DataAnnotations;

namespace medals_api.Models
{
    public class Country {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public int GoldCount { get; set; }
        public int SilverCount { get; set; }
        public int BronzeCount { get; set; }
    }
}