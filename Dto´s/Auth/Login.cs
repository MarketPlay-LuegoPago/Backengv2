using System.ComponentModel.DataAnnotations; 



namespace backend.Dto;
public class Login
{
    [Required]
    public string Email {get; set; }
    public string Password {get; set; }
    
}