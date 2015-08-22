/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    return function (selector, count) {
        var i,
            list = $('<ul />').addClass('items-list');

        if (!selector || typeof selector !== 'string') {
            throw {
                name: 'Invalid argument error',
                message: 'Selector should be a string'
            }
        }

        if (!count || isNaN(count) || count < 1) {
            throw {
                name: 'Invalid argument error',
                message: 'Number should be bigger than 0'
            }
        }

        for (i = 0; i < count; i += 1) {
            $('<li />').appendTo(list).text('List item #' + i).addClass('list-item');
        }

        $(selector).append(list);
    };
};

module.exports = solve;