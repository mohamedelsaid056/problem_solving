using System;
using System.Collections.Generic;
using System.Linq;
class program {
  static void Main() {

    
    // using for loop to generate odd numbers
    for (int i = 0; i <= 100; i++) {
      // i need odd number
      if (i % 2 != 0) {
        Console.WriteLine(i);
      }
    }

    //using another way in for loop 
    for(int i=1; i<=100; i+=2){
      Console.WriteLine(i);
    }

    //using while loop
    int j = 1;
    while (j <= 100) {
      Console.WriteLine(j);
      j += 2;
    }
   //using Enumerable.range 
   var number = Enumerable.Range(1, 100).Where(x => x % 2 != 0);

   foreach (var i in number)
   {
       Console.WriteLine(item);
   }
   //using static function
    var oddNumbers = GetOddNumbers(1, 100);
    console.WriteLine(oddNumbers);


  }
  //using static function 
  public static list<int> GetOddNumbers(int start, int end)
  {
    var numbers = new List<int>();
    for (int i = start; i <= end; i++)
    {
      if (i % 2 != 0)
      {
        numbers.Add(i);
      }
    }
    return numbers;
  }
}