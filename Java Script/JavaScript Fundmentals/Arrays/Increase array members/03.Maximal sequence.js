var i,
    recurringElement,
    result = [],
    currentMax = 1,
    max = currentMax,
    arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    len = arr.length;

console.log('\nTask 3: Write a script that finds the maximal sequence of equal elements in an array.');

for (i = 0; i < len - 1; i += 1) {
    if (arr[i] === arr[i + 1]) {
        currentMax += 1;
        if (currentMax > max) {
            max = currentMax;
            recurringElement = arr[i];
        }
    } else {
        currentMax = 1;
    }
}

for (i = 0; i < max; i += 1) {
    result[i] = recurringElement;
}

console.log('result: ' + result);