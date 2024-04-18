using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

[Keyless]
[Table("Cust_Users")]
[Index("Username", Name = "UQ__Cust_Use__536C85E449B6A62F", IsUnique = true)]
public partial class CustUser
{
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;
}
