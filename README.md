# C#-Assignment-1

This repository contains a collection of ASP.NET Web API controllers that perform various functions.

## AddTenController

### Description
The `AddTenController` provides an API endpoint to add 10 to an integer value.

### Usage
- **GET** `/api/AddTen/{id}`: Adds 10 to the provided integer value.
  - Example: `/api/AddTen/5` returns `15`

## SquareController

### Description
The `SquareController` provides an API endpoint to calculate the square of an integer value.

### Usage
- **GET** `/api/Square/{id}`: Calculates the square of the provided integer value.
  - Example: `/api/Square/4` returns `16`

## GreetingController

### Description
The `GreetingController` provides API endpoints for greeting messages.

### Endpoints
- **POST** `/api/Greeting`: Returns the string "Hello World!"
- **GET** `/api/Greeting/GetGreeting`: Returns the string "Hello World!"

## GreetingPeopleController

### Description
The `GreetingPeopleController` provides an API endpoint to greet a specified number of people.

### Usage
- **GET** `/api/GreetingPeople/Postgreeting/{id}`: Greets the specified number of people.
  - Example: `/api/GreetingPeople/Postgreeting/3` returns "Greetings to 3 people!"

## NumberMachineController

### Description
The `NumberMachineController` provides API endpoints for performing basic arithmetic operations on a number.

### Endpoints
- **GET** `/api/NumberMachine/{id}`: Performs addition, subtraction, multiplication, and division by 10 on the provided number and returns the results.

## HostingCostController

### Description
The `HostingCostController` calculates the cost of hosting services based on the number of days.

### Usage
- **GET** `/api/HostingCost/{id}`: Calculates the hosting cost for a specified number of days and returns the details, including fortnights, HST, and the total cost.

---
All the controllers are located in the Controllers folder.
