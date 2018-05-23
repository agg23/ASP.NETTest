using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Models
{
    public class ModelData
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }
        public string Text { get; set; }
        public bool Active { get; set; }
    }
}
