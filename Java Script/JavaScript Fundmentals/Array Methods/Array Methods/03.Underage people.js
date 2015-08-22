console.log('\nTask 3: Write a function that prints all underaged persons of an array of person Use Array#filter and Array#forEachUse only array methods and no regular loops (for, while)');

var arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
    fnames = ['Joy', 'Nicky', 'Aleks', 'Grui', 'Jay', 'Zoy', 'Nelli', 'Pol', 'Gol', 'Sol'],
    lnames = ['Peterson', 'Johnson', 'Bolton', 'Clapton', 'Pikachu', 'Winfrey', 'Spencer', 'Cloppenburg', 'Heisenburg', 'West'];

var people = arr.map(function (_, i) {
    return { fname: fnames[i], lname: lnames[i], age: Math.random() * 100 | 0, gender: !(Math.round(Math.random())) };
});

people.filter(function (person) {
    return person.age < 18;
}).forEach(function (person) {
    console.log(person);
})