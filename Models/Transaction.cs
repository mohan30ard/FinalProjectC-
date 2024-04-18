using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

public partial class Transaction
{
    [Key]
    [Column("TransactionID")]
    public int TransactionId { get; set; }

    public int AccountNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("Transactions")]
    public virtual Account AccountNumberNavigation { get; set; } = null!;
}
