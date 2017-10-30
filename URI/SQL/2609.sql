SELECT c.name, sum(p.amount) as sum
FROM categories c, products p
where p.id_categories = c.id
group by c.name