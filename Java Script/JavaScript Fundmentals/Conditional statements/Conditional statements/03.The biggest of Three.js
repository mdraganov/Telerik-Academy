function biggest() {
    var a = document.getElementById('first-num3').value * 1,
        b = document.getElementById('second-num3').value * 1,
        c = document.getElementById('third-num3').value * 1,
        biggest = a;

    if (b > biggest) biggest = b;
    if (c > biggest) biggest = c;

    document.getElementById('answer3').innerHTML = biggest;

    //document.getElementById('first-num3').value = '';
    //document.getElementById('second-num3').value = '';
    //document.getElementById('third-num3').value = '';
}