using System;
using System.Collections.Generic;

namespace WPF_MVVM_DB_Example.Models
{
    public partial class Employee
    {
        public string? Id { get; set; }
        public string? Password { get; set; }
        public string? UserId { get; set; }
        public string? Department { get; set; }
        public string? Level { get; set; }
        public string? UseYn { get; set; }
    }
}
