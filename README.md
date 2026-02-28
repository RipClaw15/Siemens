# Internship Dynamics & Azure / Full Stack 2026

## Problem 1

**1.1 Class Diagram**

<img width="1514" height="833" alt="1 1 Class Diagram" src="https://github.com/user-attachments/assets/84474a87-7b05-4df5-944a-35ac7921f908" />

**1.2 ER Diagram**

<img width="1878" height="935" alt="image" src="https://github.com/user-attachments/assets/5dddd1cc-7d93-4980-91b1-e6ee694cba24" />

## Problem 2

**2.1 Necessary C# classes**

### Order Class

<img width="986" height="685" alt="2 1" src="https://github.com/user-attachments/assets/01b272f6-8e34-4263-9a10-409b000494c4" />

### OrderItem Class

<img width="1029" height="705" alt="2 12" src="https://github.com/user-attachments/assets/2da9db9c-7934-4b6c-8384-431be9736c93" />

### Customer Class

<img width="872" height="683" alt="2 13" src="https://github.com/user-attachments/assets/69e79c56-932b-4249-893f-9d30ca7cd5cc" />

**2.2 Method to calculate final price of an order with or without discount**

###  `CalculateFinalPrice()` Method

<img width="814" height="621" alt="image" src="https://github.com/user-attachments/assets/79a78f69-bdd0-4b73-9ec7-af797384067a" />

The method is inside the **Order** Class

**2.3 Method to find the top spender**

For this requirement I created a new class called **FactOrder** Class

### `FindTopSpender` Method

<img width="771" height="460" alt="2 3" src="https://github.com/user-attachments/assets/6ae4ebb1-9681-42b4-bfba-5cb04431cabd" />

**2.4 Method to find the popular products and its quantities sold**

I implemented this method into the **FactOrder** Class

### `GetPopularProducts` Method

<img width="958" height="449" alt="2 4" src="https://github.com/user-attachments/assets/3c9e2e84-934f-4f70-a574-8635add1d046" />

I used a Dictionary data structure, which made it super easy to "hold" (group) the two values needed to return (product, quantity sold)

### Example with some random data

<img width="781" height="789" alt="image" src="https://github.com/user-attachments/assets/766c3807-6570-42d7-ace4-67dee13f714c" />

