SELECT cu.id, cu.name
FROM customers cu WHERE cu.id not in (select id_customers from locations)