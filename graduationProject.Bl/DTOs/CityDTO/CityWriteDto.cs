﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduationProject.Bl.DTOs.CityDTO
{
    public class CityWriteDto
    {
        public string Name { get; set; } = string.Empty;

        public double ShippingCost { get; set; }

        public byte StateId { get; set; }
    }
}
