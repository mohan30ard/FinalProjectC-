using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

public partial class AccountApprovalRequest
{
    [Key]
    [Column("RequestID")]
    public int RequestId { get; set; }

    public int AccountNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RequestedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? AdminRemarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejectionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoldDate { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("AccountApprovalRequests")]
    public virtual Account AccountNumberNavigation { get; set; } = null!;
}
