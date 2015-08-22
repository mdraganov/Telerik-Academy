console.log('\nTask 5: Write a function that finds the youngest male person in a given array of people and prints his full name. Use only array methods and no regular loops (for, while). Use Array#find');

var arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1],
    fnames = ['Joy', 'Nicky', 'Aleks', 'Grui', 'Jay', 'Zoy', 'Nelli', 'Pol', 'Gol', 'Sol'],
    lnames = ['Peterson', 'Johnson', 'Bolton', 'Clapton', 'Pikachu', 'Winfrey', 'Spencer', 'Cloppenburg', 'Heisenburg', 'West'];

var people = arr.map(function (_, i) {
    return { fname: fnames[i], lname: lnames[i], age: Math.random() * 100 | 0, gender: !(Math.round(Math.random())) };
});

console.log(people);

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len;

        for (i = 0, len = this.length; i < len; i += 1) {
            if (callback(this[i], i, this)) return this[i];
        }
    }
}

var result = people.sort(function (person1, person2) {
    return person1.age - person2.age;
}).find(function (person) {
    return !person.gender;
});

console.log(result.fname + ' ' + result.lname);