function greatest() {
    var a = document.getElementById('first-num7').value * 1,
        b = document.getElementById('second-num7').value * 1,
        c = document.getElementById('third-num7').value * 1,
        d = document.getElementById('fourth-num7').value * 1,
        e = document.getElementById('fifth-num7').value * 1,
        greatest = a;

    if (b > greatest) greatest = b;
    if (c > greatest) greatest = c;
    if (d > greatest) greatest = d;
    if (e > greatest) greatest = e;

    document.getElementById('answer7').innerHTML = greatest;
}