var i,
    arr = new Array(20),
    len = arr.length;

console.log('\nTask 1: Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. \nPrint the obtained array on the console.');

for (i = 0; i < len; i += 1) {
    arr[i] = i * 5;
}

console.log(arr);