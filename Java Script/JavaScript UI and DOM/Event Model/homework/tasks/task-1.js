/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
    return function (selector) {
        var i,
            parent,
            buttons;

        if (typeof selector === 'string') {
            parent = document.getElementById(selector);
        } else {
            parent = selector;
        }

        buttons = parent.querySelectorAll('.button');
        for (i = 0; i < buttons.length; i += 1) {
            buttons[i].innerHTML = 'hide';
            buttons[i].addEventListener('click', showHideContent);
        }

        function showHideContent(ev) {
            var clicked = ev.target,
                nextContent = clicked.nextElementSibling;

            while (nextContent && nextContent.className !== 'content') {
                nextContent = nextContent.nextElementSibling;
            }

            if (nextContent && nextContent.style.display === 'none') {
                ev.target.innerHTML = 'hide';
                nextContent.style.display = '';
            } else if (nextContent) {
                ev.target.innerHTML = 'show';
                nextContent.style.display = 'none';
            }
        }        
    };
};

module.exports = solve;