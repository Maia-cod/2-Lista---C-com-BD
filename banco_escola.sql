CREATE DATABASE IF NOT EXISTS escola;

USE escola;

CREATE TABLE IF NOT EXISTS Alunos (
    matricula INT NOT NULL PRIMARY KEY,
    nome       VARCHAR(100) NOT NULL,
    n1         DOUBLE,
    n2         DOUBLE,
    media      DOUBLE,
    status     VARCHAR(20)
);

-- Dados de exemplo (opcional)
INSERT INTO Alunos (matricula, nome, n1, n2, media, status)
VALUES (1, 'Maria Silva', 8.5, 7.0, 7.75, 'Aprovado');

SELECT * FROM Alunos;
