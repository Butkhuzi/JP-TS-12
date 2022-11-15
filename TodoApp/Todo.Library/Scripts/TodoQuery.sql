--CREATE DATABASE jpTs12Todo
--GO

--USE jpTs12Todo
--GO


--CREATE TABLE Users
--(
--	UserId INT PRIMARY KEY IDENTITY NOT NULL,
--	FirstName NVARCHAR(100) NOT NULL,
--	LastName NVARCHAR(200) NOT NULL,
--	FullName AS FirstName + ' ' + LastName,
--	Email VARCHAR(250) NOT NULL
--)
--GO

--ALTER TABLE [dbo].[Users]
--ADD CONSTRAINT correctEmail CHECK(Email LIKE '%@%' AND Email LIKE '%.%')
--ADD CONSTRAINT firstNameIsText CHECK (FirstName NOT LIKE '%[0-9]%')
--ADD CONSTRAINT lastNameIsText CHECK (LastName NOT LIKE '%[0-9]%')
--ADD CONSTRAINT emailIsUnique UNIQUE(Email)



--INSERT INTO Users(FirstName,LastName,Email)
--VALUES
-- (N'ნიკა',N'ჩხარტიშვილი','nika.chkhartishvili@gmail.com'),
-- (N'ივანე',N'შუბითიძე','ivane.shubitidze@gmail.com'),
-- (N'ნიკოლოზ',N'ცანავა','nikoloz.tsanava@gmail.com'),
-- (N'ლუკა',N'ზარიძე','luka.zaridze@gmail.com'),
-- (N'დემეტრე',N'დონდოლაძე','demetre.dondoladze@gmail.com'),
-- (N'გიორგი',N'ჯანიკაშვილი','giorgi.janikashvili@gmail.com')
--GO


--CREATE TABLE Todos
--(
--	TodoId INT PRIMARY KEY IDENTITY NOT NULL,
--	Title NVARCHAR(300) NOT NULL,
--	[Description] NVARCHAR(MAX) NOT NULL,
--	StartDate DATETIME NOT NULL,
--	DueDate DATETIME NOT NULL,
--	[Status] NVARCHAR(30) NOT NULL,
--	[Priority] NVARCHAR(30) NOT NULL,
--	UserId INT FOREIGN KEY REFERENCES Users(UserId)
--)
--GO

--ALTER TABLE Todos
--ADD CONSTRAINT startDateIsLessOrEqualThenDueDate CHECK(StartDate <= DueDate)
--ADD CONSTRAINT statusIsCorrect CHECK([Status] LIKE N'შესასრულებელი' OR [Status] LIKE N'მიმდინარე' OR [Status] LIKE N'შესრულებული')
--ADD CONSTRAINT priorityIsCorrect CHECK([Priority] LIKE N'დაბალი' OR [Priority] LIKE N'საშუალო' OR [Priority] LIKE N'მაღალი' OR [Priority] LIKE N'გადაუდებელი')

--INSERT INTO Todos(Title,[Description],StartDate,DueDate,[Status],[Priority],UserId)
--VALUES
--(N'ლექციის ჩატარება',N'ჩასატარებელია ლექცია და ასახსნელია ახალი თემა',GETDATE(),GETDATE(),N'მიმდინარე',N'მაღალი',1)
--(N'პროექტის დასრულება',N'დავასრულო პროექტი სამსახურისთვის',GETDATE(),GETDATE(),N'შესასრულებელი',N'გადაუდებელი',1)
--(N'ლექციაზე დასწრება',N'დავეწსრო C# - ის ლექციას',GETDATE(),GETDATE(),N'შესასრულებელი',N'გადაუდებელი',2)





