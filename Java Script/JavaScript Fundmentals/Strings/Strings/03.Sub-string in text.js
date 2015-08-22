console.log('\nTask 3:Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).');

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var result = text.match(/in/gi);

console.log(text);
console.log('resutlt: ' + result.length);



