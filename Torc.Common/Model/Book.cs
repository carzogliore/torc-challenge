﻿using Torc.Common;

namespace Torc.Business;

public class Book : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Type { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }
    public int TotalCopies { get; set; }
    public int CopiesInUse { get; set; }
}