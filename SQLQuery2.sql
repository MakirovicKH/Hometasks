CREATE DATABASE LibraryDb

USE LibraryDb

CREATE TABLE Authors (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Surname NVARCHAR(50)
	)

	CREATE TABLE BooksDb (
    Id INT PRIMARY KEY IDENTITY, 
    AuthorId INT ,
    Name NVARCHAR(100) NOT NULL CHECK (LEN(Name) >= 2),
    PageCount INT NOT NULL CHECK (PageCount >= 10),
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
)

CREATE VIEW BookDetail_wv AS
SELECT 
    b.Id,
    b.Name,
    b.PageCount,
    a.Name + ' ' + a.Surname AS AuthorFullName -- Müəllifin tam adı
FROM 
    BooksDb b
INNER JOIN 
    Authors a ON b.AuthorId = a.Id;

	SELECT * FROM BookDetail_wv;




CREATE PROCEDURE SearchBooks
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT 
        b.Id,
        b.Name,
        b.PageCount,
        a.Name + ' ' + a.Surname AS AuthorFullName 
    FROM 
        BooksDb b
    INNER JOIN 
        Authors a ON b.AuthorId = a.Id
    WHERE 
        b.Name LIKE '%' + @SearchTerm + '%'
        OR a.Name LIKE '%' + @SearchTerm + '%'
END;

EXEC SearchBooks @SearchTerm = 'War';




CREATE FUNCTION CountBooksByPageCount (@MinPageCount INT = 10)
RETURNS INT
AS
BEGIN
    DECLARE @BookCount INT;
    
    SELECT @BookCount = COUNT(*)
    FROM BooksDb
    WHERE PageCount > @MinPageCount
    
    RETURN @BookCount;
END;

SELECT dbo.CountBooksByPageCount(5);

INSERT INTO Authors (Name, Surname) VALUES ('Fyodor', 'Dostoevsky');
INSERT INTO Authors (Name, Surname) VALUES ('Leo', 'Tolstoy');
INSERT INTO Authors (Name, Surname) VALUES ('George', 'Orwell');



INSERT INTO BooksDb (AuthorId, Name, PageCount) VALUES (1, 'Crime and Punishment', 430);
INSERT INTO BooksDb (AuthorId, Name, PageCount) VALUES (1, 'The Brothers Karamazov', 800);
INSERT INTO BooksDb (AuthorId, Name, PageCount) VALUES (2, 'War and Peace', 1225);
INSERT INTO BooksDb (AuthorId, Name, PageCount) VALUES (3, '1984', 328);