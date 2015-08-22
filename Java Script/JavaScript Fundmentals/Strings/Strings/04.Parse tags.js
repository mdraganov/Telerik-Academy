console.log('\nTask 4: You are given a text. Write a function that changes the text in all regions: \n<upcase>text</upcase> to uppercase.\n<lowcase>text</lowcase> to lowercase\n<mixcase>text</mixcase> to mix casing(random)');

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.',
    result = text;

function parseTags(input) {
    var i,
        length;

    for (i = 0, length = input.length; i < length; i += 1) {
        if (input[i] === '<') {
            switch (input[i + 1].toLowerCase()) {
                case 'u': upcase(input, i); break;
                case 'l': lowcase(input, i); break;
                case 'm': mixcase(input, i); break;
                default:
            }
        }
    }
}

function upcase(textinput, ind) {
    var closingTagIndex = textinput.indexOf('</u', ind + 1),
        toReplace = '<upcase>' + textinput.substring(ind + 8, closingTagIndex) + '</upcase>',
        replacement = textinput.substring(ind + 8, closingTagIndex).toUpperCase();

    result = result.replace(toReplace, replacement);
}

function lowcase(textinput, ind) {
    var closingTagIndex = textinput.indexOf('</l', ind + 1),
        toReplace = '<lowcase>' + textinput.substring(ind + 9, closingTagIndex) + '</lowcase>',
        replacement = textinput.substring(ind + 9, closingTagIndex).toLowerCase();

    result = result.replace(toReplace, replacement);
}

function mixcase(textinput, ind) {
    var i,
        length,
        replacement,
        closingTagIndex = textinput.indexOf('</m', ind + 1),
        toReplace = '<mixcase>' + textinput.substring(ind + 9, closingTagIndex) + '</mixcase>',
        replacementArr = textinput.substring(ind + 9, closingTagIndex).split('');

    for (i = 0, length = replacementArr.length; i < length; i += 1) {
        if (Math.round(Math.random())) replacementArr[i] = replacementArr[i].toUpperCase();
    }

    replacement = replacementArr.join('');

    result = result.replace(toReplace, replacement);
}

console.log('\n' + text);
parseTags(text);
console.log('result: ');
console.log(result);
