console.log('\nTask 4: Write a function that checks if a given object contains a given property.');

function hasProperty(obj, proper) {
    for (var prop in obj) {
        if (prop === proper) return true;
    }

    return false;
}

var someObj = { something: 10, someOthreThing: 20 };

console.log('var someObj = { something: 10, someOthreThing: 20 }');
console.log('Has property: something? ' + hasProperty(someObj, 'something'));