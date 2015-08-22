console.log('\nTask 6: Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.');

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

function getContent(input) {
    return input.replace(/<[^>]*>/g, '');
}
console.log(html);
console.log(getContent(html));