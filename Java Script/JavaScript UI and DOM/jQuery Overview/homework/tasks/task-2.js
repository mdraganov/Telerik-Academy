/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {
        var i,
            buttons = $(selector + ' .button');

        if (typeof selector !== 'string' || $(selector).length === 0) {
            throw {
                name: 'Invalid argument error',
                message: 'Parameter should be a valid selector'
            }
        }

        for (i = 0; i < buttons.length; i += 1) {
            $(buttons[i]).text('hide');
            $(buttons[i]).on('click', showContent);
        }

        function showContent() {
            var $this = $(this),
                $nextContent = $this.next();

            while ($nextContent && !$nextContent.hasClass('content')) {
                $nextContent = $nextContent.next();
            }

            if ($nextContent && $nextContent.css('display') === 'none') {
                $this.text('hide');
                $nextContent.css('display', '');
            } else if ($nextContent) {
                $this.text('show');
                $nextContent.css('display', 'none');
            }
        }
    };
};

module.exports = solve;