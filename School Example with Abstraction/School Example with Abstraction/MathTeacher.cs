using System;
using System.Collections.Generic;
using System.Text;

namespace School_Example_with_Abstraction
{
    public class MathTeacher:Teacher 
    {
        public override void TeachLesson()
        {
            Console.WriteLine("Teaches Math");
        }
    }
}
