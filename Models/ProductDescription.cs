﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

[Table("ProductDescription", Schema = "SalesLT")]
[Index("Rowguid", Name = "AK_ProductDescription_rowguid", IsUnique = true)]
public partial class ProductDescription
{
    [Key]
    [Column("ProductDescriptionID")]
    public int ProductDescriptionId { get; set; }

    [StringLength(400)]
    public string Description { get; set; } = null!;

    [Column("rowguid")]
    public Guid Rowguid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("ProductDescription")]
    public virtual ICollection<ProductModelProductDescription> ProductModelProductDescriptions { get; set; } = new List<ProductModelProductDescription>();
}
