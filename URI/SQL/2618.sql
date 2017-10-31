SELECT prd.name, prv.name, cat.name
FROM products prd, providers prv, categories cat
WHERE
cat.name = 'Imported' AND prv.name = 'Sansul SA'
AND
prd.id_categories IN (SELECT id FROM categories WHERE name = 'Imported')
AND
prd.id_providers IN (SELECT id FROM providers WHERE name = 'Sansul SA')