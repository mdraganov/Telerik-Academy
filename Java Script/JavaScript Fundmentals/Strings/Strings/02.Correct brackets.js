console.log('\nTask 2: Write a JavaScript function to check if in a given expression the brackets are put correctly.');

function checkBrackets(str) {
    var i,
        length,
        leftBr = 0,
        rightBr = 0;

    for (i = 0, length = str.length; i < length; i += 1) {
        if (str[i] === '(') leftBr += 1;
        else if (str[i] === ')') rightBr += 1;

        if (rightBr > leftBr) return false;
    }

    return leftBr === rightBr;
}

console.log('(a+b)): ' + checkBrackets('(a+b))'));
console.log(')(a+b)): ' + checkBrackets(')(a+b))'));
console.log('((a+b)/5-d): ' + checkBrackets('((a+b)/5-d)'));
