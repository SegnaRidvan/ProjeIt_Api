﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MateryalTip
    {
        [Key]
        public int MateryalTipId { get; set; }
        public string MateryalTipAdi { get; set; } 
    }
}
