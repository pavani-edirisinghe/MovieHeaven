SELECT * FROM movies

CREATE TABLE buy_tickets
(
	id INT PRIMARY KEY IDENTITY(1,1),
	movie_id VARCHAR(MAX) NULL,
	seat_number INT NULL,
	price FLOAT,
	amount FLOAT,
	change FLOAT,
	status VARCHAR(MAX) NULL,
	created_at DATETIME
)

DROP TABLE buy_tickets

SELECT * FROM buy_tickets

SELECT capacity FROM movies WHERE delete_date IS NULL and status != 'Deleted'

SELECT movies.capacity, buy_tickets. * FROM movies LEFT JOIN buy_tickets ON movies.movie_id = buy_tickets.movie_id WHERE movies.movie_id = 'MD-001'

SELECT movie_id, price FROM movies

