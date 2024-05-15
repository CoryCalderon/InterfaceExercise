using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string Logo { get; set; }
        public string Name { get; set; }

        public void Emblem();
        public void Company();
    }
}
