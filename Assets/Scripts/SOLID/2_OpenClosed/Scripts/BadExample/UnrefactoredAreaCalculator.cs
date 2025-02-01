using UnityEngine;

namespace DesignPatterns.OCP
{ 
    public class UnrefactoredAreaCalculator 
    {
        
        public float GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }

        public float GetCircleArea(Circle circle)
        {
            return circle.Radius * circle.Radius * Mathf.PI;
        }
        
        public float GetSquareArea(Square square)
        {
            return square.SideLength * square.SideLength;
        }

    }

    public class Rectangle
    {
        public float Height;
        public float Width;
        
    }

    public class Circle
    {
        public float Radius;
    }

    public class Square
    {
        public float SideLength;
    }
}  
