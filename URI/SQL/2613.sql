SELECT m.id, m.name
FROM movies m, prices p
WHERE m.id_prices = p.id
AND p.value < 2.00
