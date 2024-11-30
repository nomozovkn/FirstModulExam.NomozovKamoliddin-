using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModulExam.Models
{
    public class Phone
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double price { get; set; }
        public string color { get; set; }

    }
}
