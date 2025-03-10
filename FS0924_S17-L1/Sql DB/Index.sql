USE EpiLibrary;

INSERT INTO Books VALUES
(NEWID(), 'Angeli e demoni', 'Dan Brown', 'Romanzo', 'disponibile', null),
(NEWID(), 'Il codice Da Vinci', 'Dan Brown', 'Romanzo', 'disponibile', null),
(NEWID(), 'Il simbolo perduto', 'Dan Brown', 'Romanzo', 'indisponibile', null),
(NEWID(), 'Inferno', 'Dan Brown', 'Romanzo', 'disponibile', null),
(NEWID(), 'Origin', 'Dan Brown', 'Romanzo', 'indisponibile', null);

SELECT * FROM Books;