﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sharff.ApiRest.Models
{
    public class LogDto
    {
        public string Exception { get; set; }
        public string Level { get; set; }
        public string MachineName { get; set; }
        public string Message { get; set; }
        public string MessageTemplate { get; set; }
        public string Properties { get; set; }
        public string PropsTest { get; set; }
        public DateTime? RaiseDate { get; set; }
    }
}