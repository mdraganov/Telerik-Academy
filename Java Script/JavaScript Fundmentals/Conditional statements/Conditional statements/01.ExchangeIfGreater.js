function exchangeIfGreater() {
    var a = document.getElementById('first-num').value * 1,
        b = document.getElementById('second-num').value * 1;

    if (a > b) document.getElementById('answer1').innerHTML = b + ' ' + a;
    else document.getElementById('answer1').innerHTML = a + ' ' + b;

    document.getElementById('first-num').value = '';
    document.getElementById('second-num').value = '';
}