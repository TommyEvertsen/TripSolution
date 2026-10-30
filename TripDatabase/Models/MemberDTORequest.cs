using System;
using System.Collections.Generic;
using System.Text;

namespace TripDatabase.Models
{
    public class MemberDTORequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; } = null!;
        public DateOnly DateOfBirth { get; set; }
    }
}
