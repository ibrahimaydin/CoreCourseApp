﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Contact Contact { get; set; }

    }
}
