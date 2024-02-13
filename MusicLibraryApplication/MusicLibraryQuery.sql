-- This query assumes artists and tracks have a foreign key relationship
-- Used AS to rename artists for the query as it just makes more sense to me as I write the query out, although unsure if this would
-- be best practice.
SELECT
  artists.name AS artists
  , tracks.title
  , tracks.genre
  , tracks.duration
FROM
  tracks
  JOIN artists
ON tracks.artistID = artists.artistID
WHERE
  tracks.releaseYear = > DATEADD(year, -1, GETDATE()) -- checks if releaseDate is since last year, using GETDATE() method
ORDER BY
  artists.name ASC
  , tracks.title ASC;