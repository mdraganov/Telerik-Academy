console.log('Task 1: Write a function for creating persons. Each person must have firstname, lastname, age and gender (true is female, false is male) Generate an array with ten person with different names, ages and genders.');

var arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
    fnames = ['Joy', 'Nicky', 'Aleks', 'Grui', 'Jay', 'Zoy', 'Nelli', 'Pol', 'Gol', 'Sol'],
    lnames = ['Peterson', 'Johnson', 'Bolton', 'Clapton', 'Pikachu', 'Winfrey', 'Spencer', 'Cloppenburg', 'Heisenburg', 'West'];

var people = arr.map(function (_, i) {
    return { fname: fnames[i], lname: lnames[i], age: Math.random() * 100 | 0, gender: !(Math.round(Math.random())) };
});

console.log(people);
