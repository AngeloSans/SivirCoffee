# Sivir Coffee

**Sivir Coffee** is a microservice application designed with a focus on scalability and efficient service communication. Utilizing components such as JWT (JSON Web Token) for secure authentication and RabbitMQ for reliable message brokering, Sivir Coffee ensures seamless interaction between its various services. This architecture not only enhances security but also promotes robust and maintainable code, making Sivir Coffee a modern solution for a dynamic and responsive coffee shop experience.

## Tools and Technologies

- **.NET**: The primary framework used for building the microservices.
- **PostgreSQL**: The relational database used for data storage.
- **RabbitMQ**: The message broker used for service communication.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- [RabbitMQ](https://www.rabbitmq.com/download.html)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/Anjocaido13/SivirCoffee.git
   cd SivirCoffee

2. **Restore NuGet packages**

    ```bash
    dotnet restore
    ```
3. **Update your data base**
   ```bash
     Update the connection string in each service's appsettings.json
   ```
4. **Create migration for each database**
   ```bash
     Add-Migration "Your Migration Name"
   ```
5 **Then Update your database**
  ```bash
    update-database
  ```
## Services

**AuthenticationService**
Handles user authentication and authorization using JWT. It provides functionalities for user registration and login, issuing JWT tokens for authenticated users to secure other service interactions.

**OrderService**
Manages customer orders. This service allows for creating new orders, updating existing ones, retrieving order details, and deleting orders. It ensures that the order lifecycle from creation to completion is handled efficiently.

**MenuService**
Manages the coffee shop's menu, including details about available coffees, candies, and condiments. This service handles the addition, update, retrieval, and deletion of menu items, ensuring the menu is up-to-date.

**PaymentService**
Handles payment processing for orders. This service ensures that payments are processed securely and transactions are completed successfully. It manages payment details and verifies transaction statuses.

