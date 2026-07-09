using System;
using System.Collections.Generic;

namespace DatabaseFirst.ClassLibrary.AppDbContextModels;

public partial class TblSaleman
{
    public int SalemanId { get; set; }

    public string SalemanName { get; set; } = null!;

    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();
}
