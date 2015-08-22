///<reference path="../node_modules/jquery/dist/jquery.js" />

function solve() {
    return function (selector) {
        var $dropDown,
            $select = $(selector).hide(),
            $currentSelection = $('<div />', { 'class': 'current' }),
            $container = $('<div />').addClass('options-container').css('position', 'absolute').hide(),
            $options = $select.children();

        $currentSelection.attr('data-value', '').text($($options[0]).text()).on('click', function () {
            $currentSelection.text('Select a value');
            $container.show();
        });

        for (var i = 0; i < $options.length; i++) {
            $('<div />').appendTo($container)
            .addClass('dropdown-item')
            .text($($options[i]).text())
            .attr('data-value', $($options[i]).val())
            .attr('data-index', i)
            .on('click', function () {
                $container.hide();
                $select.val($(this).attr('data-value'));
                $currentSelection.text($(this).text()).attr('data-value', $(this).attr('data-value'));
            });
        }

        $dropDown = $('<div />').addClass('dropdown-list').append($select).append($currentSelection).append($container);
        $('body').append($dropDown);
    };
}

module.exports = solve;