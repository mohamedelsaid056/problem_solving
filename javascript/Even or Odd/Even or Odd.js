function CheckOddOrEven(number) {
  if (number % 2 == 0) {
    return "Even";
  } else {
    return "Odd";
  }
}

alert("enter a number to check if it is even or odd");
let number = prompt("Enter a number");

while (isNaN(number) || number == null || number == "") {
  alert("Please enter a valid number");
  number = prompt("Enter a number");
}

let result = CheckOddOrEven(number);
alert("The number is " + result);
