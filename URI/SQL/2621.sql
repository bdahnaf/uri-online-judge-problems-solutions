SELECT DISTINCT prd.name
FROM products prd, providers pvd
WHERE
prd.amount BETWEEN 10 AND 20
AND
prd.id_providers IN (SELECT id FROM providers WHERE name LIKE 'P%')