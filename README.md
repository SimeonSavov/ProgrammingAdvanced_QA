# Programming Advanced for QA

Welcome to my repository for the 'Programming Advanced for QA' course in QA Engineering at SoftUni. Here, I will be sharing my exercises and projects.

## Folder Structure
- [StringAndTextProcessing_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-first-section---string-and-text-processing-lesson-1)
- [RegularExpressions_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-second-section---regular-expressions-lesson-2)
- [UnitTestingStringsRegEx_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-third-section---unit-tests-strings-and-regex-lesson-3)
- [DictionariesLambdaLINQ_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-fourth-section---dictionary-lambda-expressions--linq-lesson-4)
- [DictionariesLambdaLINQ_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-fifth-section---dictionary-lambda-expressions--linq-lesson-5)
- [UnitTestingDictionariesLambdaLINQ_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-sixth-section---unit-testing-for-dictionaries-lambda-expressions--linq-lesson-6)
- [ObjectsAndClasses_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-seventh-section---objects-and-classes-lesson-7)
- [DefiningClasses_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-eighth-section---defining-classes-lesson-8)
- [ObjectsAndClasses_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-ninth-section---objects-and-classes-lesson-9)
- [UnitTestingObjectsAndClasses_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-tenth-section---unit-testing-for-objects-and-classes-lesson-10)
- [ExceptionAndErrorHandling_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-eleventh-section---exception-and-error-handling-lesson-11)
- [UnitTestingExceptions&ErrorHandling_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-twelfth-section---unit-testing-for-exceptions-and-error-handling-lesson-12)
- [OPP: Encapsulation, Inheritance_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-thirteenth-section---oop-encapsulation-and-inheritance-lesson-13)
- [OOP: Abstraction, Polymorphism_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-fourteenth-section---oop-abstraction-and-polymorphism-lesson-14)
- [OOP: Hierarchy_Exercise](https://github.com/SimeonSavov/ProgrammingAdvanced_QA/blob/main/README.md#about-the-fifteenth-section---oop-hierarchy-lesson-15)
- [ExamPreparation_UnitTesting](https://github.com/SimeonSavov/ProgrammingAdvanced_QA?tab=readme-ov-file#about-the-sixteenth-section---exam-preparation-unit-testing-lesson-16)



## About the First Section - String and Text Processing (Lesson 1)

In the first section of the "Programming Advanced for QA" course, I embarked on a journey into the world of string and text processing in C#. Here's a summary of what I've explored and achieved:

1.  **Reversing Words:** Task 1 introduced me to the concept of string manipulation by reversing words. I developed code that reads user input, reverses the characters in each word, and displays the reversed word pairs. This task emphasized string manipulation and the usage of `Reverse()` method.
    
2.  **Repeating Characters:** Task 2 challenged me to create a program that repeats characters within words, exploring the power of string manipulation. I constructed code that reads and splits user input, then repeats characters in each word and displays the resulting concatenated string.
    
3.  **Word Removal:** Task 3 honed my skills in text processing by enabling me to remove specific words from a given text. I developed code that searches and removes user-defined words from the text. This task emphasized text replacement and user input handling.
    
4.  **Censoring Words:** Task 4 introduced me to word censoring, an important text processing concept. I crafted code that reads banned words and a text, replacing occurrences of banned words with asterisks. This task emphasized string replacement and word censorship.
    
5.  **Text Categorization:** Task 5 expanded my text processing capabilities by categorizing characters in a given text into three groups: digits, letters, and other symbols. I efficiently categorized characters based on their types and displayed them separately. This task demonstrated my proficiency in character categorization and string manipulation to handle diverse character types within a given text.
    

Throughout this section, I've delved into various aspects of string and text processing, honing my skills in string manipulation, text replacement, and user input handling. These fundamental concepts form the building blocks of more advanced text processing techniques, setting the stage for further exploration in the course.

## About the Second Section - Regular Expressions (Lesson 2)

In the second section of the "Programming Advanced for QA" course, I ventured into the powerful realm of regular expressions (regex) in C#. Here's a summary of my exploration and accomplishments:

1. **Full Name Extraction:**
The first exercise was an introduction to regular expressions and focused on extracting full names from text. I implemented a regex pattern to match names in the format "First Last" and applied it to user-provided text, effectively extracting and displaying full names.

2. **Bulgarian Phone Numbers:**
Task 2 delved into regex patterns for matching Bulgarian phone numbers with various formats. I developed a regex pattern to identify phone numbers with or without separators and successfully extracted and presented phone numbers in the correct format. This exercise expanded my understanding of regex for complex pattern matching.

3. **Date Extraction and Display:**
The third exercise showcased regex for matching and extracting dates with distinct formats. I crafted a regex pattern that efficiently identified and extracted dates in various valid formats and displayed date components (day, month, and year). This task honed my regex skills for date recognition and data extraction.

In this section, I delved into the world of regular expressions, equipping myself with powerful tools for pattern matching, text extraction, and data validation. These skills are pivotal for precise text processing and data extraction, providing a solid foundation for more advanced regex applications in the course.

## About the Third Section - Unit Tests Strings and RegEx (Lesson 3)

In the third section of the "Programming Advanced for QA" course, I focused on mastering unit testing techniques for strings and regular expressions in C#. Here's a summary of the methods and exercises covered:

1. **Exercise 1 - Email Validator:**
Implemented the `IsValidEmail` method in the `EmailValidator` class, employing a regex pattern to validate email addresses. Accompanied by comprehensive unit tests, this exercise enhanced my skills in crafting effective unit tests for email validation.

2. **Exercise 2 - Match Dates:**
Created the `MatchDates` class with the `Match` method for extracting and displaying dates in a specific format. Through unit tests, I ensured accurate date matching and validation, showcasing the power of regex in handling date-related tasks.

3. **Exercise 3 - Match Names:**
Developed the `MatchNames` class to extract and concatenate valid names from input text. The exercise honed my regex skills for capturing specific patterns within text and provided insights into handling multiple matches.

4. **Exercise 4 - Match Phone Numbers:**
Implemented the `MatchPhoneNumbers` class to identify and display valid Bulgarian phone numbers. Unit tests covered various scenarios, validating the accuracy of regex-based phone number matching and extraction.

5. **Exercise 5 - Match URLs:**
Introduced the `MatchUrls` class for extracting URLs from text using a regex pattern. The unit tests ensured precise URL extraction, highlighting the importance of crafting regex patterns for specific tasks like URL identification.

6. **Exercise 6 - Pattern:**
Created the `Pattern` class with the `GeneratePatternedString` method, demonstrating the use of unit tests for patterned string generation. This exercise emphasized the importance of testing complex string manipulation methods.

7. **Exercise 7 - Repeat Strings:**
Implemented the `RepeatStrings` class to repeat and concatenate strings based on their lengths. The accompanying unit tests verified the correctness of the method, showcasing effective testing practices for string manipulation.

8. **Exercise 8 - Reverse Concatenate:**
Developed the `ReverseConcatenate` class with the `ReverseAndConcatenateStrings` method, showcasing string reversal and concatenation. Unit tests covered various scenarios, ensuring the method's accuracy and reliability.

9. **Exercise 9 - Substring:**
Created the `Substring` class with the `RemoveOccurrences` method for removing specified substrings from text. Through unit tests, I validated the effectiveness of the method in handling substring removal and whitespace consolidation.

10. **Exercise 10 - Text Filter:**
Implemented the `TextFilter` class for replacing banned words in text with asterisks. Unit tests covered cases with and without banned words, showcasing the method's ability to handle different scenarios.

In this section, I delved into the art of unit testing, applying it to various string manipulation and regex-related tasks. These exercises equipped me with essential skills for ensuring the correctness and reliability of my code.

## About the Fourth Section - Dictionary, Lambda Expressions & LINQ (Lesson 4)

In the fourth section of the "Programming Advanced for QA" course, the focus shifted to dictionaries, lambda expressions, and LINQ in C#. Here's a summary of the methods and exercises covered:

1. **Task 1 - Numbers Frequency:**
Implemented a program to read and display the frequency of each number in an array. Utilizing a `SortedDictionary<int, int>` and basic iteration, I gained insights into dictionary usage for tracking element occurrences.

2. **Task 2 - Odd Word Occurrences:**
Developed a program to count and display words with odd occurrences in a case-insensitive manner. Employing a `Dictionary<string, int>` and lambda expressions, this task enhanced my skills in handling word occurrences and case-insensitive comparisons.

3. **Task 3 - Synonyms Dictionary:**
Implemented a program to create and display a dictionary of synonyms. Utilizing a `Dictionary<string, List<string>>`, this exercise provided hands-on experience in managing collections of related words and their synonyms.

4. **Task 4 - Filter Words by Length:**
Created a program to filter and display words based on their lengths using LINQ expressions. The exercise focused on the application of LINQ for efficient data manipulation, specifically filtering elements based on a specified condition.

In this section, I explored the versatility of dictionaries, lambda expressions, and LINQ, gaining valuable insights into their applications for efficient data manipulation and collection management.

## About the Fifth Section - Dictionary, Lambda Expressions & LINQ (Lesson 5)

In the fifth section of the "Programming Advanced for QA" course, the focus continued on dictionaries, lambda expressions, and LINQ in C#. Here's a summary of the methods and exercises covered:

1. **Exercise 1 - Character Occurrences:**
Implemented a program to read a string and display the occurrences of each character, excluding spaces. Utilizing a `Dictionary<char, int>`, this exercise provided practical experience in working with characters and dictionaries.

2. **Exercise 2 - Sum of Resources:**
Developed a program to track resources and display their sums. Utilizing a `Dictionary<string, int>`, this exercise emphasized the management of resource quantities and the application of dictionary operations.

3. **Exercise 3 - Product Database:**
Implemented a program to create a product database and display the total amounts for each product. Utilizing a `Dictionary<string, List<decimal>>`, this task provided hands-on experience in managing product-related data and performing calculations.

4. **Exercise 4 - Registered Users:**
Created a program to register and unregister users, displaying their registration status. Utilizing a `Dictionary<string, string>`, this exercise focused on user registration and management through dictionary operations.

5. **Exercise 5 - Excellent Students:**
Developed a program to filter and display excellent students based on their average grades. Utilizing a `Dictionary<string, List<double>>` and LINQ expressions, this task showcased the application of LINQ for efficient data filtering.

6. **Exercise 6 - Company Users:**
Implemented a program to track employees assigned to different companies. Utilizing a `Dictionary<string, List<string>>`, this exercise enhanced my skills in working with dictionaries and managing relationships between data.

In this section, I delved deeper into the practical applications of dictionaries, lambda expressions, and LINQ, gaining proficiency in handling various data scenarios and performing efficient data manipulations.

## About the Sixth Section - Unit Testing for Dictionaries, Lambda Expressions & LINQ (Lesson 6)

In the sixth section of the "Programming Advanced for QA" course, the focus shifted towards unit testing for functionalities involving dictionaries, lambda expressions, and LINQ in C#. Here's a summary of the methods and exercises covered:

1. **Exercise 1 - Count Characters:**
Implemented a method to count the occurrences of each character in a list of strings. Utilizing NUnit tests, this exercise emphasized the importance of testing for correct character counting and dictionary creation.

2. **Exercise 2 - Count Real Numbers:**
Developed a method to count the occurrences of real numbers in an array. NUnit tests were implemented to ensure the correct functionality of counting and displaying real number occurrences.

3. **Exercise 3 - Grouping:**
Implemented a method to group even and odd numbers from a list. The NUnit tests verified the correctness of the grouping operation using lambda expressions and dictionary management.

4. **Exercise 4 - Miner:**
Created a method to mine resources and display their counts. NUnit tests were implemented to ensure the correct registration and unregistration of users, emphasizing the importance of testing dictionary-based functionalities.

5. **Exercise 5 - Odd Occurrences:**
Developed a method to find and display words with odd occurrences. NUnit tests were implemented to validate the correct identification of odd occurrences and case-insensitive comparisons.

6. **Exercise 6 - Orders:**
Implemented a method to process orders and calculate total prices. NUnit tests were created to ensure the correct calculation of total prices for various scenarios involving decimal quantities and rounded prices.

7. **Exercise 7 - Plants:**
Developed a method to group plants by their lengths and display them in ascending order. NUnit tests were implemented to verify the correct grouping and ordering of plants based on their lengths.

In this section, the emphasis was on unit testing, ensuring the reliability and correctness of functionalities involving dictionaries, lambda expressions, and LINQ in C#.

## About the Seventh Section - Objects and Classes (Lesson 7)

In the seventh section of the "Programming Advanced for QA" course, the focus expanded to cover objects and classes in C#. Here's a summary of the methods and exercises covered:

1.  **Exercise 1 - Songs:**
Implemented a program to manage songs, creating a list of Song objects and filtering them based on a specified type. The code showcased the usage of classes, lists, and basic object manipulation.
    
3.  **Exercise 2 - Students:**
Developed a program to register students and filter them based on a specified hometown. This exercise provided hands-on experience in creating and manipulating objects of a Student class.
    
5.  **Exercise 3 - Store Boxes:**
Implemented a program to manage store boxes containing items. This exercise demonstrated the creation and manipulation of classes (Item and Box) and the usage of lists to store and order objects.
    
7.  **Exercise 4 - Vehicle Catalogue:**
Created a program to catalog and display information about cars and trucks. The solution showcased the usage of classes (Car and Truck), a Catalog class to manage collections, and sorting techniques with LINQ.
    
In this section, the focus was on practical applications of objects and classes in C#, covering topics such as object initialization, class design, and list manipulation.

## About the Eighth Section - Defining Classes (Lesson 8)

In the eighth section of the "Programming Advanced for QA" course, the focus shifted towards defining classes in C#. Here's a summary of the key concepts and exercises covered:

1.  **Car Manufacturer Program:**
    -   Introduced a program named CarManufacturer consisting of multiple classes.
    -   The `Car` class represents a car with properties such as Make, Model, Year, FuelQuantity, FuelConsumption, Engine, and Tires. It includes methods for driving and displaying information.
    -   The `Engine` class models the engine of a car with properties like HorsePower and CubicCapacity.
    -   The `Tire` class represents a tire with properties like Year and Pressure.
    -   The `StartUp` class serves as the entry point, showcasing the creation of a car instance (Lamborghini) with specified properties and displaying its information using the `WhoAmI` method.

This section provides hands-on experience in defining and utilizing classes, encapsulation, constructors, properties, and object-oriented programming principles in C#. The CarManufacturer program serves as a practical example of creating and working with interconnected classes to model a complex system.

## About the Ninth Section - Objects and Classes (Lesson 9)

In the ninth section of the "Programming Advanced for QA" course, the focus expanded on working with objects and classes in C#. Here's a summary of the tasks covered:

1.  **Task 1 - Student Grades:**
    
    -   Created a program to manage student information, including their first name, last name, and grade.
    -   Utilized a class named `Student` with properties for first name, last name, and grade.
    -   Read input for the number of students and their details, then displayed them in descending order based on grades.
2.  **Task 2 - Article Editing:**
    
    -   Developed a program to manage article information, including title, content, and author.
    -   Implemented a class named `Article` with methods for editing, changing the author, and renaming the article.
    -   Read input for an initial article and a series of commands to perform actions on the article.
3.  **Task 3 - Team Builder:**
    
    -   Created a program to manage teams and their members, avoiding duplicate teams or team creators.
    -   Utilized a class named `Team` with properties for the team name, creator, and members.
    -   Processed input to create teams, check membership eligibility, and display teams with members or those without members.
4.  **Task 4 - Pokemon Trainer Tournament:**
    
    -   Implemented a program simulating a Pokemon Trainer Tournament.
    -   Utilized classes such as `Trainer` and `Pokemon` to model trainers, their badges, and their Pokemon.
    -   Registered trainers and their Pokemon, simulated battles based on Pokemon elements, and displayed the trainers sorted by badges and remaining Pokemon count.

These tasks provided hands-on experience with object-oriented programming concepts, including class design, encapsulation, and interaction between objects.

## About the Tenth Section - Unit Testing for Objects and Classes (Lesson 10)

The tenth section of the "Programming Advanced for QA" course delved into unit testing for functionalities centered around objects and classes in C#. Here's a summary of the methods and exercises covered:

1.  **Task 1 - Shop:** Created a class named `Shop` with methods to add and get boxes. The unit tests ensured the correct sorting of boxes based on their prices, validating the proper functioning of the `AddAndGetBoxes` method.
    
2.  **Task 2 - Vehicles:** Implemented a class called `Vehicles` to process and catalog cars and trucks. The unit tests focused on confirming the correct sorting of the catalog based on vehicle type (cars and trucks), ensuring the accuracy of the `AddAndGetCatalogue` method.
    
3.  **Task 3 - Article:** Developed a class named `Article` with methods to add articles and retrieve them based on specific criteria such as title, content, or author. The unit tests verified the accuracy of the article addition and sorting functionalities, ensuring the correctness of the `AddArticles` and `GetArticleList` methods.
    
4.  **Task 4 - Person:** Created a class called `Person` to manage a list of people and their details. The unit tests focused on confirming the proper addition and sorting of people based on their unique IDs, validating the correctness of the `AddPeople` and `GetByAgeAscending` methods.
    
5.  **Task 5 - Planet:** Implemented a class named `Planet` representing celestial bodies with methods to calculate gravity and retrieve planet information. The unit tests ensured the accurate calculation of gravity and the correct display of planet information, validating the functionality of the `CalculateGravity` and `GetPlanetInfo` methods.
    
6.  **Task 6 - Song:** Developed a class called `Song` to manage a list of songs and filter them based on a specified list type. The unit tests focused on confirming the proper addition and filtering of songs, ensuring the correctness of the `AddAndListSongs` method.
    
7.  **Task 7 - Student:** Created a class named `Student` with methods to add students and retrieve information about students from a specific hometown. The unit tests verified the accuracy of the student addition and filtering functionalities, ensuring the correctness of the `AddAndGetByCity` method.
    

In this section, the emphasis was on unit testing for various functionalities involving objects and classes, ensuring their reliability and correctness in a C# environment.

## About the Eleventh Section - Exception and Error Handling (Lesson 11)

The eleventh section of the "Programming Advanced for QA" course delved into the critical topic of Exception and Error Handling in C#. Here's a summary of the tasks covered:

**Task 1 - Handling Negative Square Root**

The task introduced handling exceptions when attempting to calculate the square root of a number. The code checks for negative input, throwing an exception if necessary. The catch block manages the exception, displaying an error message, and the finally block ensures a "Goodbye" message is printed, irrespective of the exception status.

**Task 2 - Reading Numbers with Constraints**

This task involved creating a method to read a number within a specified range. A loop utilized this method to read 10 numbers, catching exceptions for values out of range or invalid integer input.

**Task 3 - Summing Integers with Exception Handling**

The task focused on parsing elements from a list into integers, handling exceptions for incorrect formats or values outside the valid range. The finally block provided a status message for each processed element, along with the current sum.

In this section, the emphasis was on fortifying code against unexpected situations through effective exception and error handling strategies in C#. Each task provided hands-on experience in dealing with various types of exceptions, ensuring the creation of robust and error-resistant code.

## About the Twelfth Section - Unit Testing for Exceptions and Error Handling (Lesson 12)

In the twelfth section of the "Programming Advanced for QA" course, the focus shifted to Unit Testing for Exceptions and Error Handling in C#. Here's an in-depth overview of each task, highlighting the key concepts and skills acquired:

**Task 1 - Exceptional String Reversal**

The initial task delved into the importance of handling exceptions when reversing a string. The method was designed to check for null input, throwing an ArgumentNullException when necessary. Unit tests were meticulously crafted to ensure the proper reversal of strings and the effective handling of null inputs.

**Task 2 - Robust Number Reading**

Task 2 involved creating a method for reading numbers within specified constraints. Utilizing a loop, this method read 10 numbers while catching exceptions for values outside the designated range or invalid integer inputs. The accompanying unit tests rigorously examined the functionality of the reading method and its adept exception-handling capabilities.

**Task 3 - Summing Up Exceptions**

The third task focused on parsing elements from a list into integers, emphasizing the handling of exceptions for incorrect formats or values beyond the valid range. The finally block ensured the provision of a status message for each processed element, along with the current sum. Unit tests played a crucial role in validating the correct parsing of elements and the effective handling of various exceptions.

**Task 4 - Null Argument Reversal**

Task 4 expanded on exception handling, specifically addressing null arguments in string reversal. The method checked for null input, throwing an ArgumentNullException when necessary. The unit tests systematically verified the correct reversal of strings and the proper management of null inputs.

**Task 5 - Discount Calculation Precision**

In this task, precision in discount calculation was explored. The method checked for discount values outside the valid range, throwing an ArgumentException when necessary. Unit tests were meticulously designed to validate the precise calculation of discounts and the accurate handling of out-of-range discount values.

**Task 6 - Secure Element Retrieval**

Task 6 focused on secure retrieval of elements from an array by index. The method checked for index values outside the valid range, throwing an IndexOutOfRangeException when necessary. Unit tests rigorously examined the functionality of the retrieval method and its robust exception-handling capabilities.

**Task 7 - Secure Operation Execution**

The seventh task emphasized executing secure operations by checking a user's login status. The method threw an InvalidOperationException for unauthorized users. Unit tests thoroughly validated the correct execution of secure operations for logged-in users and the effective handling of unauthorized attempts.

**Task 8 - Integer Parsing Confidence**

Task 8 centered on parsing strings into integers, specifically addressing FormatException scenarios. The method threw a FormatException for incorrectly formatted input. Unit tests played a crucial role in ensuring the accurate parsing of integers and the effective management of FormatException cases.

**Task 9 - Key-Based Value Retrieval**

In this task, the focus was on retrieving values from a dictionary based on keys. The method threw a KeyNotFoundException for missing keys. Unit tests systematically verified the correct retrieval of values for existing keys and the proper handling of scenarios where keys were not found.

**Task 10 - Arithmetic Operation Resilience**

The final task explored resilience in arithmetic operations, specifically addressing overflow scenarios during addition. The method utilized a checked block and threw an OverflowException when necessary. Unit tests played a crucial role in validating the resilience of arithmetic operations and the effective handling of overflow situations.

In this section, developers gained comprehensive insights into Unit Testing for Exceptions and Error Handling in C#, acquiring essential skills to build robust, error-resistant code that can effectively handle unexpected situations. The meticulously designed unit tests serve as a reliable suite for validating the correctness and resilience of exception-handling mechanisms implemented in C# applications.

## About the Thirteenth Section - OOP: Encapsulation and Inheritance (Lesson 13)

The thirteenth section of the "Programming Advanced for QA" course delves into the fundamental principles of Object-Oriented Programming (OOP), focusing on encapsulation and inheritance in C#. Here's a breakdown of the tasks and key concepts covered:

**Task 1 - Creating Box Objects**

Task 1 involves creating objects of the `Box` class, demonstrating encapsulation by restricting access to the dimensions of the box. The class encapsulates length, width, and height properties with validation, ensuring that only valid dimensions can be set.

**Task 2 - Sorting and Displaying Persons**

In Task 2, a list of `Person` objects is created, showcasing encapsulation by encapsulating the properties of first name, last name, and age. The list is then sorted based on first name and age, highlighting the power of encapsulation in organizing and manipulating data.

**Task 3 - Implementing a Hero Hierarchy**

Task 3 introduces inheritance with a hierarchy of hero classes, showcasing the relationship between base classes (`Hero`, `Elf`) and derived classes (`Knight`, `BladeKnight`, `DarkKnight`, `MuseElf`). This demonstrates the concept of specialization and code reuse through inheritance.

**Task 4 - Constructing a Zoo Animal Hierarchy**

The fourth task presents an animal hierarchy for a zoo, emphasizing inheritance by structuring classes for different types of animals, including mammals (`Bear`, `Gorilla`), reptiles (`Lizard`, `Snake`), and base classes (`Animal`, `Mammal`, `Reptile`). This hierarchy allows for organized representation and management of zoo inhabitants.

In this section, developers gain practical experience in applying encapsulation and inheritance, two key pillars of Object-Oriented Programming. The tasks provide hands-on insights into creating structured, reusable, and maintainable code, essential for building robust software solutions.

## About the Fourteenth Section - OOP: Abstraction and Polymorphism (Lesson 14)

The fourteenth section of the "Programming Advanced for QA" course continues the exploration of Object-Oriented Programming (OOP) principles, focusing on abstraction and polymorphism in C#. Here's a comprehensive overview of the tasks and key concepts covered:

**Task 1 - Abstracting Animal Behavior**

Task 1 introduces abstraction by creating abstract classes and methods for animals. The Animal class serves as a base abstraction, and concrete implementations (Cat and Dog) showcase the power of abstraction in providing a common structure for diverse entities while allowing specific implementations.

**Task 2 - Interface-based Car Abstraction**

In Task 2, abstraction is achieved through interfaces. The ICar interface defines common properties and methods for cars, and concrete classes (Seat, Tesla) implement this interface. This task highlights the flexibility of abstraction through interfaces, enabling multiple inheritance and creating a unified contract for diverse classes.

**Task 3 - Polymorphic Hero Casting**

Task 3 explores polymorphism by creating a hierarchy of heroes with different abilities. The IHero interface and base class (BaseHero) demonstrate polymorphic behavior as derived classes (Druid, Paladin, Rogue, Warrior) override methods. This showcases the power of polymorphism in simplifying code and accommodating diverse functionalities within a common structure.

**Task 4 - Drawing Shapes with Polymorphism**

The fourth task focuses on polymorphic behavior in the context of drawing shapes. The IDrawable interface defines a common drawing method, and classes (Circle, Rectangle) implement this interface. This demonstrates how polymorphism simplifies code maintenance and extension by providing a consistent way to interact with different shapes.

In this section, I gain hands-on experience in applying abstraction and polymorphism, essential concepts in Object-Oriented Programming. The tasks emphasize my creation of flexible, extensible, and easy-to-maintain code, contributing to the development of robust software solutions.

## About the Fifteenth Section - OOP Hierarchy (Lesson 15)

The fifteenth section of the "Programming Advanced for QA" course delves into the concept of OOP Hierarchy, focusing on building a restaurant application. Here's a detailed overview of the tasks and key concepts covered:

**Task 1 - Restaurant Application Foundation**

Task 1 serves as the foundation for the restaurant application. I create a `Restaurant` class, introducing concepts like menu items, customers, and orders. The task involves adding customers and menu items, placing orders, and displaying menu items and order history.

**Task 2 - Creating Menu Item Hierarchy**

In this task, I establish an item hierarchy for the restaurant's menu. Classes like `MainCourseMenuItem`, `AppetizerMenuItem`, and `DessertMenuItem` inherit from the abstract class `MenuItem`. This showcases the power of inheritance in organizing menu items with shared properties and behavior.

**Task 3 - Customer Order History**

Task 3 emphasizes customer order history management. The `Customer` class encapsulates order history, demonstrating encapsulation and showcasing how customers can place and retrieve orders. This task further solidifies the practical application of OOP principles.

**Task 4 - Displaying Menu and Order History**

The final task involves implementing methods to display the restaurant's menu and a customer's order history. The `Restaurant` class showcases how to present information in a structured manner, offering insights into the effectiveness of the implemented OOP Hierarchy.

In this section, I gain hands-on experience in applying OOP Hierarchy concepts to a real-world scenario—the development of a restaurant management system. These tasks provide practical insights into creating organized, reusable, and maintainable code, essential for developing robust software solutions.

## About the Sixteenth Section - Exam Preparation: Unit Testing (Lesson 16)

The sixteenth section of the "Programming Advanced for QA" course focuses on Exam Preparation with a specific emphasis on Unit Testing. This section aims to provide a comprehensive understanding of unit testing principles and practices through practical exercises. Here's an overview of the tasks covered:

**Task 1 - String Rotator**

Task 1 involves the implementation of a StringRotator class with a method to rotate characters to the right in a string. The corresponding unit tests, using NUnit.Framework, ensure the correctness of the rotation functionality under various scenarios, including empty strings and different rotation positions.

**Task 2 - Dictionary Intersection**

Task 2 introduces the DictionaryIntersection class, designed to find the common elements between two dictionaries. The unit tests validate the functionality under different conditions, such as empty dictionaries, dictionaries with common keys and values, and dictionaries with common keys but different values.

**Task 3 - Product Inventory**

Task 3 revolves around a Product class and a ProductInventory class responsible for managing products, displaying the inventory, and calculating the total value. Unit tests, implemented using NUnit.Framework, verify the correctness of adding products, displaying the inventory, and calculating the total value.

In this section, I engage in hands-on exercises to strengthen my unit testing skills. Each task focuses on a specific aspect of unit testing, ensuring that I am well-prepared to create reliable, maintainable, and bug-free code. These exercises contribute to my proficiency in implementing effective unit tests for software quality assurance.
