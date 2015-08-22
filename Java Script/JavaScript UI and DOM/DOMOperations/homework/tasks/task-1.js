/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

    return function (element, contents) {
        var parent,
            frag;

        if (typeof element === 'string') {
            parent = document.getElementById(element);
        } else {
            parent = element;
        }

        frag = document.createDocumentFragment();

        for (var i = 0; i < contents.length; i++) {
            var div = document.createElement('div');

            if (typeof contents[i] !== 'string' && isNaN(contents[i]) || Array.isArray(contents[i])) {
                throw 'Invalid argument';
            }

            div.innerHTML = contents[i];
            frag.appendChild(div);
        }

        parent.innerHTML = '';
        parent.appendChild(frag);
    };
};