using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

[Index("Username", Name = "UQ__UserCred__536C85E44AA0E8F1", IsUnique = true)]
public partial class UserCredential
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserCredential")]
    public virtual Account User { get; set; } = null!;
}
