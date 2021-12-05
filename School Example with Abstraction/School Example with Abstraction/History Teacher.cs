using System;
using System.Collections.Generic;
using System.Text;

namespace School_Example_with_Abstraction
{
    class History_Teacher:Teacher 
    {
        public override void TeachLesson()
        {
            Console.WriteLine("Teaches History");
        }
    }
}
