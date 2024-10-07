using system ;
class program{
  public static void Main(){

    int num1,num2;

    while(true){
      console.WriteLine("Enter first number");
      if(int.TryParse(console.ReadLine(),out num1)){
        break;
      }
      else{
        console.WriteLine("Invalid input plz enter number again");
      }
    }
    while(true){
      console.WriteLine("Enter second number");
      if(int.TryParse(console.ReadLine(),out num2)){
        break;
      }
      else{
        console.WriteLine("Invalid input plz enter number again");
      }
    }



    num1>num2?console.WriteLine($"Greatest number is {num1}"):console.WriteLine($"Greatest number is {num2}");
  }
}