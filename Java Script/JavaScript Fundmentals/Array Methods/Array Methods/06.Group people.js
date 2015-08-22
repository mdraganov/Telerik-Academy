console.log('\nTask 6: Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object. Use Array#reduce. Use only array methods and no regular loops (for, while)');

var arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
    fnames = ['Joy', 'Nicky', 'Aleks', 'Grui', 'Jay', 'Zoy', 'Nelli', 'Pol', 'Gol', 'Sol'],
    lnames = ['Peterson', 'Johnson', 'Bolton', 'Clapton', 'Pikachu', 'Winfrey', 'Spencer', 'Cloppenburg', 'Heisenburg', 'West'];

var people = arr.map(function (_, i) {
    return { fname: fnames[i], lname: lnames[i], age: Math.random() * 100 | 0, gender: !(Math.round(Math.random())) };
});

var result = {};

people.reduce(function (_, person) {
    if (!result[person.fname[0]]) result[person.fname[0]] = [];

    result[person.fname[0]].push(person);
}, 0);

console.log(result);