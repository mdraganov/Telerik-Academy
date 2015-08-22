function numberToWords() {
    var num = document.getElementById('number').value * 1,
        result = '',
        ones = num % 10,
        tens = Math.floor(num / 10) % 10,
        hundreds = Math.floor(num / 100) % 10;

    if (hundreds) result += getOnes(hundreds) + ' hundred';
    
    if (hundreds && (ones || tens)) result += ' and ';

    if (tens === 1 && ones) {
        result += getTeens(ones);
        document.getElementById('answer8').innerHTML = result;
        return;
    }

    if (tens && ones) result += getTens(tens) + '-' + getOnes(ones);
    else if (tens) result += getTens(tens);
    else if (ones) result += getOnes(ones);

    if (!num) result = 'zero';

    document.getElementById('answer8').innerHTML = result;
    return;
}


function getOnes(digits) {
    var result;

    switch (digits) {
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
    }

    return result;
}

function getTeens(digits) {
    var result;

    switch (digits) {
        case 1: result = 'eleven'; break;
        case 2: result = 'twelve'; break;
        case 3: result = 'thirteen'; break;
        case 4: result = 'fourteen'; break;
        case 5: result = 'fifteen'; break;
        case 6: result = 'sixteen'; break;
        case 7: result = 'seventeen'; break;
        case 8: result = 'eightteen'; break;
        case 9: result = 'nineteen'; break;
    }

    return result;
}

function getTens(digits) {
    var result;

    switch (digits) {
        case 1: result = 'ten'; break;
        case 2: result = 'twenty'; break;
        case 3: result = 'thirty'; break;
        case 4: result = 'fourty'; break;
        case 5: result = 'fifty'; break;
        case 6: result = 'sixty'; break;
        case 7: result = 'seventy'; break;
        case 8: result = 'eightty'; break;
        case 9: result = 'ninety'; break;
    }

    return result;
}