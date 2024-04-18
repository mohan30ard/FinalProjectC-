using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

[Index("Username", Name = "UQ__Accounts__536C85E45BEDF298", IsUnique = true)]
public partial class Account
{
    [Key]
    public int AccountNumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [Column("SSN")]
    public long Ssn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Balance { get; set; }

    public bool IsLocked { get; set; }

    [InverseProperty("AccountNumberNavigation")]
    public virtual ICollection<AccountApprovalRequest> AccountApprovalRequests { get; set; } = new List<AccountApprovalRequest>();

    [InverseProperty("AccountNumberNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("User")]
    public virtual UserCredential? UserCredential { get; set; }
}
