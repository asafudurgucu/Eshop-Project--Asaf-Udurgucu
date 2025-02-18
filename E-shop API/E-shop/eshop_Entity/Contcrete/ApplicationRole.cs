using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace eshop_Entity.Contcrete
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
    }
}
