# Welcome to c-sharp-advanced!

This repository is here to show some advanced C# features such as Collections, Lambdas, LINQ, Extension Methods and Threading.
This content was initially created for the Advanced C# Workshop at [Microsoft Imagine Center UPB](https://microsoft.pub.ro/) in order to accommodate MSAs on their path to becoming MSPs.  


# Collections

Collections are a way of organising your data and based of that each type of structure has some advantages and some disadvantages. We can first classify them into 2 categories, based on their dimensions (way of splitting the data), those are also known as Generic Collections:

 - Single dimensional collections such as: **Lists** , **Queues** and **Stacks**
 - Collections with 2 dimensions KeyValuePair based such as: **Dictionaries** and **SortedLists**

    List\<int> primeDigits = new List\<int>() {2, 3, 5, 7}
    Dictionary\<int, bool> isPrime = new Dictionary\<int, bool>() {{2, true}, {3, true}, {4, false}};

We can also talk about thread-safe collections such as:

 - BlockigCollection (1D) 
 - ConcurentStack (1D) 
 - ConcurentQueue (1D)
 - ConcurentDictionary (2D)

## Lambdas

This concept comes from the Functional Programming Paradigm. This paradigm is considering that everything is a function (same ways as OOP sees everything as an object) and those functions should not produce side effects. Some classical examples of side effects in Functional Programming are those who log in the console or I/O.

We will use lambdas as functions that will be used as one-time methods in order to simplify our code. Mostly LINQ is used with with Lambdas for things as selection, filtering and so on.

    var query = {1, 2, 3}.Where(x => (x * (x % 2) > requirement));

## LINQ

As per Microsoft Documentation "Language Integrated Query is the name for a set of technologies based on the integration of query capabilities directly into the C# language. Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support."

For me LINQ is a way of writing code in a more human oriented way as it used concepts and words closed to natural language and it makes the code transform into a tale.

    var futureDates = for date in days
				      where date > DateTime.UtcNow
				      select date;

## Extension Methods
They are, as their name says methods that extend the basic functionality of a given type. They must be written in a static class and be static methods, but the rest is limited only by your imagination. They can take arguments and return results.

    public static class ExtensionMethods
    {
	    public static <RETURN_TYPE> ExtensionMethod(this <TYPE> callingObject, object[] args)
	    {
		    // DO SOMETHING
	    }
    }

## Threading
Threading is a complex subject for which we need to know:

 1. Our processor(s) have a property called Threads that refer to the maximum number of "simultaneous" operations that can be done at a given moment
 2. Reading after a Read is considered the only secure operation as the order basically corrupt the data
 3. There are thread-safe objects and there are non-thread-safe objects
 4. One Thread is considered the Main Thread and the others are secondary
 5. Some operations can not be done in threads
 6. If it involves UI, the UI is considered to be the main thread
 7. We have many build in Parallel Mechanisms and we should use them

Those being said, I will like to use 5 concepts in this Repository:

 - Tasks, including async and async void
 - Parallel For
 - Parallel For Each
 - Barriers
 - Parallel Operations (Invoking, waiting and delaying a task)
