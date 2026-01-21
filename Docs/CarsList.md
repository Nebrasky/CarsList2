# CarsList (MAUI .NET 8, Windows-only) — Codex starter file

## What we build
Create a desktop app called **CarsList** using **.NET 8 MAUI**, **Windows only**.  
The app displays a list of cars (Model, Year, MinPrice, MaxPrice) loaded from a packaged JSON file inside the project.

## Example data
JSON format (root object contains `Repositories` array):

```json
{
  "Repositories": [
    { "Model": "Mazda",  "Year": 2020, "MinPrice": 20000, "MaxPrice": 30000 },
    { "Model": "Toyota", "Year": 2019, "MinPrice": 18000, "MaxPrice": 25000 },
    { "Model": "Honda",  "Year": 2021, "MinPrice": 22000, "MaxPrice": 32000 }
  ]
}
'''
