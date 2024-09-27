# SKB Kontur Internship Project

## Описание

Это проект, выполненный в рамках стажировки в компании СКБ Контур. Проект представляет собой RESTful API для управления продуктами с использованием C# и Entity Framework Core. Реализованы операции CRUD (создание, чтение, обновление и удаление) для работы с продуктами.

## Технологии

- C#
- .NET 5/6
- ASP.NET Core
- Entity Framework Core
- SQL Server (или другой)

## Установка

### Предварительные требования

- Установите [.NET SDK](https://dotnet.microsoft.com/download) (версии 5.0 или выше).
- Установите [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (или используйте другую базу данных по вашему выбору).

### Клонирование репозитория

Клонируйте репозиторий на свой компьютер:

```bash
git clone https://github.com/skoroinc/SKBKonturInternshipProject.git
cd SKBKonturInternshipProject
```


### Настройка базы данных

1. Создайте базу данных в SQL Server (или используйте существующую).
2. Измените строку подключения в appsettings.json для подключения к вашей базе данных:

  
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
   }
   
3. Примените миграции, чтобы создать таблицы:
dotnet ef database update

### Запуск приложения

Запустите приложение с помощью следующей команды:
dotnet run

API будет доступно по адресу http://localhost:5000/api/products.

## Использование

### CRUD операции

1. Получить все продукты
   - GET http://localhost:5000/api/products

2. Получить продукт по ID
   - GET http://localhost:5000/api/products/{id}

3. Создать новый продукт
   - POST http://localhost:5000/api/products
   - Тело запроса (JSON):
    
     {
         "name": "Product Name",
         "price": 19.99,
         "description": "Product Description"
     }
     
4. Обновить продукт
   - PUT http://localhost:5000/api/products/{id}
   - Тело запроса (JSON):
    
     {
         "id": 1,
         "name": "Updated Product Name",
         "price": 29.99,
         "description": "Updated Description"
     }
     
5. Удалить продукт
   - DELETE http://localhost:5000/api/products/{id}


## Контакты

Если у вас есть вопросы, вы можете связаться со мной по электронной почте: [rusichbtw@mail.ru](mailto:rusichbtw@mail.ru).

