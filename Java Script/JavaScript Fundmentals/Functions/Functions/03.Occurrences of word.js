function findWord() {
    var i,
        text = document.getElementById('text').value,
        word = document.getElementById('word').value,
        textArray = text.split(' '),
        len = textArray.length,
        result = [];

    for (i = 0; i < len; i += 1) {
        if (document.getElementById('caseInsensitive').checked) {
            word = word.toUpperCase();
            textArray[i] = textArray[i].toUpperCase();
        }

        if (textArray[i] == word) result.push(i);
    }

    if (result.length == 0) result = 'No matches';
    document.getElementById('result3').innerHTML = result;
}