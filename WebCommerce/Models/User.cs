﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCommerce.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
