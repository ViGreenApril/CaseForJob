using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CaseForJob
{
    public class Worker
    {
        public string Name { get; set; }
        public double AmountOfImages { get; set; }
        public double AmountOfMinutes { get; set; }

        public Worker(string name, int amountOfImages, int AmountOfMinutes)
        {
            this.Name = name;
            this.AmountOfImages = amountOfImages;
            this.AmountOfMinutes = AmountOfMinutes;
        }
    }
}
