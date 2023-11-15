# Programming Advanced for QA

Welcome to my repository for the 'Programming Advanced for QA' course in QA Engineering at SoftUni. Here, I will be sharing my exercises and projects.

## Folder Structure
- [StringAndTextProcessing_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-first-section---string-and-text-processing-lesson-1)
- [RegularExpressions_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-second-section---regular-expressions-lesson-2)
- [UnitTestingStringsRegEx_Exercises](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-third-section---unit-tests-strings-and-regex-lesson-3)
- [DictionariesLambdaLINQ_Lab](https://github.com/SimeonSavov/ProgrammingAdvanced_QA#about-the-fourth-section---dictionary-lambda-expressions--linq-lesson-4)



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
