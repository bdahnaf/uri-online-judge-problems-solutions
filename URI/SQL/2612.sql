SELECT m.id, m.name
FROM movies m
WHERE m.id IN (SELECT DISTINCT ma.id_movies
FROM movies_actors ma, actors a
WHERE a.name = 'Marcelo Silva' AND a.id = ma.id_actors
	OR a.name = 'Miguel Silva' AND a.id = ma.id_actors)
	AND m.id IN (SELECT m.id
FROM movies m, genres g
WHERE g.description = 'Action'
AND m.id_genres = g.id)
