SELECT c.name
FROM customers c, legal_person lp
WHERE
c.id = lp.id_customers
