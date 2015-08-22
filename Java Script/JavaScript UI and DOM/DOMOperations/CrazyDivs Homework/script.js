var randomDivs = function () {
    var i,
        div = document.createElement('div'),
        wrapper = document.createElement('div'),
        fragment = document.createDocumentFragment();

    wrapper.id = 'wrapper';
    div.style.position = 'absolute';
    div.style.borderStyle = 'solid';
    div.innerHTML = '<strong>div</strong>';

    for (i = 0; i < randomize() ; i += 1) {
        var currentDiv = div.cloneNode(true),
            strongTag = currentDiv.getElementsByTagName('strong')[0];

        currentDiv.style.width = randomize(20, 100) + 'px';
        currentDiv.style.height = randomize(20, 100) + 'px';
        currentDiv.style.color = randomColor();
        currentDiv.style.background = randomColor();
        currentDiv.style.left = randomize(0, 1000) + 'px';
        currentDiv.style.top = randomize(0, 600) + 'px';
        currentDiv.style.borderColor = randomColor();
        currentDiv.style.borderWidth = randomize(1, 20) + 'px';
        currentDiv.style.borderRadius = randomize(1, 20) + 'px';
        strongTag.style.position = 'absolute';
        strongTag.style.top = '30%';
        strongTag.style.left = '30%';

        wrapper.appendChild(currentDiv);
    }

    fragment.appendChild(wrapper);
    document.body.insertBefore(fragment, document.body.firstChild);


}

randomDivs();

var rotateDivs = function () {
    var i,
        rotatingDivs,
        firstElementTopPosition,
        firstElementLeftPosition,
        wrap = document.getElementById('wrapper'),
        divs = wrap.getElementsByTagName('div'),
        rotatingDivsContainer = document.createElement('div'),
        numberOfRotatableDivs = 5;

    for (i = 0; i < numberOfRotatableDivs; i += 1) {
        rotatingDivsContainer.appendChild(divs[divs.length - 1 - i]);
    }
    document.body.appendChild(rotatingDivsContainer);

    rotatingDivs = rotatingDivsContainer.getElementsByTagName('div');

    setInterval(function () {
        var i;

        firstElementTopPosition = rotatingDivs[0].style.top;
        firstElementLeftPosition = rotatingDivs[0].style.left;

        for (i = 0; i < numberOfRotatableDivs - 1; i += 1) {
            rotatingDivs[i].style.top = rotatingDivs[i + 1].style.top;
            rotatingDivs[i].style.left = rotatingDivs[i + 1].style.left;
        }
        rotatingDivs[numberOfRotatableDivs - 1].style.top = firstElementTopPosition;
        rotatingDivs[numberOfRotatableDivs - 1].style.left = firstElementLeftPosition;
    }, 250);
}

rotateDivs();

//retuns random number between min inclusive and max exclusive, default values 10/100
function randomize(min, max) {
    var randomResult;

    max = max || 100;
    min = min || 10;
    randomResult = (Math.random() * (max - min) + min) | 0;

    return randomResult;
}

function randomColor() {
    var randomColor = 'rgba(' + randomize(0, 256) + ',' + randomize(0, 256) + ',' +
                                randomize(0, 256) + ',' + randomize(0, 256) + ')';

    return randomColor;
}





//var input1 = document.createElement('input');
//var input2 = document.createElement('input');
//var input3 = document.createElement('input');
//var btn = document.createElement('button');

//input1.type = 'text';
//input2.type = 'color';
//input3.type = 'color';
//btn.innerHTML = 'do work';
//btn.onclick = updateTextInputField;

//function updateTextInputField() {
//    input1.style.color = input2.value;
//    input1.style.backgroundColor = input3.value;
//}

//document.body.appendChild(input1);
//document.body.appendChild(input2);
//document.body.appendChild(input3);
//document.body.appendChild(btn);