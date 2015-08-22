var i,
    j,
    mostFrequent,
    currentMax = 1,
    max = currentMax,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    len = arr.length;

console.log('\nTask 6: Write a script that finds the most frequent number in an array.');

for (i = 0; i < len; i += 1) {
    if (arr[i] !== false) {
        for (j = i + 1; j < len; j += 1) {
            if (arr[i] === arr[j]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    mostFrequent = arr[i];
                }
                arr[j] = false;
            }
        }
    }

    currentMax = 1;
}

console.log('result: ' + mostFrequent + ' (' + max + ' times)');