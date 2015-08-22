(function () {
    function findPrimes(from, to) {
        var i,
            j,
            from,
            to,
            maxDevider,
            tempRange,
            isPrime,
            result = [];

        if (!from || !to) throw 'Arguments Missing Error';

        from = +from;
        to = +to;

        if (isNaN(from) || isNaN(to)) throw 'Arguments NaN Error';

        if (from > to) {
            tempRange = from;
            from = to;
            to = tempRange;
        }
        
        for (i = from; i <= to; i += 1) {
            maxDevider = Math.sqrt(i);
            isPrime = true;

            for (j = 2; j <= maxDevider; j += 1) {
                if (!(i % j)) isPrime = false;
            }

            if (isPrime) result.push(i);
        }

        return result;
    }

    console.log(findPrimes(5, 10));
}());