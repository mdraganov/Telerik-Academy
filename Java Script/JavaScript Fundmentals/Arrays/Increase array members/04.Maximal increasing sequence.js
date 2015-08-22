var i,
    sequnceStart,
    result = [],
    currentMax = 1,
    max = currentMax,
    arr = [3, 2, 3, 4, 2, 2, 4, 5, 6, 7],
    len = arr.length;

console.log('\nTask 4: Write a script that finds the maximal increasing sequence in an array.');

for (i = 0; i < len - 1; i += 1) {
    if (arr[i] + 1 == arr[i + 1]) {
        currentMax += 1;
        if (currentMax > max) {
            max = currentMax;
            sequnceStart = arr[i - max + 2] ;
        }
    } else {
        currentMax = 1;
    }
}

for (i = 0; i < max; i += 1) {
    result[i] = sequnceStart;
    sequnceStart += 1;
}

console.log('result: ' + result);