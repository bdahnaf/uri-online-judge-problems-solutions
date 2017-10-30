SELECT c.name, r.rentals_date
FROM customers c, rentals r
WHERE r.rentals_date BETWEEN '2016-09-01' AND '2016-09-30'
AND c.id = r.id_customers