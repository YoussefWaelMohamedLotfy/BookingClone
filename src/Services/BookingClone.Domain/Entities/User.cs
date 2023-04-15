using System;
using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class User: BaseEntity<int>
{
   public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    

}

