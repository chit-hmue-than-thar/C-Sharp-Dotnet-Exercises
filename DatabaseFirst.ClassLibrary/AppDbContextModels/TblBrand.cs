using System;
using System.Collections.Generic;

namespace DatabaseFirst.ClassLibrary.AppDbContextModels;

public partial class TblBrand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<TblProduct2> TblProduct2s { get; set; } = new List<TblProduct2>();
}
