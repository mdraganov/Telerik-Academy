/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		
		function listBooks(args) {
			var result = [];
			
			if (!args) {
				return books;				
			}
			
			if (args.category) {
				for (var ind in books) {
					if (books[ind].category === args.category) {
						result.push(books[ind]);
					}
				}
				
				return result;
			}
			
			if (args.author) {
				for (var ind in books) {
					if (books[ind].author === args.author) {
						result.push(books[ind]);
					}
				}
				
				return result;
			}
		}

		function addBook(book) {
			var categoryInx;				
			book.ID = books.length + 2;
			books.push(book);
			
			categoryInx = categories.indexOf(book.category);
			
			if (categoryInx < 0) {
				categories.push(book.category);
			}			
			return book;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}

var func = solve();

func.books.add({title: 'SomeTitle', author: 'SomeAuthor', isbn: 'someISBN', category: 'someCategory'});
func.books.add({title: 'OtherTitle', author: 'OtherAuthor', isbn: 'OtherISBN', category: 'otherCategory'});
console.log(func.books.list());
console.log(func.categories.list());

module.exports = solve;
