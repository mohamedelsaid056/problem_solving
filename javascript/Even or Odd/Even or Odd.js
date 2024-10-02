function CheckOddOrEven(number) {
  return number % 2 === 0 ? "Even" : "Odd"; // Simplified return statement
}

alert("Enter a number to check if it is even or odd");
let number;

do {
  number = prompt("Enter a number");
  if (isNaN(number) || number === null || number.trim() === "") {
    alert("Please enter a valid number");
  }
} while (isNaN(number) || number === null || number.trim() === "");

alert("The number is " + CheckOddOrEven(number));
