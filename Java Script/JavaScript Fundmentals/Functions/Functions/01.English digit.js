function digitToWord(num) {
    var result;
    
    switch (num) {
        case 0: result = 'zero'; break;
        case 1: result = 'one'; break;
        case 2: result = 'two'; break;
        case 3: result = 'three'; break;
        case 4: result = 'four'; break;
        case 5: result = 'five'; break;
        case 6: result = 'six'; break;
        case 7: result = 'seven'; break;
        case 8: result = 'eight'; break;
        case 9: result = 'nine'; break;
        default: result = 'not a digit'; break;
    }

    return result;
}

function lastDigit() {
    var input = +document.getElementById('num').value,
        digit = input % 10,
        result = digitToWord(digit);

    document.getElementById('result1').innerHTML = result;
}