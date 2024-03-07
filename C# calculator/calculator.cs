using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

    class Program   
    {
        static void Main(string[] args)
        {   
            int num1; 
            int num2;
            int result;
            string answer;

            Console.WriteLine("Sup Loser, Welcome to Tauriqs Calculator. GG");
            Console.WriteLine("Enter a  number already!!!!!:");

            num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the second Nowwwww!!!!!")

            num2 =  Convert.ToInt32(Console.ReadLine( ));

            Console.WriteLine("What op you gonna use? + - * / ");
            
            answer = Console.ReadLine();

            if(answer == '+')
            {
                result=num1+num2,
            }
            else if (answer == "-") 
            {
                 result=num1-num2;
            }
            else if  (answer=="*")  
            {   
                result=num1*num2;
            }
            else if (answer=="/")   
            {
                result=num1/num2;
            }

            System.Console.WriteLine('The result is obviously' + result);
            System.Console.WriteLine('Ayyyyy you looking kinda shhhhmaaaart! GG ;)');


            Console.ReadKey();
        }
    }