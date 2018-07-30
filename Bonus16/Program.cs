using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{

    class Program
    {

        public Car CreateDefault()
        {

            return new Car();

        }

        public Car CreateCustom()
        {

            int intMake;
            int intModel;
            int intYear;
            double doublePrice;

            #region Make
            Console.WriteLine("Please choose a manufacturer: ");
            Console.WriteLine("1. Ford");
            Console.WriteLine("2. Dodge");
            Console.WriteLine("3. Chevy");
            Console.WriteLine("4. Honda");
            Console.WriteLine("5. Toyota");
            Console.WriteLine("6. Mercedes Benz");
            Console.WriteLine("Please enter your choice as a number.");

            do
            {

                try
                {

                    intMake = int.Parse(Console.ReadLine());

                    if (intMake > 0 && intMake < 7)
                    {

                        break;

                    }
                    else
                    {

                        Console.WriteLine($"Your entry of {intMake} is not between the numbers 1 and 6, now is it?");

                    }

                }
                catch(FormatException)
                {

                    Console.WriteLine("Please enter a N U M B E R");

                }
                catch(Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Basically, you can't choose a number 1-6");

                }

            } while (true);

            #endregion

            #region Model

            if (intMake == 1)           //Ford
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Mustang");
                Console.WriteLine("2. Focus");
                Console.WriteLine("3. Prius");
                Console.WriteLine("4. F-150");
                Console.WriteLine("5. Thundercougarfalconbird");
                Console.WriteLine("Please enter your selection as a number.");

            }
            else if (intMake == 2)      //Dodge
            {



            }
            else if (intMake == 3)      //Chevy
            {



            }
            else if (intMake == 4)      //Honda
            {



            }
            else if (intMake == 5)      //Toyota
            {



            }
            else if (intMake == 6)      //Benz
            {



            }
            else
            {

                Console.WriteLine("Here's another catch all! " + intMake);
                Console.WriteLine("Defaulting car!");
                return CreateDefault();

            }

            #endregion

        }

        static void Main(string[] args)
        {

            

        }

    }

}
