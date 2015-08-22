function findRoots(a, b, c) {
    var a = document.getElementById('first-coeff').value * 1,
        b = document.getElementById('second-coeff').value * 1,
        c = document.getElementById('third-coeff').value * 1,
        discriminant = b * b - 4 * a * c,
        result1,
        result2;

    if (discriminant < 0) {
        document.getElementById('answer6').innerHTML = 'no real roots';
    } else if (discriminant === 0) {
        result1 = -b / (2 * a);
        document.getElementById('answer6').innerHTML = 'x1=x2=' + result1;
    } else {
        result1 = (-b - Math.sqrt(discriminant)) / (2 * a);
        result2 = (-b + Math.sqrt(discriminant)) / (2 * a);

        document.getElementById('answer6').innerHTML = 'x1=' + result1 + '; ' + 'x2=' + result2;
    }
}