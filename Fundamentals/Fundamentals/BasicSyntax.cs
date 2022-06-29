using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class BasicSyntax
    {
        /*Member Variables
        Variables are attributes or data members of a class, 
            used for storing data.In the preceding program, the Rectangle class has two member variables named length and width.*/
       
        double Length;
        double Width;
       
        
        /*Member Functions
         Functions are set of statements that perform a specific task. The member functions of a class are declared within the class.
        Our sample class Rectangle contains three member functions: AcceptDetails, GetArea and Display.*/
        public void AcceptDetails()

        {
         Length = 5.5;
         Width = 3.5;
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public void Display()
        {
            //Different Way of print the output
        Console.WriteLine($"Length:{Length} Width:{Width} Area{GetArea()}");
        Console.WriteLine("Width:{0}",Width);
        Console.WriteLine("Area:"+GetArea());
        Console.WriteLine("Length:{0}   Width:{1}   Area:{2}", Length ,Width ,GetArea()); 
           
            Console.ReadKey();
        }
    }
}
