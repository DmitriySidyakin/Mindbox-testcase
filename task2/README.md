# Тестовое задание Mindbox

## Задание 2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Также без выполненного задания отклик не будет рассмотрен.

Github или Pastebin всё еще удобнее чем поле на hh. По возможности — положите ответ рядом с кодом из первого вопроса.

## Решение

```
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nchar](100) NOT NULL
)

CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nchar](100) NOT NULL
)

CREATE TABLE [dbo].[ProductsInCategories](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	CONSTRAINT FK_ProductsInCategories_ProductId FOREIGN KEY (ProductId)
        REFERENCES dbo.Products(Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_ProductsInCategories_CategoryId FOREIGN KEY (CategoryId)
        REFERENCES dbo.Categories(Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	PRIMARY KEY (ProductId, CategoryId)
)
```

### Ответ

```
SELECT P.[Name], C.Name
	FROM [Products] AS P
	LEFT JOIN [ProductsInCategories] AS PC ON P.Id = PC.ProductId
	LEFT JOIN [Categories] C ON C.Id = CategoryId;
```