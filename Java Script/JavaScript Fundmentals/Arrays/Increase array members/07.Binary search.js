var mid,
    element = 8,
    arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    min = 0,
    max = arr.length - 1,
    result = -1;

console.log('\nTask 7: Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.');

while (min <= max) {
    mid = Math.floor(min + (max - min) / 2);
    if (arr[mid] > element) {
        max = mid - 1;
    }
    else if (arr[mid] < element) {
        min = mid + 1;
    }
    else {
        result = mid;
        break;
    }
}

console.log('Index of element ' + element + ' is ' + result);