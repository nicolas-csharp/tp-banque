-- Création de la table des clients
CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL,
    Prenom NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Telephone NVARCHAR(20),
    DateNaissance DATE
);

-- Création de la table des comptes bancaires
CREATE TABLE Comptes (
    CompteID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL FOREIGN KEY REFERENCES Clients(ClientID),
    Solde DECIMAL(18, 2) NOT NULL,
    DateCreation DATE DEFAULT GETDATE()
);

-- Insertion de quelques données dans la table Clients
INSERT INTO Clients (Nom, Prenom, Email, Telephone, DateNaissance)
VALUES 
('Dupont', 'Jean', 'jean.dupont@example.com', '0612345678', '1985-05-12'),
('Martin', 'Sophie', 'sophie.martin@example.com', '0623456789', '1990-11-23');

-- Insertion de quelques données dans la table Comptes
INSERT INTO Comptes (ClientID, Solde)
VALUES 
(1, 1500.00),
(2, 2300.50);
