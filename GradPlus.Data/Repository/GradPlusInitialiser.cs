﻿using GradPlus.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradPlus.Data.Repository
{
    public class GradPlusInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<GradPlusContext>
    {
        protected override void Seed(GradPlusContext context)
        {
           
        }

    }
}
