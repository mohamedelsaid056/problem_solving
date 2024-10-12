let a, b;

function swapTwoNumbers(a, b) {
  let temp;
  temp = a;
  a = b;
  b = temp;
}

function getValidNumber(promptMessage) {
  let num;
  do {
    num = prompt(promptMessage);
  } while (isNaN(num) || num.trim() === "");
  return parseFloat(num);
}

a = getValidNumber("Enter the first number: ");
b = getValidNumber("Enter the second number: ");

console.log("Before swapping: a= " + a + " b= " + b);

swapTwoNumbers(a, b);
console.log("After swapping: a= " + a + " b= " + b);
