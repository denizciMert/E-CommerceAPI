# E-Commerce API

E-Commerce API is a simple and user-friendly e-commerce application that uses MongoDB for data storage. 
This API provides basic functionalities such as adding, updating, deleting, and listing products.

Created this project based on my mentor's advice to understand and learn the fundamental workings of REST API systems with MongoDB. 
By building upon this basic structure, I hope to prepare myself for larger projects.

## Getting Started

These instructions will help you get the project up and running on your local machine.

### Prerequisites

- .NET 8 SDK
- MongoDB

### Installation

1. **Clone the repository**:
    ```sh
    git clone https://github.com/denizciMert/e-commerce-api.git
    cd e-commerce-api
    ```

2. **Install the required dependencies**:
    ```sh
    dotnet restore
    ```

3. **Configure the application settings**:

    Update your MongoDB connection details in the `appsettings.json` file:
    ```json
    {
      "MongoDB": {
        "ConnectionUri": "mongodb://localhost:27017/",
        "DatabaseName": "ECommerceDb",
        "CollectionName": "Items"
      }
    }
    ```

4. **Run the application**:
    ```sh
    dotnet run
    ```

## Usage

### API Endpoints

- **GET /api/items**: Retrieves all items.
- **GET /api/items/{id}**: Retrieves an item by its ID.
- **POST /api/items**: Creates a new item.
- **PUT /api/items/{id}**: Updates an item by its ID.
- **DELETE /api/items/{id}**: Deletes an item by its ID.

### Sample API Requests (or you can use Swagger)

- **GET** `/api/items`
    ```sh
    curl -X GET "https://localhost:7192/api/items"
    ```

- **GET** `/api/items/{id}`
    ```sh
    curl -X GET "https://localhost:7192/api/items/60c72b2f4f1a256c8c8f0f2b"
    ```

- **POST** `/api/items`
    ```sh
    curl -X POST "https://localhost:7192/api/items" -H "Content-Type: application/json" -d '{"SerialNo":"12345","ProductBrand":"BrandX","ProductName":"ProductY","Category":"Category1","SubCategory":"SubCategoryA","Price":99.99,"Description":"A great product","StockAmount":100,"Attributes":["Feature1","Feature2"]}'
    ```

- **PUT** `/api/items/{id}`
    ```sh
    curl -X PUT "https://localhost:7192/api/items/60c72b2f4f1a256c8c8f0f2b" -H "Content-Type: application/json" -d '{"SerialNo":"12345","ProductBrand":"BrandX","ProductName":"ProductY","Category":"Category1","SubCategory":"SubCategoryA","Price":99.99,"Description":"An updated description","StockAmount":150,"Attributes":["Feature1","Feature2"]}'
    ```

- **DELETE** `/api/items/{id}`
    ```sh
    curl -X DELETE "https://localhost:7192/api/items/60c72b2f4f1a256c8c8f0f2b"
    ```

**Note:** Completing this project took 1 hour.