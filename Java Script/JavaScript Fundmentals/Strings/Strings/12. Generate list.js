console.log('\nTask 12: Write a function that creates a HTML <ul> using a template for every HTML <li>. The source of the list should be an array of elements. Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.');

function generateList(people, template) {
    var resultHTML = '<ul>',
        i;
    for (i = 0; i < people.length; i += 1) {
        resultHTML += '<li>';
        resultHTML += template.replace('-{name}-', people[i]['name']).replace('-{age}-', people[i]['age']);
        resultHTML += '</li>';
    }
    return resultHTML + '</ul>';
}

var people = [{ name: 'Peter', age: 14 },
{ name: 'Ivan', age: 18 },
{ name: 'Asen', age: 29 }];

var template = '<strong>-{name}-</strong> <span>-{age}-</span>';
    
console.log(generateList(people, template));

