function reverse() {
    var i,
        result = [],
        number = document.getElementById('num2').value,
        len = number.length;

    for (i = 0; i < len; i += 1) {
        result[len - i - 1] = number[i];
    }

    document.getElementById('result2').innerHTML = result.join('');
}