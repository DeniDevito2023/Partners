using System;
using System.Collections.Generic;

namespace Partners.Model;

public partial class SalePartnersProduct
{
    public int IdSaleProductPartners { get; set; }

    public int? SaleProductFk { get; set; }

    public int? SaleNameProductsFk { get; set; }

    public int SaleAmount { get; set; }

    public DateOnly SaleDate { get; set; }

    public virtual Product? SaleNameProductsFkNavigation { get; set; }

    public virtual Partner? SaleProductFkNavigation { get; set; }
}
//asfasfasdfasdfsdfdsf