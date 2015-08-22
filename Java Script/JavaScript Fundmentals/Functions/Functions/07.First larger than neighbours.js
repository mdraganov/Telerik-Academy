function findBiggerNeighbour() {
    var i,
        inputArray = document.getElementById('numbersArray3').value.split(' '),
        len = inputArray.length;

    for (i = 0; i < len; i += 1) {
        if (checkNeighbours(inputArray, i)) {
            document.getElementById('result7').innerHTML = i;
            return;
        }
    }

    document.getElementById('result7').innerHTML = -1;
}
