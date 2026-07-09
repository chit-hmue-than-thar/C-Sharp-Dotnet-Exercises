using System;
using System.Collections.Generic;

namespace DatabaseFirst.ClassLibrary.AppDbContextModels;

public partial class TblOrderDetail
{
    public int DetailId { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal NetPrice { get; set; }

    public decimal Amt { get; set; }

    public virtual TblOrder Order { get; set; } = null!;

    public virtual TblProduct2 Product { get; set; } = null!;
}
