using System;
using System.Collections.Generic;

namespace DatabaseFirst.ClassLibrary.AppDbContextModels;

public partial class TblUser2
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
