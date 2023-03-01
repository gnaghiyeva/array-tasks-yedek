const array = [3, 5, 1, 7, 9];
let cem = 0;
for (let i = 0; i < array.length; i++) {
   if (array[i] % 2 != 0) {
      cem += array[i];
   }
}

console.log("cem = " + cem);