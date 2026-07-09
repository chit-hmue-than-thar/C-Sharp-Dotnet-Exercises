using System;
using System.Collections.Generic;

namespace DatabaseFirst.ClassLibrary.AppDbContextModels;

public partial class TblOrder
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public int SalemanId { get; set; }

    public decimal TotalAmt { get; set; }

    public string OrderRemark { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual TblCustomer Customer { get; set; } = null!;

    public virtual TblSaleman Saleman { get; set; } = null!;

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();
}
