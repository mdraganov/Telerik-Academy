console.log('\nTask 4: Write a function that calculates the average age of all females, extracted from an array of persons Use Array#filter Use only array methods and no regular loops (for, while)');

var arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
    fnames = ['Joy', 'Nicky', 'Aleks', 'Grui', 'Jay', 'Zoy', 'Nelli', 'Pol', 'Gol', 'Sol'],
    lnames = ['Peterson', 'Johnson', 'Bolton', 'Clapton', 'Pikachu', 'Winfrey', 'Spencer', 'Cloppenburg', 'Heisenburg', 'West'];

var people = arr.map(function (_, i) {
    return { fname: fnames[i], lname: lnames[i], age: Math.random() * 100 | 0, gender: !(Math.round(Math.random())) };
});

var females = people.filter(function (person) {
    return person.gender;
});

var result = females.reduce(function (s, person) {
    return (s + person.age);
}, 0) / females.length;

console.log(people);
console.log('reminder* -true is for female, fales is for male');
console.log('Average female age is: ' + result);