(function () {
    function sumArr(arr) {
        var i,
            currentElement,
            length, 
            sum = 0;

        if (arguments.length === 0) throw 'No Arguments Error';

        if (arr.length === 0) return null;

        length = arr.length;

        for (i = 0; i < length; i += 1) {
            currentElement = +arr[i];
            if (isNaN(currentElement)) throw 'Element NaN Error';
            sum += currentElement;
        }

        return sum;
    }

    console.log(sumArr([1, 2, '2']));
}());

