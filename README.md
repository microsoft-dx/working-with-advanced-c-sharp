# Welcome to c-sharp-advanced!

This repository is here to show some advanced C# features such as Collections, Lambdas, LINQ, Extension Methods and Threading.
This content was initially created for the Advanced C# Workshop at [Microsoft Imagine Center UPB](https://microsoft.pub.ro/) in order to accommodate MSAs on their path to becoming MSPs.  


# Collections

Collections are a way of organising your data and based of that each type of structure has some advantages and some disadvantages. We can first classify them into 2 categories, based on their dimensions (way of splitting the data), those are also known as Generic Collections:

 - Single dimensional collections such as: **Lists** , **Queues** and **Stacks**
 - Collections with 2 dimensions KeyValuePair based such as: **Dictionaries** and **SortedLists**

We can also talk about thread-safe collections such as:

 - BlockigCollection (1D) 
 - ConcurentStack (1D) 
 - ConcurentQueue (1D)
 - ConcurentDictionary (2D)

## Lambdas

This concept comes from the Functional Programming Paradigm. This paradigm is considering that everything is a function (same ways as OOP sees everything as an object) and those functions should not produce side effects. Some classical examples of side effects in Functional Programming are those who log in the console or I/O.

We will use lambdas as functions that will be used as one-time methods in order to simplify our code. Mostly LINQ is used with with Lambdas for things as selection, filtering and so on.

## LINQ

As per Microsoft Documentation "Language Integrated Query is the name for a set of technologies based on the integration of query capabilities directly into the C# language. Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support."

For me LINQ is a way of writing code in a more human oriented way as it used concepts and words closed to natural language and it makes the code transform into a tale.

## Extension Methods

## Threading