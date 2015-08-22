console.log('\nTask 6: Write a function that groups an array of people by age, first or last name. The function must return an associative array, with keys - the groups, and values - arrays with people in this groups');

function group(people, filter) {
    var i,
        groups = [],
        len = people.length;

    for (i = 0; i < len; i += 1) {
        if (!groups[people[i][filter]]) groups[people[i][filter]] = [];

        groups[people[i][filter]].push(people[i]);
    }

    return groups;
}

var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 82 },
  { firstname: 'Bay', lastname: 'Ivan', age: 91 },
  { firstname: 'Pesho', lastname: 'Peshev', age: 50 },
  { firstname: 'Gosho', lastname: 'Peshev', age: 82 },
  { firstname: 'Pesho', lastname: 'Petrov', age: 50 }
];

console.log('var people = [{ firstname: Gosho, lastname: Petrov, age: 82 },{ firstname: Bay, lastname: Ivan, age: 91 },{ firstname: Pesho, lastname: Peshev, age: 50 },{ firstname: Gosho, lastname: Peshev, age: 82 },{ firstname: Pesho, lastname: Petrov, age: 50 }];');
console.log(group(people, 'firstname'));
console.log(group(people, 'age'));
console.log(group(people, 'lastname'));
