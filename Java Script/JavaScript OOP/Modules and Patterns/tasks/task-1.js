/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    function validateCourse(title, presentations) {
        var index,
            length;

        if (/^ .*|.* $|  /.test(title) || title.length < 1) {
            throw new Error('Course title does not match criterea!');
        }

        if (typeof presentations === 'undefined' || !presentations[0]) {
            throw new Error('Enter presentations!');
        }

        length = presentations.length;

        for (index = 0; index < length; index += 1) {
            if (/^ .*|.* $|  /.test(presentations[index]) || presentations[index].length < 1) {
                throw new Error('Presentation ' + (index + 1) + ' title does not match criterea!');
            }
        }
    }

    function validateStudent(names) {
        if (names.length !== 2) {
            throw new Error('Enter two names!');
        }

        if (!/^[A-Z][a-z]*/.test(names[0]) || !/^[A-Z][a-z]*/.test(names[1])) {
            throw new Error('Invalid student name!');
        }

    }

    var Course = {
        init: function (title, presentations) {
            this.presentations = presentations;
            this.students = [];

            validateCourse(title, presentations);

            return this;
        },
        addStudent: function (name) {
            var names = name.split(' '),
                student = {
                    firstname: names[0],
                    lastname: names[1],
                    id: this.students.length + 1,
                    homeworks: [],
                    score: 0,
                    finalScore: 0
                };

            validateStudent(names);

            this.students.push(student);

            return student.id;
        },
        getAllStudents: function () {
            var index,
                result = [],
                length = this.students.length;

            for (index = 0; index < length; index += 1) {
                result.push({
                    firstname: this.students[index].firstname,
                    lastname: this.students[index].lastname,
                    id: this.students[index].id
                });
            }

            return result;
        },
        submitHomework: function (studentID, homeworkID) {
            if (homeworkID > this.presentations.length ||
                studentID > this.students.length ||
                homeworkID < 1 ||
                studentID < 1) {
                throw new Error('Invalid ID!');
            }

            this.students[studentID - 1].homeworks.push(homeworkID);

            return this;
        },
        pushExamResults: function (results) {
            var index,
                studentFound,
                lengthSt = this.students.length;

            if (!results || !results[0]) {
                throw new Error('No arguments error!');
            }

            for (var res in results) {
                studentFound = false;

                if (isNaN(results[res].score)) {
                    throw new Error('Score is not a number!');
                }

                for (index = 0; index < lengthSt; index += 1) {
                    if (this.students[index].id === results[res].StudentID) {
                        if (this.students[index].score !== 0) {
                            throw new Error('Cheating student!');
                        }

                        this.students[index].score = results[res].score;
                        this.students[index].finalScore = this.students[index].score * 0.75 + this.students[index].homeworks.length * 0.25;
                        studentFound = true;
                        break;
                    }
                }

                if (!studentFound) {
                    throw new Error('Invalid student ID!');
                }
            }
        },
        getTopStudents: function () {
            var index,
                result = [],
                sortedStudents = this.students.sort(function (s1, s2) {
                    return s2.finalScore - s1.finalScore;
                });

            for (index = 0; index < 10; index += 1) {
                if (sortedStudents[index]) {
                    result[index] = sortedStudents[index];
                } else {
                    break;
                }
            }

            return result;
        }
    };

    return Course;
}

// var test = Object.create(solve()).init('some course', ['first ppt', 'second ppt']);
// test.addStudent('Pesho Peshev');
// test.addStudent('Gosho Goshev');
// test.addStudent('Pecho Penchev');
// test.submitHomework(1, 2).submitHomework(2, 1).pushExamResults([{StudentID: 1, score: 3}, {StudentID: 2, score: 5}]);
// console.log(test.getTopStudents());

module.exports = solve;
