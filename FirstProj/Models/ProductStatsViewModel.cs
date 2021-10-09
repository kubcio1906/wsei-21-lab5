using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProj.Models
{
    public class ProductStatsViewModel
    {
        public int NameLength { get; internal set; }
        public int DescriptionLength { get; internal set; }
    }
}
