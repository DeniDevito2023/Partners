using System;
using System.Collections.Generic;

namespace Partners.Model;

public partial class Product
{
    public int IdProducts { get; set; }

    public int? TypeProducts { get; set; }

    public string? NameProducts { get; set; }

    public int? Articul { get; set; }

    public decimal? MinPriceForPartners { get; set; }

    public virtual ICollection<SalePartnersProduct> SalePartnersProducts { get; set; } = new List<SalePartnersProduct>();

    public virtual ProductType? TypeProductsNavigation { get; set; }
}
