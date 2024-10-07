let num1, num2;

// Function to get valid numbers from the user
function getValidNumbers() {
  while (true) {
    num1 = Number(prompt("Enter 1st number: "));
    num2 = Number(prompt("Enter 2nd number: "));

    if (isNaN(num1) || isNaN(num2)) {
      alert("Please enter valid numbers");
    } else {
      break;
    }
  }
}

// Call the function to get numbers
getValidNumbers();

num1 > num2 ? alert(`${num1} is greater`) : alert(`${num2} is greater`);
