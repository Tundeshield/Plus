﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Models.Domain
{
    public class JobApplication
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public int JobSeekerID { get; set; }
        public DateTime JobAppliedDate { get; set; }
    }
}
