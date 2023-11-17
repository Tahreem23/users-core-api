using System;
using System.ComponentModel.DataAnnotations;

namespace Urduville.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Registration date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; }

        [MaxLength(255, ErrorMessage = "Profile picture URL cannot exceed 255 characters.")]
        public string ProfilePicture { get; set; }

        [MaxLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
        public string Bio { get; set; }

        [MaxLength(50, ErrorMessage = "Country cannot exceed 50 characters.")]
        public string Country { get; set; }

        [MaxLength(255, ErrorMessage = "Preferred genres cannot exceed 255 characters.")]
        public string PreferredGenres { get; set; }

        [Required(ErrorMessage = "Created on date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        [Required(ErrorMessage = "Updated on date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedOn { get; set; }
    }

}
