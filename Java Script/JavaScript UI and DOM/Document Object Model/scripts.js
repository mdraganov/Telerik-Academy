function colorDivsWithSelectorAll() {
    var divs = document.querySelectorAll('div > div');

    for (var i = 0, len = divs.length; i < len; i++) {
        divs[i].style.borderColor = 'red';
        divs[i].style.borderWidth = '1px';
        divs[i].style.borderStyle = 'solid';
    }
}

function colorDivsWithGetElements() {
    var divs = document.getElementsByTagName('div');

    for (var i = 0, len = divs.length; i < len; i++) {
        if (divs[i].parentElement instanceof HTMLDivElement) {
            divs[i].style.borderColor = 'green';
            divs[i].style.borderWidth = '1px';
            divs[i].style.borderStyle = 'solid';
        }
    }
}

function printInputValue() {
    var i,
        len,
        val,
        parentDiv,
        spanElement;

    parentDiv = document.getElementById('inputTask2').parentElement;
    spanElement = parentDiv.getElementsByTagName('span')[0];
    if (spanElement) {
        parentDiv.removeChild(spanElement);
    }
    
    val = document.getElementById('inputTask2').value;

    console.log(val);
    document.getElementById('inputTask2').parentElement.innerHTML += '<span>' + val + '</span>';
}

function setBackgroundColor() {
    document.body.style.backgroundColor = document.getElementById('inputTask3').value;
}