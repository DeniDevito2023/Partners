using System;
using System.Collections.Generic;

namespace Partners.Model;

public partial class Partner
{
    public int IdPartners { get; set; }

    public string? TypePartners { get; set; }

    public string? NamePartners { get; set; }

    public string? Director { get; set; }

    public string? Email { get; set; }

    public decimal? Phone { get; set; }

    public string? Address { get; set; }

    public decimal? Inn { get; set; }

    public int? Rating { get; set; }

    public virtual ICollection<SalePartnersProduct> SalePartnersProducts { get; set; } = new List<SalePartnersProduct>();
}
