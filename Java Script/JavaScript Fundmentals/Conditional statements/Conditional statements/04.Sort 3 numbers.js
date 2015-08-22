function sort3() {
    var a = document.getElementById('first-num4').value * 1,
        b = document.getElementById('second-num4').value * 1,
        c = document.getElementById('third-num4').value * 1,
        biggest = a,
        bigger = b,
        last = c;

    if (b > a) {
        biggest = b;
        bigger = a;

        if (c > b) {
            biggest = c;
            bigger = b;
            last = a;
        } else if (c > a) {
            bigger = c;
            last = a;
        }
    } else {
        if (c > a) {
            biggest = c;
            bigger = a;
            last = b;
        } else if (c > b) {
            bigger = c;
            last = b;
        }
    }

    document.getElementById('answer4').innerHTML = biggest + ' ' + bigger + ' ' + last;
}