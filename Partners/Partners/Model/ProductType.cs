using System;
using System.Collections.Generic;

namespace Partners.Model;

public partial class ProductType
{
    public int IdProductTypeCoff { get; set; }

    public string? TypeProductsCoff { get; set; }

    public decimal? CoffProducts { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
