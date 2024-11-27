using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboDtproperty
{
    public sbyte? Id { get; set; }

    public sbyte? Objectid { get; set; }

    public string? Property { get; set; }

    public string? Value { get; set; }

    public string? Uvalue { get; set; }

    public string? Lvalue { get; set; }

    public sbyte? Version { get; set; }
}
