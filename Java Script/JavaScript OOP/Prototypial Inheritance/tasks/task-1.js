/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {   
		var domElement = {           
      init: function(tag) {
        if (!/^[A-Za-z0-9]*$/.test(tag) || !tag || typeof tag !== 'string') {
          throw new Error('Invalid type name')
        }
        
        this.tag = tag;
        this.children = [];
        this.attributes = [];
        
        return this;  
      },
      appendChild: function(child) {
        child.parent = this;
        this.children.push(child);
        
        return this;
      },
      addAttribute: function(name, value) { 
        if (!/^[A-Za-z0-9\-]*$/.test(name) || !name) {
          throw new Error('Invalid type name')
        }
               
        for (var index = 0, length = this.attributes.length; index < length; index += 1) {
          if (this.attributes[index][0] === name) {
            this.attributes[index][1] = value;
            
            return this;
          }
        }       
               
        this.attributes.push([name, value]);
        
        return this;
      },
      removeAttribute: function (attribute) {
        var removeAt,
            index,
            length;
        
        for (index = 0, length = this.attributes.length; index < length; index += 1) {
          if (this.attributes[index][0] === attribute) {
            removeAt = index;
          }
        }
        
        if (removeAt === undefined) {
          throw new Error('Argument not found');
        }
        
        this.attributes.splice(removeAt, 1);
        
        return this;
      },     
      get innerHTML () {
        var result = [];
        
        result[0] = '<' + this.tag;
        
        if (this.attributes[0]) {
          var sortedAtr = this.attributes.sort();
          for (var attribute in this.attributes) {
            result.push(' ' + sortedAtr[attribute][0] + '=' + '"' + sortedAtr[attribute][1] + '"');            
          }
        }
        
        result.push('>');
        
        if (this.children[0]) {
          for (var child in this.children) {
            if (typeof this.children[child] === 'string') {
              result.push(this.children[child]);
            } else {              
              result.push(this.children[child].innerHTML);
            }            
          }    
        } else {
          result.push(this.content);
        }
        
        result.push('</' + this.tag + '>');
                
        return result.join('');
      },
      content: '',
      parent: ''
		};   
    
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;
