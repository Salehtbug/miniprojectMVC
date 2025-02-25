using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.Models;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;


    [EmailAddress(ErrorMessage = "Please enter valid Email")]
    [Required(ErrorMessage = "Please enter your Email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string Role { get; set; } = null!;
}
