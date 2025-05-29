CREATE TABLE buy_tickets
(
	id INT PRIMARY KEY IDENTITY(1,1),
	movie_id VARCHAR(MAX) NULL,
	seat_number INT NULL,
	price FLOAT,
	amount FLOAT,
	change FLOAT,
	show_time VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	created_at DATETIME
)

SELECT * FROM buy_tickets
TRUNCATE TABLE buy_tickets;

SELECT capacity FROM movies WHERE delete_date IS NULL and status != 'Deleted'

SELECT movies.capacity, buy_tickets. * FROM movies LEFT JOIN buy_tickets ON movies.movie_id = buy_tickets.movie_id WHERE movies.movie_id = 'MD-001'

SELECT movie_id, price FROM movies

SELECT COUNT(id) as avMovie FROM movies WHERE status = 'Available'

SELECT COUNT(id) as totalStaff FROM users WHERE role = 'Staff' AND status = 'Active'

SELECT COUNT(id) as totalBuys FROM buy_tickets WHERE status = 'PAID'

SELECT COUNT(id) FROM movies WHERE movie_id = @movieID AND id != @id