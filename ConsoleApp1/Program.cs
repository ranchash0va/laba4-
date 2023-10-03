
public class Vector3
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Vector3 operator *(Vector3 a, float k)
    {
        return new Vector3(a.X * k, a.Y * k, a.Z * k);
    }

    public static Vector3 operator *(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static float DotProduct(Vector3 a, Vector3 b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public static Vector3 CrossProduct(Vector3 a, Vector3 b)
    {
        return new Vector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
    }

    public bool Equals(Vector3 other)
    {
        return X == other.X && Y == other.Y && Z == other.Z;
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

    public float Length()
    {
        return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public Vector3 Normalize()
    {
        float length = this.Length();
        if (length == 0)
        {
            return new Vector3(0, 0, 0);
        }
        return new Vector3(X / length, Y / length, Z / length);
    }

    public static bool AreCollinear(Vector3 a, Vector3 b)
    {

        if (b.X != 0)
        {
            return a.X / b.X == a.Y / b.Y && a.X / b.X == a.Z / b.Z;
        }
        else if (b.Y != 0)
        {
            return a.Y / b.Y == a.X / b.X && a.Y / b.Y == a.Z / b.Z;
        }
        else if (b.Z != 0)
        {
            return a.Z / b.Z == a.X / b.X && a.Z / b.Z == a.Y / b.Y;
        }
        else
        {

            return false;
        }
    }
}

namespace DL4
{
    class Program
    {
        static void Main()
        {
            // Creation of vectors
            Vector3 a = new Vector3(1, 2, 3);
            Vector3 b = new Vector3(4, 5, 6);

            // Output of original vectors
            Console.WriteLine("Original Vectors:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Addition of vectors
            Vector3 c = a + b;
            Console.WriteLine("Addition of Vectors:");
            Console.WriteLine("a + b = " + c);

            // Subtraction of vectors
            Vector3 d = a - b;
            Console.WriteLine("Subtraction of Vectors:");
            Console.WriteLine("a - b = " + d);

            // Multiplication of a vector by a scalar
            Vector3 e = a * 2.0f;
            Console.WriteLine("Multiplication of a Vector by a Scalar:");
            Console.WriteLine("a * 2 = " + e);

            // Dot product of vectors
            float f = Vector3.DotProduct(a, b);
            Console.WriteLine("Dot Product of Vectors:");
            Console.WriteLine("a ⋅ b = " + f);

            // Cross product of vectors
            Vector3 g = Vector3.CrossProduct(a, b);
            Console.WriteLine("Cross Product of Vectors:");
            Console.WriteLine("a × b = " + g);

            // Equality check of vectors
            bool h = a.Equals(b);
            Console.WriteLine("Equality Check of Vectors:");
            Console.WriteLine("a == b = " + h);

            // Length of a vector
            float i = a.Length();
            Console.WriteLine("Length of Vector a:");
            Console.WriteLine("|a| = " + i);

            // Normalization of a vector
            Vector3 j = a.Normalize();
            Console.WriteLine("Normalization of Vector a:");
            Console.WriteLine("Normalized a = " + j);

            
Console.WriteLine("\n\n=================================== ");
            // Check if vectors are collinear
            bool areCollinear = Vector3.AreCollinear(a, b);
            Console.WriteLine("Collinearity Check:");
            Console.WriteLine("a and b are collinear: " + areCollinear);

            // Additional operation
            Vector3 cAdditional = (a + a) * b;
            Console.WriteLine("с = (a + a) * b = " + cAdditional);

            Vector3 dAdditional = a * b;
            Console.WriteLine("d = a * b = " + dAdditional);
        }
    }
}