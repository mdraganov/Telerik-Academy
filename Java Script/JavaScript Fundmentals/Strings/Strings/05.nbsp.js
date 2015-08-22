console.log('\nTask 5: Write a function that replaces non breaking white-spaces in a text with &nbsp;');

var text = 'We are LiVinG in a YELLOW SUBMARINE. We dOn\'T have anything else.';

function replaceNBSP(text) {
    return text.replace(/ /gi, '&nbsp');
}
console.log(text);
console.log('result: ' + replaceNBSP(text));