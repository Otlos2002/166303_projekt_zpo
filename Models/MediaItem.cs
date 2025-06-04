using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _166303_projekt_zpo.Models
{
    public abstract class MediaItem
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        
    }
}
