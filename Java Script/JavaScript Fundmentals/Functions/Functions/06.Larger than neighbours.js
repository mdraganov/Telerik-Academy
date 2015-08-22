function checkNeighbours(arr, i) {
    var result,
        inputArray,
        position;

    if (arr == null) {
        inputArray = document.getElementById('numbersArray2').value.split(' '),
        position = +document.getElementById('num6').value;
    } else {
        inputArray = arr,
        position = i;
    }
    
    if ((position === 0 || position === inputArray.length) && arr == null) {
        result = 'Not enough neighbours!';
        document.getElementById('result6').innerHTML = result;
        return result;
    }

    if ((+inputArray[position] > +inputArray[position - 1]) && (+inputArray[position] > +inputArray[position + 1])) result = true;
    else result = false;

    if (arr == null) document.getElementById('result6').innerHTML = result;
    return result;
}