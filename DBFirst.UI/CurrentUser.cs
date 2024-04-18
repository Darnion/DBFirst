using DBFirst.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst.UI
{
    public static class CurrentUser
    {
        public static Users User { get; set; } = null;
    }
}
