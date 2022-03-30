# NumberLists

Number Lists is a console app for users to learn about numbers and their relationships. It displays lists of numbers that follow various rules and user-defined constraints. It also retrieves number facts and trivia from [Numbers API](http://numbersapi.com/ "Numbers API"). Users can save and retrieve these lists and facts.  
 
## Navigation

### Main Menu
<details>
  <summary><h4>Arithmatic Sequences</h4></summary>
  <p><strong>Even number list:</strong> Displays all even natural numbers in a user-defined range</p>
  <p><strong>Odd number list:</strong> Displays all odd natural numbers in a user-defined range</p>
  <p><strong>Multiples list:</strong> Displays all multiples of a user-defined natural numbers in a user-defined range</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

<details>
  <summary><h4>Geometric & Power Sequences</h4></summary>
  <p><strong>Geometric sequence:</strong> Displays a sequence of user defined length of numbers multiplied by themselves</p>
  <p><strong>Power list:</strong> Displays a sequence of user defined length of numbers raised to a user-defined power</p>
  <p><strong>List of squares:</strong> Displays a square number list of user defined length (a square number is a number multiplied by itself)</p>
  <p><strong>List of cubes:</strong> Displays a cube number list of user defined length (a cube is a number multipied by itself twice)</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

<details>
  <summary><h4>Special Number Sequences</h4></summary>
  <p><strong>List of prime numbers:</strong> Displays a prime number sequence of user-defined length (prime numbers have only two factors: one and itself </p>
  <p><strong>List of triangle numbers:</strong> Displays a list of a user-defined length of triangle numbers (triangle numbers count objects arranged in an equilateral triangle)</p>
  <p><strong>List of Fibonacci numbers:</strong> Displays a Fibonacci sequence of a user-defined length (a sequence in which each number is the sum of the two preceding ones)</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

<details>
  <summary><h4>Factors</h4></summary>
  <p><strong>List of factors:</strong> Displays a list of all factors of a user-defined number(factors are all the numbers that can evenly be divided into a number)</p>
  <p><strong>List of prime factors:</strong> Displays a list of the prime factors of a user-defined number(prime factors are all the prime numbers that can evenly be divided into a number)</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

<details>
  <summary><h4>Number Facts</h4></summary>
  <p><strong>Math fact:</strong> Displays a math fact about a user-defined number</p>
  <p><strong>Number trivia:</strong> Displays trivia about a user-defined number</p>
  <p><strong>Random math fact:</strong> Displays a math fact about a random number</p>
  <p><strong>Random number trivia:</strong> Displays trivia about a random number</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

<details>
  <summary><h4>Saved Number Lists & Facts</h4></summary>
  <p><strong>View all saved lists:</strong> Displays all saved number lists and their IDs, descriptions, and save date</p>
  <p><strong>View list by ID:</strong> Displays IDs, descriptions and save dates for all lists and prompts user to enter ID number. Displays list with selected ID</p>
  <p><strong>View all saved facts:</strong> Displays all saved number facts</p>
  <p><strong>Exit:</strong> Returns to main menu</p>
</details>

#### Exit Number List Program

## Usage
* On running the app, follow user prompts to generate, view, save and retrieve number lists & facts. 
* If the same question repeats, you have made an invalid selection.
    * Menu selection prompts only accept the number of a valid menu item or "X" to exit
    * Yes/no prompts only accept "y" or "n"
    * Number fact prompts only accept integers between 1 and 9999
    * All other umber prompts only accept integers between 1 and 2,147,483,647
* If the number list generator calculates a value greater than 9,223,372,036,854,775,807 the generator will stop and the number list will be displayed as is

## Project Requirements
This app meets all the requirements for the Code Louisville Software Development I course, including the following features:

* __Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program__
* __Create an additional class which inherits one or more properties from its parent__
   * *The NumberListBase class inherits from the Menu class in the CL Library* 
   * *All Menu classes in the NumberList UI folder inherit from the NumberListBase class*
   * *The NumberListSerializationService and NumberFactSerializationService classes inherit from the EntitySerializationService class found in the CL Library*
* __Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program__
   * *The NumberList class is a child of the List class*
   * *The methods from the NumberListGenerator class populate these lists*
   * *The WriteListWithSpacesAndNewLine method in the NumberList class retrieves values from these lists and writes them to the console with spaces between values*
* __Read data from an external file, such as text, JSON, CSV, etc and use that data in your application__
  * *The Retrieve methods in the SaverContainer class use methods from the EntitySerializationService class in the CL Library to read data from JSON files where users can save their number lists and facts*
  * *This data is displayed in the console using the Display methods in the SaverContainer class*
* __Connect to an external/3rd party API and read data into your app__
  * *The GetNumberFact method in the NumberFacts class connects to the [Numbers API](http://numbersapi.com/ "Numbers API") to read number facts*
  * *These facts are displayed in the console in the NumbrFactsMenu class*
  * *These facts can be saved to a JSON file using the Save method in the NumberFacts class*
* __Create 3 or more unit tests for your application__
  * *Unit tests for NumberListsGenerator methods are in the NumberListTests project*


## License
[MIT](https://choosealicense.com/licenses/mit/)