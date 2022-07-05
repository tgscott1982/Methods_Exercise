using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1;

public class Methods
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static float Divide(float num1, float num2)
    {
        return (num1 / num2);
    }

    public static int Sum(params int[] list)
    {
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum = sum + list[i];
        }
        return sum;
    }

}
