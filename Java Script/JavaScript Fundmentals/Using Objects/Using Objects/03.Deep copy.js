console.log('\nTask 3: Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.');

function deepCopy(obj) {
    var newObj = {};
    
    if (typeof (obj) !== Object) return obj;

    for (var prop in obj) {
        if (typeof (obj[prop]) === Object) newObj[prop] = deepCopy(obj[prop]);
        else newObj[prop] = obj[prop];
    }

    return newObj;
}

var someObj = { something: 10, someOthreThing: 20 };
var someOtherObj = deepCopy(someObj);
console.log('Original: ');
console.log(someObj);
console.log('Deep copy: ');
console.log(someOtherObj);