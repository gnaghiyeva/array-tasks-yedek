const array = [3, 5, 1, 7, 9];
let cem = 0;
let ededi_orta;
for (let i = 0; i < array.length; i++) {
    cem += array[i];
}

ededi_orta = cem / array.length;
console.log("ededi orta = " + ededi_orta);