SELECT p.name, c.name 
FROM products p, categories c 
WHERE p.amount > 100 AND  p.id_categories=c.id 
AND p.id_categories in (1,2,3,6,9);
