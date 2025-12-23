````md
# Inventory Management API

A small **ASP.NET Core Web API** built with **C# / .NET 8**.

I created this project to practice C#/.NET stack.

---

## What it does

- CRUD endpoints for **Products**
- In-memory storage
- Swagger UI for quick testing

---

## Endpoints

GET  `/api/Products`  Get all products
GET  `/api/Products/{id}`  Get one product by id
POST  `/api/Products`  Create a product
PUT `/api/Products/{id}`  Update a product
DELETE `/api/Products/{id}`  Delete a product

---

## Example request body

```json
{
  "name": "Canadian Club 750ML",
  "category": "Rye",
  "quantity": 2,
  "price": 51.98
}
````

---

## Run it locally

1. Install the **.NET 8 SDK** 

2. Start the API

```bash
dotnet run
```

3. Open Swagger

Go to:

`http://localhost:5056/swagger`

---

## Planned improvements

As I apply what I learned in backend dev this term, I'm thinking add on this project with:

* **Firebase Firestore** to replace in-memory data
* **Firebase Authentication** to secure write endpoints
* Basic authorization rules for create/update/delete

---
