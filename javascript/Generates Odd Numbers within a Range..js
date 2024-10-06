//Generates Odd Numbers within a Range
function oddNumbers(l, r) {
  let arr = [];
  for (const i = l; i <= r; i++) {
    if (i % 2 !== 0) {
      arr.push(i);
    }
  }
  return arr;
}

var oddnumber = oddNumbers(1, 10);

console.log(oddnumber);
