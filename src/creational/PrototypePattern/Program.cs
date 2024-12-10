using PrototypePattern;

/*
 *create a new document with a tag
 */

var tag = new Tag("Author", "John Doe");

var document = new Document("Prototype Pattern", "A brief description of the Prototype Pattern", tag);

/*
 *clone the document as a shallow copy
 * try to change the tag of the clone and see if it affects the original document
 */

var clone = document.Clone();

clone.Tag.Value = "Jane Doe";

Console.WriteLine("Original Document Tag: " + document.Tag.Value);
Console.WriteLine("Shallow Clone Document Tag: " + clone.Tag.Value);

/*
 *clone the document as a deep copy
 * try to change the tag of the clone and see if it affects the original document
 */

var deepClone = document.DeepClone();
deepClone.Tag.Value = "Ibrahim";

Console.WriteLine("Original Document Tag: " + document.Tag.Value);
Console.WriteLine("Deep Clone Document Tag: " + deepClone.Tag.Value);

// shallow copy
// value type fields are copied directly
// reference type fields are copied by reference

// deep copy
// value type fields are copied directly
// reference type fields are copied by value