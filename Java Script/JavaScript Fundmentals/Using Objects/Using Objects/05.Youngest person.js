console.log('\nTask 5: Write a function that finds the youngest person in a given array of people and prints his/hers full name. Each person has properties firstname, lastname and age.');

function findYoungest(personsArr) {
    var person,
        result = personsArr[0],
        minAge = +Infinity;

    for (person in personsArr) {
        if (personsArr[person].age < minAge) {
            minAge = personsArr[person].age;
            result = personsArr[person];
        }
    }

    return result.firstname + ' ' + result.lastname;
}

var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 82 }, 
  { firstname: 'Bay', lastname: 'Ivan', age: 91 },
  { firstname: 'Pesho', lastname: 'Peshev', age: 50 }
];

console.log('var people = [{ firstname : \'Gosho\', lastname: \'Petrov\', age: 82 },\n{ firstname: \'Bay\', lastname: \'Ivan\', age: 91 },\n{ firstname: \'Pesho\', lastname: \'Peshev\', age: 50 }];')
console.log('Youngest: ' + findYoungest(people));