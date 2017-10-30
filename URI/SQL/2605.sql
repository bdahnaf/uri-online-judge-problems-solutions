SELECT p.name,pv.name
FROM products p, providers pv
WHERE p.id_providers=pv.id
AND p.id_categories=6
