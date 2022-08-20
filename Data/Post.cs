using System.ComponentModel.DataAnnotations;
namespace callList.Data

{
    internal sealed class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        
        public string Email { get; set; } = 
        string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
