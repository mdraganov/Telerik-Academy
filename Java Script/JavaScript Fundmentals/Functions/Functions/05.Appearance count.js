function countAppearances() {
    var i,
        count = 0,
        inputArray = document.getElementById('numbersArray').value.split(' '),
        number = document.getElementById('num5').value,
        len = inputArray.length;

    for (i = 0; i < len; i += 1) {
        if (inputArray[i] == number) count += 1;
    }

    document.getElementById('result5').innerHTML = count;
    return count;
}

function testFunc() {
    var result;

    document.getElementById('numbersArray').value = '1 5 6 7 5 6 8 1 7 9 7';
    document.getElementById('num5').value = '1';

    result = countAppearances();

    if (result == 2) document.getElementById('result5').innerHTML = result + ' - It works!';
}