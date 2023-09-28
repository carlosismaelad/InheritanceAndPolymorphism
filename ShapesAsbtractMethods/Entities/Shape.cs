using System.Formats.Asn1;
using ShapesAsbtractMethods.Entities.Enums;

namespace ShapesAsbtractMethods.Entities

{
    public abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();


    }
}