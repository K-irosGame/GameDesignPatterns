using UnityEngine;



namespace DesignPatterns.BestPractice.OCP
{
    public  abstract class Shape : MonoBehaviour
    {
        public abstract float CalculateArea();
    }

    public class Rectangle : Shape
    {
        public float Height;
        public float Width;

        public override float CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public float Radius;

        public override float CalculateArea()
        {
            return Radius * Radius * Mathf.PI;
        }
    }

    public class Square : Shape
    {
        public float SideLength;

        public override float CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
