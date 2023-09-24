﻿using graduationProject.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduationProject.Bl.DTOs
{
    public class RoleWriteDTO
    {
        public string? RoleName { get; set; }
        public ICollection<RolePrivilegesWriteDTO>? RolePrivileges { get; set; }
    }
}
