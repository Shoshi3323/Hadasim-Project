using System;

namespace TWITTER1
{
    class Program
    {

        static double Pythagorean(double Height,double Width)
        {
            double side1, side2, hypotenuse;

            side1 = Height;

            side2 = Width;

            //hypotenuse - היתר של המשולש
            hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            double Scope = Width + (hypotenuse * 2);
            return Scope;
        }
        static void Main(string[] args)
        {



            int optian = 0;
            //כל עוד לא נבחר שלוש תחזיר אותי לראשי
            while (optian != 3)
            {
                //הכנס בחירת מספר
                Console.WriteLine("Hellow!\nplease enter your optain:\n 1 - rectangle tower\n 2 - triangular tower");
                optian = int.Parse(Console.ReadLine());
                if (optian == 3)
                {
                    break;
                }

                if (optian == 1)
                {
                    //1 בנין מלבן
                    Console.WriteLine("rectangle tower\n Enter height");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter width");
                    double width = double.Parse(Console.ReadLine());
                    if (height - width > 5 || width - height > 5)
                    {
                        Console.WriteLine("The area of the tower: " + (height * width));
                    }
                    else
                    {

                        Console.WriteLine("The perimeter of the tower: " + (height * 2 + width * 2));
                    }

                }
                // 2- בנין משולש
                else if (optian == 2)
                {
                    Console.WriteLine("triangular tower\n Enter height:");
                    double height2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter width:");
                    double width2 = double.Parse(Console.ReadLine());
                    //בחר אופציה של הדפסה
                    Console.WriteLine(" Choose your answer:\n1 - The perimeter of the tower\n 2 - The tower print");
                    int answer = int.Parse(Console.ReadLine());
                    //היקף המשולש
                    if (answer == 1)
                    {
                        double scope = Pythagorean(height2, width2);
                        Console.WriteLine("The Scope of the tower:"+scope);
                    }
                    //הדפסת המשולש
                    else if (answer == 2)
                    {
                        int width3 = Convert.ToInt32(width2);
                        int height3 = Convert.ToInt32(height2);
                        //כמות מספרים אי זוגיים
                        int num1 = ((width3 - 1)-2) / 2;
                        //מס שורות מכל מספר
                        int num2 = (height3 - 2) / num1;
                        //מס שורות מס 3
                        int num3 = num2 + (height3 - 2)% num1;
                        //הדפסת כל השאר
                        int num4 = width3 - (2 + num3);
                        
                        int n = Convert.ToInt32((width2 - 1) / 2);
                        char space = ' ';
                        string duplicatedChars = new string(space, n);
                        Console.Write(duplicatedChars);
                        Console.WriteLine("*");
                        int n2 = n - 1;
                        for (int i = 0; i < num3; i++)
                        {
                            string duplicatedChars2 = new string(space, n2);
                            Console.Write(duplicatedChars2);
                            Console.Write("***");
                            Console.WriteLine();
                        }
                       
                        int num5 = 5;
                        char asterisk = '*';
                        for (int j = 0; j < (num1-1); j++)
                        {
                        
                            for (int l = 0; l < num2; l++)
                            {
                                string duplicatedChars3 = new string(space, (n2 - 1));
                                Console.Write(duplicatedChars3);
                                string printnum = new string(asterisk, num5);
                                Console.Write(printnum);
                                Console.WriteLine();

                            }

                            n2--;
                            num5 += 2;
                        }
                       
                        string printnumlatest = new string(asterisk, width3);
                        Console.WriteLine(printnumlatest);


                    }
                }
                else
                {
                    Console.WriteLine("Eror! Invalid input\nenter your optain again:\n 1 - rectangle tower\n 2 - triangular tower");

                }


            }



        }
    }
}
   