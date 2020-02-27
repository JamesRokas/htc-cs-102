using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_Code_Along
{
    class Dog
    {
        public string Breed;
        public string Height;
        public string Name;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }
    }
}
