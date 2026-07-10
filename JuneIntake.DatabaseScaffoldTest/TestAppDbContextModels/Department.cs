using System;
using System.Collections.Generic;

namespace JuneIntake.DatabaseScaffoldTest.TestAppDbContextModels;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? Location { get; set; }

    public decimal? Budget { get; set; }
}
