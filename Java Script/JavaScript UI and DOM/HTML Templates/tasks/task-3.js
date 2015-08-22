///<reference path="../node_modules/jquery/dist/jquery.js" />

function solve() {
    return function () {
        $.fn.listview = function (data) {
            var i,
                html = $('#' + $(this).attr('data-template')).html(),
                template = handlebars.compile(html);

            for (i = 0; i < data.length; i += 1) {
                $('#' + $(this).attr('id')).append(template(data[i]));
            }

            return this;
        };
    };
}

module.exports = solve;