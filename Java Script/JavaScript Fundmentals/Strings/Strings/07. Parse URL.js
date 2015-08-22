console.log('\nTask 7: Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.');

var url = 'https://github.com/TelerikAcademy/JavaScript-Fundamentals/blob/master/11.%20Strings/README.md';

function parseURL(url) {
    var obj = {
        protocol: url.match(/[^:]*/)[0],
        server: url.match(/[^\/]*\.[^\/]*/)[0],
        resource: url.substr(url.match(/[^:]*/)[0].length + url.match(/[^\/]*\.[^\/]*/)[0].length + 3)
    };
    return obj;
}

console.log(parseURL(url));