/*------------------------------------------------------------------------------
*                      HTBLA-Leonding / Class: 3ACIF                           
*------------------------------------------------------------------------------
*                      Jan Ritt                                                
*------------------------------------------------------------------------------
*  Description:  The program reads in numbers while no 0 was inputted          
*                it outputs the sum, average and the highest number read in
*------------------------------------------------------------------------------
*/
using System;
using System.Text;

namespace Zahlenstatistik
{
  class Program
  {
    static void Main()
    {
      int input;
      int sum = 0;
      double average = 1;
      int maxValue = 1;
      int numberOfInputs = 1;

      /* INTRODUCTION */
      Console.Write("\n Zahlenstatistik ");
      Console.Write("\n=================\n");

      /* LOOP */
      do
      {
        Console.Write($"Bitte geben sie die {numberOfInputs}. Ganzzahl ein  (0 = Beenden):  ");
        input = Convert.ToInt32(Console.ReadLine());
        /// safe input as maxValue 
        if (input >= maxValue)
        {
          maxValue = input;
        }
        /// calculate sum 
        sum = sum + input;
        /// calculate average
        if (input != 0)
        {
          average = (double)sum / numberOfInputs;
        }
        /// elaborate input counter
        numberOfInputs++;
      } while (input != 0);

      /* OUTPUT */
      /// abort condition
      if ((numberOfInputs == 2) && (input == 0))
      {
        sum = 0;
        average = 0;
        maxValue = 0;
        Console.Write("\n" +
                     " Es wurden keine Zahlen eingegeben\n");
      }
      /// normal output
      else
      {
        Console.Write($" Summe:  {sum} \n" +
          $" Größter Wert: {maxValue} \n" +
          " Durchschnitt: " + average.ToString("0.00"));
      }
      ///  EXIT PROMPT
      Console.Write("\n══════════════════════════════════\n" +
                   " Beenden mit beliebiger Taste ...  ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
