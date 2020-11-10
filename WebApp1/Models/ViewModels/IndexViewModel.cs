using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Command> commands { get; set; }
    }
}
