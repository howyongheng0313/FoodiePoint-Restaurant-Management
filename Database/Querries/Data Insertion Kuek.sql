-- 由于存在外键约束，删除数据的顺序需要从子表（依赖其他表的表）开始，逐步删除父表（被依赖的表）的数据
DELETE FROM Requests;
DELETE FROM Reservations;
DELETE FROM Halls;

DELETE FROM Feedbacks;
DELETE FROM OrderItem;
DELETE FROM Orders;
DELETE FROM Users;

DELETE FROM Recipes;
DELETE FROM Inventory;
DELETE FROM Menu;

-- 在插入数据时，为了避免外键约束冲突，需要按照从父表到子表的顺序插入数据。以下是正确的插入顺序
-- MENU-INVENTORY Branch
INSERT INTO [dbo].[Menu] (ItemPrice, ItemCategory, ItemName) VALUES
(12.5, 'Western', 'Spaghetti Bolognese'),
(15  , 'Western', 'Grilled Chicken with Rice'),
(14  , 'Chinese', 'Sweet & Sour Chicken'),
(5   , 'Drinks' , 'Pineapple Juice'),
(4.5 , 'Drinks' , 'Milk Tea');

INSERT INTO [dbo].[Inventory] (QuantityInStock, Unit, IngredientName) VALUES
(10, 'kilogram', 'Spaghetti'),
(5 , 'kilogram', 'Ground beef'),
(10, 'litre'   , 'Tomato Sauce'),
(50, 'pieces'  , 'Onion'),
(50, 'pieces'  , 'Garlic'),
(2 , 'kilogram', 'Salt'),
(1 , 'kilogram', 'Black Pepper'),
(10, 'kilogram', 'Chicken Breast'),
(8 , 'kilogram', 'Pineapple Chunks'),
(5 , 'litre'   , 'Ketchup'),
(5 , 'kilogram', 'Sugar'),
(20, 'kilogram', 'Rice'),
(10, 'litre'   , 'Milk'),
(2 , 'kilogram', 'Tea Leaves');

INSERT INTO [dbo].[Recipes] (ItemID, IngredientID, Quantity) VALUES
('I001', 'ING001', 0.15),
('I001', 'ING002', 0.2),
('I001', 'ING003', 0.1),
('I001', 'ING004', 1),
('I001', 'ING005', 2),
('I001', 'ING006', 0.01),
('I001', 'ING007', 0.005),
('I002', 'ING008', 0.3),
('I002', 'ING012', 0.2),
('I002', 'ING004', 1),
('I003', 'ING008', 0.3),
('I003', 'ING009', 0.2),
('I003', 'ING010', 0.1),
('I003', 'ING006', 0.01),
('I003', 'ING007', 0.005),
('I004', 'ING009', 0.3),
('I004', 'ING011', 0.05),
('I005', 'ING011', 0.02),
('I005', 'ING013', 0.2),
('I005', 'ING014', 0.005);

-- USER Branch (using MENU)
INSERT INTO [dbo].[Users] (Username, [Password], FullName, Email, [Role]) VALUES
('yonghenghow', 'yh0313'  , 'How Yong-Heng'    , 'howyongheng0313@gmail.com' , 'Chef'),
('tingyonggan', 'cat'     , 'Gan Ting Yong'    , 'charles@gmail.com'         , 'Manager'),
('zhengyukuek', 'snow'    , 'Kuek Zheng Yu'    , 'leon@gmail.com'            , 'Reservation coordinator'),
('yuhangleong', 'kingsley', 'Leong Yu Hang'    , 'kingsley@gmail.com'        , 'Administrator'),
('ziyernchong', 'zyc'     , 'Chong Zi Yern'    , 'ziyernchong31313@gmail.com', 'Customer'),
('demingtan'  , 'dmt012'  , 'Tan De Ming'      , 'deming@gmail.com'          , 'Customer'),
('yanhongng'  , 'yhn98'   , 'Ng Yan Hong'      , 'yanhong@gmail.com'         , 'Customer'),
('johndoe'    , 'jd08'    , 'John Doe'         , 'john@gmail.com'            , 'Customer'),
('weimeng'    , 'wm076'   , 'Pang Wei Meng'    , 'weimeng@gmail.com'         , 'Customer'),
('kevinho'    , 'kv09'    , 'Kevin Ho Jian Wei', 'kvinho@gmail.com'          , 'Customer');

INSERT INTO [dbo].[Orders] (UserID, [DateTime], OrderStatus) VALUES
('U005', '2025-02-18 00:00:00', 'Completed'),
('U006', '2025-02-18 00:00:00', 'Completed'),
('U007', '2025-02-19 00:00:00', 'In Progress'),
('U008', '2025-02-19 00:00:00', 'In Progress'),
('U009', '2025-02-19 00:00:00', 'In Progress');

INSERT INTO [dbo].[OrderItem] (OrderID, ItemID, Quantity) VALUES
('OD001', 'I002', 2),
('OD001', 'I004', 2),
('OD002', 'I001', 1),
('OD003', 'I002', 2),
('OD003', 'I005', 2),
('OD004', 'I002', 1),
('OD004', 'I003', 1),
('OD004', 'I005', 1),
('OD005', 'I001', 1);

INSERT INTO [dbo].[Feedbacks] (OrderID, Feedback, Rating) VALUES
('OD001', 'Service is good', 5),
('OD002', 'Food is tasty'  , 5),
('OD003', 'Food is normal' , 3);

-- HALL Branch (using USER)
INSERT INTO [dbo].[Halls] (HallName, HallCapacity, [Availability], HallPartyType) VALUES
('Grand Hall', 200, 'Available'  , 'Wedding'),
('Small Room', 50 , 'Inavailable', 'Meeting'),
('VIP Lounge', 30 , 'Available'  , 'Private Party'),
('Conference', 100, 'Available'  , 'Business'),
('Banquet'   , 150, 'Available'  , 'Reception');

INSERT INTO [dbo].[Reservations] (HallID, UserID, GuestCount, ReservationDate, ReservationType, ReservationStatus) VALUES
('H001', 'U005', 174, '2025-02-17 00:00:00', 'Birthday Party'   , 'Completed'),
('H002', 'U006', 46 , '2025-02-19 00:00:00', 'Corporate Meeting', 'Confirmed'),
('H001', 'U007', 168, '2025-02-27 00:00:00', 'Birthday Party'   , 'Confirmed');

INSERT INTO [dbo].[Requests] (ReservationID, UserRequest, Reply) VALUES
('RS001', 'Provide 3 baby chairs'     , 'No problem!'),
('RS001', 'Decorate hall with flowers', 'No problem! But we will charge extra cost.'),
('RS002', 'Provide 4 baby chairs'     , 'No problem!');
