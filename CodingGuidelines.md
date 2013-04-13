# Note

This guidelines were adapted from [ASP.NET team's coding guidelines](http://aspnetwebstack.codeplex.com/wikipage?title=CodingConventions)

We are going to be refining this guidelines as the project goes along

# Coding Guidelines

The most important rule when contributing to a source code base – any source code, not just an open source project – is to keep the style consistent. Please observe the general rule to leave all the code looking consistent: that includes new files being consistent with the existing style. Any pull requests which include major reformatting of the source code or deviate dramatically from the normal style will be declined and asked to resubmit once they’re amended.

## Definitions

**Camel case** is a casing convention where the first letter is lower-case, words are not separated by any character but subsequent words have their first letters capitalized. Example: **thisIsCamelCased**. 

**Pascal case** is a casing convention where the first letter of each word is capitalized, and no separating character is included between words. Example: **ThisIsPascalCased**. 

## C# coding conventions

In general, we have striven to use a style which is compatible with the out-of-the-box defaults for Visual Studio. In particular, this means we use [Allman bracing style](http://en.wikipedia.org/wiki/Indent_style#Allman_style).

## Some other rules we follow:

- Private fields are prefixed with an underscore and camel-cased.
- Always include curly braces around blocks, even when they would be optional. 
- Using statements go at the top of the file, before the namespace declaration, with System directives first.  *(For Visual Studio 2012, turn on the setting at Tools, Options, Text Editor, C#, Advanced, Organize Usings, Place 'System' directives first when sorting usings.) *
- Using var is okay, if and only if the type is obvious (namely, for “new” statements, cast statements, or anonymous object). 
- All production code must have associated unit tests. 
- All new production code should have at least rudimentary XML doc comments. 
- Prefer postfix operations (x++) to prefix operations (++x) when there is no difference in behavior. 

### Examples of var usage

    // This is ok
    var tuple = new { Name = >"John", Age = 50 }; 
    
    // This is ok
    var stream = new MemoryStream();
    
    // This is ok
    var product = (Product)GetProduct();
    
    // This is NOT ok
    var values = GetProducts();


### Example of the source code style

    using System;
    
    namespace System.Web.Http
    {
        public class ClassName
        {
            private List<SomeType> _privateMember;
    
            public List<SomeType> ShortProperty
            {
                get { return _privateMember; }
            }
    
            public string AutoProperty { get; set; }
    
            public int ComplexProperty
            {
                get
                {
                    if (someCondition)
                    {
                        return 42;
                    }
                    else
                    {
                        return 2112;
                    }
                }
            }
    
            public string SomeMethod(Status status)
            {
                switch (status)
                {
                    case Status.Foo:
                        return "It was a Foo";
    
                    case Status.Bar:
                        return "Turns out it was a Bar";
    
                    default:
                        return "I’m honestly not sure what it was";
                }
            }
        }
    }
    
## JavaScript coding conventions

- Namespaces are Pascal-cased. 
- Class names are Pascal-cased. 
- Properties, fields and local variables are camel-cased. 
- Parameters are camel-cased. 
- Functions which are class constructors are Pascal-cased; all other functions are camel-cased. 
- Use the K&R style for opening braces (put the opening brace on the opening line). This is because in JavaScript, the semicolon is optional, which can cause difficult to spot bugs (see  [http://msmvps.com/blogs/luisabreu/archive/2009/08/26/the-semicolon-bug.aspx](http://msmvps.com/blogs/luisabreu/archive/2009/08/26/the-semicolon-bug.aspx) for an example). 
In general, if your code makes [JSLint](http://www.jslint.com/) happy, it’ll make us happy, too. 
