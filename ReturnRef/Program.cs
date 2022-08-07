using System;

namespace EssentialCSharp.ReturnRef
{
    class Program
    {
        public static ref byte FindFirstRedEyePixel(byte[] image)
        {
            for (int counter = 0; counter < image.Length; counter++)
            {
                if (image[counter] == (byte)ConsoleColor.Red)
                {
                    return ref image[counter];
                }
            }
            throw new InvalidOperationException("No pixels are red.");
        }

        public static void Main()
        {
            byte[] image = new byte[254];

            int index = new Random().Next(0,image.Length - 1);

            image[index] = (byte)ConsoleColor.Red;
            System.Console.WriteLine($"image[{index}]={(ConsoleColor)image[index]}");

            ref byte redPixel = ref FindFirstRedEyePixel(image);
            redPixel = (byte)ConsoleColor.Green;
            System.Console.WriteLine($"image[{index}]={(ConsoleColor)image[redPixel]}");
        }
    }
}