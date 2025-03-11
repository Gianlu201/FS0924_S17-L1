USE EpiLibrary;

INSERT INTO Books VALUES
(NEWID(), 'Angeli e demoni', 'Dan Brown', 'Romanzo', 0, 'https://books.google.it/books/content?id=hv7hjasiYhoC&hl=it&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U3ZxLtjh5IYxn0E6wC8BeMSjsY0WQ&w=1280'),
(NEWID(), 'Il codice Da Vinci', 'Dan Brown', 'Romanzo', 1, 'https://books.google.it/books/publisher/content?id=X0UfDQAAQBAJ&hl=it&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U0LO4BT38Zo4H-6X0SfWjR3VtD-XQ&w=1280'),
(NEWID(), 'Il simbolo perduto', 'Dan Brown', 'Romanzo', 1, 'https://books.google.it/books/content?id=_yltNA0olusC&hl=it&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U3fLnlyRuxWvtMbKWoBJyypvdsbcA&w=1280'),
(NEWID(), 'Inferno', 'Dan Brown', 'Romanzo', 1, 'https://books.google.it/books/content?id=JYyPqYjhKSIC&hl=it&pg=PA1&img=1&zoom=3&bul=1&sig=ACfU3U3L9b9ZkHfk3ZOpClA30kzEsCGCdg&w=1280'),
(NEWID(), 'Origin', 'Dan Brown', 'Romanzo', 1, 'https://books.google.it/books/publisher/content?id=45U0DwAAQBAJ&hl=it&pg=PA1&img=1&zoom=3&bul=1&sig=ACfU3U3mHxOElz8s9vQGkU0QAvJxF8sq-Q&w=1280');

SELECT * FROM Books;