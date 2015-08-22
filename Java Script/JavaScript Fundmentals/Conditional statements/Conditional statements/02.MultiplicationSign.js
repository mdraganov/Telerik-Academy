function sign() {
    var a = document.getElementById('first-num2').value * 1,
        b = document.getElementById('second-num2').value * 1,
        c = document.getElementById('third-num2').value * 1,
        tempSign;

    if ((a < 0 && b < 0) || (a > 0 && b > 0)) tempSign = 1;
    else if (a == 0 || b == 0) tempSign = 0;
    else tempSign = -1;

    if ((tempSign < 0 && c < 0) || (tempSign > 0 && c > 0)) document.getElementById('answer2').innerHTML = '+';
    else if (tempSign == 0 || c == 0) document.getElementById('answer2').innerHTML = '0';
    else document.getElementById('answer2').innerHTML = '-';

    //document.getElementById('first-num2').value = '';
    //document.getElementById('second-num2').value = '';
    //document.getElementById('third-num2').value = '';
}