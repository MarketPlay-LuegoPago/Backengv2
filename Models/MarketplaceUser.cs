using System.ComponentModel.DataAnnotations;


namespace Backengv2.Models
{
    public class MarketplaceUser
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}