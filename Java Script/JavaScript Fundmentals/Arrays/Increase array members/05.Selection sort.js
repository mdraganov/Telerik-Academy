var left,
    right,
    tmp,
    arr = [8, 12, 3, 4, 5, 2, 11, 13, 7, 4, 15, 14, 12, 8, 1],
    len = arr.length;

console.log('\nTask 5: Write a script to sort an array. Use the selection sort algorithm.');

for (left = 0; left < len; left++) {
    for (right = left + 1; right < len; right++) {
        if (arr[left] > arr[right]) {
            tmp = arr[right];
            arr[right] = arr[left];
            arr[left] = tmp;
        }
    }
}

console.log('sorted: ' + arr);

