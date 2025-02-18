﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K_Smart_IMS.Models
{
    public class GridDTO
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortField { get; set; }
        public string SortDirection { get; set; } = "asc";
    }
}
