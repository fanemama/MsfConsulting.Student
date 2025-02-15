﻿using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class EnrollCommand : IRequest<Enrollment>
    {
        public EnrollCommand(int id)
        {
            StudentId = id;
        }
        public int StudentId { get; private set; }
        public string Course { get; set; }
        public string Grade { get; set; }
    }
}
