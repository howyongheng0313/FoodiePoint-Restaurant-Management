-- 在插入数据时，为了避免外键约束冲突，需要按照从父表到子表的顺序插入数据。以下是正确的插入顺序
INSERT INTO Users (UserID, Username, Password, FullName, Email, Role) VALUES
('U01', 'yonghenghow', 'yh0313', 'How Yong-Heng', 'howyongheng0313@gmail.com', 'Chef'),
('U02', 'tingyonggan', 'cat', 'Gan Ting Yong', 'charles@gmail.com', 'Manager'),
('U03', 'zhengyukuek', 'snow', 'Kuek Zheng Yu', 'leon@gmail.com', 'Reservation coordinator'),
('U04', 'yuhangleong', 'kingsley', 'Leong Yu Hang', 'kingsley@gmail.com', 'Administrator'),
('U05', 'ziyernchong', 'zyc', 'Chong Zi Yern', 'ziyernchong31313131313@gmail.com', 'Customer'),
('U06', 'demingtan', 'dmt012', 'Tan De Ming', 'deming@gmail.com', 'Customer'),
('U07', 'yanhongng', 'yhn98', 'Ng Yan Hong', 'yanhong@gmail.com', 'Customer'),
('U08', 'johndoe', 'jd08', 'John Doe', 'john@gmail.com', 'Customer'),
('U09', 'weimeng', 'wm076', 'Pang Wei Meng', 'weimeng@gmail.com', 'Customer'),
('U10', 'kevinho', 'kv09', 'Kevin Ho Jian Wei', 'kvinho@gmail.com', 'Customer');

INSERT INTO Menu (ItemID, ItemName, ItemPrice, ItemCategory) VALUES
('I01', 'Spaghetti Bolognese', 12.5, 'Western'),
('I02', 'Grilled Chicken with Rice', 15, 'Western'),
('I03', 'Sweet & Sour Chicken', 14, 'Chinese'),
('I04', 'Pineapple Juice', 5, 'Drinks'),
('I05', 'Milk Tea', 4.5, 'Drinks');

INSERT INTO Halls (HallID, HallName, HallPartyType, HallCapacity, Availability) VALUES
('H01', 'Grand Hall', 'Wedding', 200, 'Available'),
('H02', 'Small Room', 'Meeting', 50, 'Inavailable'),
('H03', 'VIP Lounge', 'Private Party', 30, 'Available'),
('H04', 'Conference', 'Business', 100, 'Available'),
('H05', 'Banquet', 'Reception', 150, 'Available');

INSERT INTO Inventory (IngredientID, IngredientName, QuantityInStock, Unit) VALUES
('ING01', 'Spaghetti', 10, 'kilogram'),
('ING02', 'Ground beef', 5, 'kilogram'),
('ING03', 'Tomato Sauce', 10, 'litre'),
('ING04', 'Onion', 50, 'pieces'),
('ING05', 'Garlic', 50, 'pieces'),
('ING06', 'Salt', 2, 'kilogram'),
('ING07', 'Black Pepper', 1, 'kilogram'),
('ING08', 'Chicken Breast', 10, 'kilogram'),
('ING09', 'Pineapple Chunks', 8, 'kilogram'),
('ING10', 'Ketchup', 5, 'litre'),
('ING11', 'Sugar', 5, 'kilogram'),
('ING12', 'Rice', 20, 'kilogram'),
('ING13', 'Milk', 10, 'litre'),
('ING14', 'Tea Leaves', 2, 'kilogram');

INSERT INTO Reservations (ReservationID, HallID, UserID, ReservationDate, ReservationType, ReservationStatus) VALUES
('RS01', 'H01', 'U05', '2025-02-17 00:00:00', 'Birthday Party', 'Completed'),
('RS02', 'H02', 'U06', '2025-02-19 00:00:00', 'Corporate Meeting', 'Confirmed'),
('RS03', 'H01', 'U07', '2025-02-27 00:00:00', 'Birthday Party', 'Confirmed');

INSERT INTO Orders (OrderID, UserID, DateTime, OrderStatus) VALUES
('OD01', 'U05', '2025-02-18 00:00:00', 'Completed'),
('OD02', 'U06', '2025-02-18 00:00:00', 'Completed'),
('OD03', 'U07', '2025-02-19 00:00:00', 'In Progress'),
('OD04', 'U08', '2025-02-19 00:00:00', 'In Progress'),
('OD05', 'U09', '2025-02-19 00:00:00', 'In Progress');

INSERT INTO Recipes (ItemID, IngredientID, Quantity) VALUES
('I01', 'ING01', 0.15),
('I01', 'ING02', 0.2),
('I01', 'ING03', 0.1),
('I01', 'ING04', 1),
('I01', 'ING05', 2),
('I01', 'ING06', 0.01),
('I01', 'ING07', 0.005),
('I02', 'ING08', 0.3),
('I02', 'ING12', 0.2),
('I02', 'ING04', 1),
('I03', 'ING08', 0.3),
('I03', 'ING09', 0.2),
('I03', 'ING10', 0.1),
('I03', 'ING06', 0.01),
('I03', 'ING07', 0.005),
('I04', 'ING09', 0.3),
('I04', 'ING11', 0.05),
('I05', 'ING11', 0.02),
('I05', 'ING13', 0.2),
('I05', 'ING14', 0.005);

INSERT INTO Requests (RequestID, ReservationID, UserRequest, Reply) VALUES
('RQ01', 'RS01', 'Provide 3 baby chairs', 'No problem!'),
('RQ02', 'RS01', 'Decorate hall with flowers', 'No problem! But we will charge extra cost.'),
('RQ03', 'RS02', 'Provide 4 baby chairs', 'No problem!');

INSERT INTO OrderItem (OrderID, ItemID, Quantity) VALUES
('OD01', 'I02', 2),
('OD01', 'I04', 2),
('OD02', 'I01', 1),
('OD03', 'I02', 2),
('OD03', 'I05', 2),
('OD04', 'I02', 1),
('OD04', 'I03', 1),
('OD04', 'I05', 1),
('OD05', 'I01', 1);

INSERT INTO Feedbacks (FeedbackID, OrderID, Feedback, Rating) VALUES
('F01', 'OD01', 'Service is good', 5),
('F02', 'OD02', 'Food is tasty', 5),
('F03', 'OD03', 'Food is normal', 3);


-- 由于存在外键约束，删除数据的顺序需要从子表（依赖其他表的表）开始，逐步删除父表（被依赖的表）的数据
DELETE FROM Feedbacks;
DELETE FROM OrderItem;
DELETE FROM Orders;
DELETE FROM Requests;
DELETE FROM Reservations;
DELETE FROM Recipes;
DELETE FROM Inventory;
DELETE FROM Halls;
DELETE FROM Menu;
DELETE FROM Users;