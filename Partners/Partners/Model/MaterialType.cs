using System;
using System.Collections.Generic;

namespace Partners.Model;

public partial class MaterialType
{
    public int IdMaterialType { get; set; }

    public string? TypeMaterial { get; set; }

    public decimal? ProcentMaterial { get; set; }
}
