using Ass_1_OOP.Use_data_Type;
using System.ComponentModel;

namespace Ass_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{

            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}   



            #endregion


            #region 2 - Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Enter seasons : ");
            //string? String = Console.ReadLine();

            //if (String is not null && Enum.TryParse(String , out Seas_on season))
            //{
            //    switch (season)
            //    {
            //        case Seas_on.Spring:
            //            Console.WriteLine("spring march to may ");
            //            break;
            //        case Seas_on.Summer:
            //            Console.WriteLine("summer june to august ");
            //            break;
            //        case Seas_on.Winter:
            //            Console.WriteLine("winter December to February");
            //            break;
            //        case Seas_on.Autumn:
            //            Console.WriteLine(", autumn September to November ");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Season");
            //            break;



            //    }
            //}





            #endregion


            #region   3 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable


            //Permission user01 = Permission.Read ^ Permission.Delete;
            //Console.WriteLine(user01);

            //if ((user01 & Permission.write) == Permission.write)
            //{
            //    Console.WriteLine("User has permission of write");
            //}
            //else
            //    user01 ^= Permission.write;




            //Console.WriteLine(user01);



            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.Write("Enter The color");
            //string? color = Console.ReadLine();

            //if (color is not null && Enum.TryParse(color , out colors c) )
            //{
            //    switch (c)
            //    {
            //        case colors.Blue:
            //        case colors.Green:
            //        case colors.Red:
            //            Console.WriteLine(" It the primary color");
            //            break;
            //        default:
            //            Console.WriteLine("It is not primary color ");
            //            break;

            //    }
            //}

            #endregion


        }


    }
}
