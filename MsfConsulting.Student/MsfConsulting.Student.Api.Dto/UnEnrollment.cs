﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Dto
{
    public class UnEnrollment
    {
        public int Id { get; set; }
        public string Course { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
