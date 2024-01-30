﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.ViewModels.EmployeeVms
{
    public class EmployeeDetailVm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Note { get; set; }
        public string? ProjectNames { get; set; }
    }
}
