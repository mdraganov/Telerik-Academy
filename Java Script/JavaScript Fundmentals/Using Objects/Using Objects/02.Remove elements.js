console.log('\nTask 2: Write a function that removes all elements with a given value. Attach it to the array type. Read about prototype and how to attach methods.');

function Arr(arr) {
    this.arr = arr;
    this.remove = function (element) {
        var i,
            len = this.arr.length;

        for (i = 0; i < len; i += 1) {
            if (this.arr[i] === element) this.arr.splice(i, 1);
        }
    }
    this.toString = function () {
        var result = this.arr.join(', ');

        return result;
    }
}

console.log('var arr = 1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, \'1\'');
var arr = new Arr([1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1']);
arr.remove(1);
console.log('arr.remove(1)');
console.log(arr.toString());