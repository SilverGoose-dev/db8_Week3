using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInSeparateFile
{
    //Replace internal with public 
    public class Rectangle
    {
		public string Name;
		public double Length;
		public double Height;
		public Rectangle(string _Name, double _Length, double _Height)
		{
			Name = _Name;
			Length = _Length;
			Height = _Height;
		}
		// To add a ToString, start typing public override and double-click ToString
		// And then remove the code it automatically included

		public override string ToString()
		{
			return $"{Name}: Length {Length} Height {Height} Area: {Length * Height} Perimeter: {2 * Length + 2 * Height}";
		}

	}
}
