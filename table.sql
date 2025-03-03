CREATE TABLE FoodMenu 
(
    FoodID INT PRIMARY KEY IDENTITY(1,1),
    CuisineType NVARCHAR(MAX),
    FoodName NVARCHAR(MAX),
);

INSERT INTO FoodMenu (CuisineType, FoodName) VALUES
('Western', 'Burger'),
('Western', 'Steak'),
('Western', 'Pasta'),
('Western', 'Pizza'),
('Chinese', 'Dim Sum'),
('Chinese', 'Fried Rice'),
('Chinese', 'Peking Duck'),
('Chinese', 'Kung Pao Chicken'),
('Korean', 'Bibimbap'),
('Korean', 'Bulgogi'),
('Korean', 'Tteokbokki'),
('Korean', 'Japchae');

SELECT * FROM FoodMenu;