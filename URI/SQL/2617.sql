SELECT prd.name, prv.name 
FROM providers prv, products prd
WHERE prv.name = 'Ajax SA'
AND
prd.id_providers IN 
	(SELECT id FROM providers WHERE name = 'Ajax SA')