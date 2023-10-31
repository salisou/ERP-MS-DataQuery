-- Crea il database ERP_GestioneRisorse
CREATE DATABASE ERP_GestioneRisorse;
GO

-- Usa il database appena creato
USE ERP_GestioneRisorse;
GO

-- Tabella per le informazioni sulla società
CREATE TABLE Azienda (
    IDAzienda INT PRIMARY KEY,
    NomeAzienda VARCHAR(255),
    Indirizzo VARCHAR(255),
    Telefono VARCHAR(15),
    Email VARCHAR(255)
);

-- Tabella per i dipendenti
CREATE TABLE Dipendente (
    IDDipendente INT PRIMARY KEY,
    Nome VARCHAR(50),
    Cognome VARCHAR(50),
    Email VARCHAR(255),
    Telefono VARCHAR(15),
    IDReparto INT,
    IDManager INT,
    DataAssunzione DATE
);

-- Tabella per i reparti
CREATE TABLE Reparto (
    IDReparto INT PRIMARY KEY,
    NomeReparto VARCHAR(100)
);

-- Tabella per i clienti
CREATE TABLE Cliente (
    IDCliente INT PRIMARY KEY,
    Nome VARCHAR(50),
    Cognome VARCHAR(50),
    Email VARCHAR(255),
    Telefono VARCHAR(15),
    Indirizzo VARCHAR(255)
);

-- Tabella per i fornitori
CREATE TABLE Fornitore (
    IDFornitore INT PRIMARY KEY,
    NomeFornitore VARCHAR(100),
    NomeContatto VARCHAR(100),
    Email VARCHAR(255),
    Telefono VARCHAR(15),
    Indirizzo VARCHAR(255)
);

-- Tabella per i prodotti
CREATE TABLE Prodotto (
    IDProdotto INT PRIMARY KEY,
    NomeProdotto VARCHAR(255),
    Descrizione TEXT,
    PrezzoUnitario DECIMAL(10, 2),
    QuantitaMagazzino INT,
    IDFornitore INT,
    IDCategoria INT
);

-- Tabella per le categorie di prodotti
CREATE TABLE Categoria (
    IDCategoria INT PRIMARY KEY,
    NomeCategoria VARCHAR(100)
);

-- Tabella per gli ordini
CREATE TABLE Ordine (
    IDOrdine INT PRIMARY KEY,
    IDCliente INT,
    DataOrdine DATE,
    ImportoTotale DECIMAL(10, 2),
    Stato VARCHAR(50)
);

-- Tabella per gli elementi dell'ordine
CREATE TABLE ElementoOrdine (
    IDElementoOrdine INT PRIMARY KEY,
    IDOrdine INT,
    IDProdotto INT,
    Quantita INT,
    PrezzoUnitario DECIMAL(10, 2)
);

-- Altre tabelle, come fatture, pagamenti, inventario, ecc., possono essere aggiunte in base alle esigenze specifiche.

-- Chiavi esterne
ALTER TABLE Dipendente ADD FOREIGN KEY (IDReparto) REFERENCES Reparto(IDReparto);
ALTER TABLE Dipendente ADD FOREIGN KEY (IDManager) REFERENCES Dipendente(IDDipendente);
ALTER TABLE Prodotto ADD FOREIGN KEY (IDFornitore) REFERENCES Fornitore(IDFornitore);
ALTER TABLE Prodotto ADD FOREIGN KEY (IDCategoria) REFERENCES Categoria(IDCategoria);
ALTER TABLE Ordine ADD FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente);
ALTER TABLE ElementoOrdine ADD FOREIGN KEY (IDOrdine) REFERENCES Ordine(IDOrdine);
ALTER TABLE ElementoOrdine ADD FOREIGN KEY (IDProdotto) REFERENCES Prodotto(IDProdotto);


-- Inserisci dati nella tabella Azienda
INSERT INTO Azienda (IDAzienda, NomeAzienda, Indirizzo, Telefono, Email)
VALUES (1, 'Azienda di Esempio', '123 Via Prova', '1234567890', 'azienda@example.com');

-- Inserisci dati nella tabella Reparto
INSERT INTO Reparto (IDReparto, NomeReparto)
VALUES (1, 'Reparto Amministrativo'),
       (2, 'Reparto Vendite'),
       (3, 'Reparto Produzione');

-- Inserisci dati nella tabella Dipendente
INSERT INTO Dipendente (IDDipendente, Nome, Cognome, Email, Telefono, IDReparto, IDManager, DataAssunzione)
VALUES (1, 'Mario', 'Rossi', 'mario@example.com', '9876543210', 1, NULL, '2023-01-15'),
       (2, 'Laura', 'Bianchi', 'laura@example.com', '1234567890', 2, 1, '2023-02-20'),
       (3, 'Luigi', 'Verdi', 'luigi@example.com', '5555555555', 3, 2, '2023-03-10');

-- Inserisci dati nella tabella Categoria
INSERT INTO Categoria (IDCategoria, NomeCategoria)
VALUES (1, 'Elettronica'),
       (2, 'Abbigliamento'),
       (3, 'Alimentari');

-- Inserisci dati nella tabella Fornitore
INSERT INTO Fornitore (IDFornitore, NomeFornitore, NomeContatto, Email, Telefono, Indirizzo)
VALUES (1, 'Fornitore 1', 'Contatto 1', 'fornitore1@example.com', '1111111111', 'Via Fornitore 1'),
       (2, 'Fornitore 2', 'Contatto 2', 'fornitore2@example.com', '2222222222', 'Via Fornitore 2');

-- Inserisci dati nella tabella Prodotto
INSERT INTO Prodotto (IDProdotto, NomeProdotto, Descrizione, PrezzoUnitario, QuantitaMagazzino, IDFornitore, IDCategoria)
VALUES (1, 'Prodotto A', 'Descrizione prodotto A', 19.99, 100, 1, 1),
       (2, 'Prodotto B', 'Descrizione prodotto B', 29.99, 50, 2, 2),
       (3, 'Prodotto C', 'Descrizione prodotto C', 9.99, 200, 1, 3);

-- Inserisci dati nella tabella Cliente
INSERT INTO Cliente (IDCliente, Nome, Cognome, Email, Telefono, Indirizzo)
VALUES (1, 'Cliente 1', 'Cognome 1', 'cliente1@example.com', '3333333333', 'Via Cliente 1'),
       (2, 'Cliente 2', 'Cognome 2', 'cliente2@example.com', '4444444444', 'Via Cliente 2');

-- Inserisci dati nella tabella Ordine
INSERT INTO Ordine (IDOrdine, IDCliente, DataOrdine, ImportoTotale, Stato)
VALUES (1, 1, '2023-04-05', 49.98, 'In corso'),
       (2, 2, '2023-04-10', 19.99, 'Completato');

-- Inserisci dati nella tabella ElementoOrdine
INSERT INTO ElementoOrdine (IDElementoOrdine, IDOrdine, IDProdotto, Quantita, PrezzoUnitario)
VALUES (1, 1, 1, 2, 19.99),
       (2, 1, 3, 3, 9.99),
       (3, 2, 2, 1, 29.99);

select * from Azienda;
select * from Categoria;
select * from Cliente;
select * from Dipendente;
select * from ElementoOrdine;
select * from Fornitore;
select * from Ordine;
select * from Prodotto;
select * from Reparto;