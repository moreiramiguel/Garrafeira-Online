INSERT INTO bebidas_alcoolicas (marca, nome, naturalidade, tipo, teor, stock, price, litragem)
VALUES
    ('Johnnie Walker', 'Black Label', 'Escócia', 'Whisky', 40, 100, 10.99, 750),
    ('Jack Daniels', 'Old No. 7', 'Estados Unidos', 'Whiskey', 35, 50, 15.99, 500),
    ('Absolut', 'Vodka', 'Suécia', 'Destilado', 42, 80, 8.99, 330),
    ('Chivas Regal', '12 Years', 'Escócia', 'Whisky', 38, 120, 12.99, 500),
    ('Moët & Chandon', 'Champagne', 'França', 'Espumante', 45, 70, 19.99, 700),
    ('Beefeater', 'Gin', 'Inglaterra', 'Destilado', 40, 90, 14.99, 700),
    ('Bacardi', 'Carta Blanca', 'Cuba', 'Rum', 37.5, 60, 9.99, 700),
    ('Hennessy', 'VSOP', 'França', 'Conhaque', 40, 30, 45.99, 700),
    ('Jameson', 'Irish Whiskey', 'Irlanda', 'Whiskey', 40, 75, 23.99, 700),
    ('Patrón', 'Silver', 'México', 'Tequila', 40, 40, 49.99, 700),
    ('Ballantines', 'Finest', 'Escócia', 'Whisky', 40, 65, 19.99, 700),
    ('Captain Morgan', 'Spiced', 'Jamaica', 'Rum', 35, 50, 12.99, 700),
    ('Grey Goose', 'Vodka', 'França', 'Destilado', 40, 60, 39.99, 700),
    ('Glenfiddich', '12 Years', 'Escócia', 'Whisky', 40, 45, 34.99, 700),
    ('Havana Club', 'Añejo Especial', 'Cuba', 'Rum', 40, 55, 15.99, 700);


INSERT INTO Fornecedores_garrafeira (nome, NIF, telefone)
VALUES
    ('Fornecedor Alph', '123456789', '987654321'),
    ('Fornecedor Beta', '987654321', '123456789'),
    ('Fornecedor Gamm', '654321987', '789654321'),
    ('Fornecedor Delt', '789654321', '654321987'),
    ('Fornecedor Epsi', '321654987', '456123789'),
    ('Fornecedor Zeta', '456123789', '321654987'),
    ('Fornecedor Eta', '789321654', '654987321'),
    ('Fornecedor Thet', '654987321', '789321654'),
    ('Fornecedor Iota', '321789654', '987123456'),
    ('Fornecedor Kapp', '987123456', '456987123'),
    ('Fornecedor Lamb', '456987123', '123789456'),
    ('Fornecedor Mu', '123789456', '987456123'),
    ('Fornecedor Nu', '987456123', '789456123'),
    ('Fornecedor Xi', '789456123', '456123789'),
    ('Fornecedor Ômeg', '456123789', '321789456');

INSERT INTO Viaturas_Garrafeira(matricula, tipo, descricao)
VALUES
('A1-B2-C3', 'Camiao', ' '),
('D4-E5-F6', 'Carrinha', 'Caixa fechada '),
('G7-H8-I9', 'Carro', '2 Lugares '),
('J1-K2-L3', 'Moto', ' '),
('M4-N5-O6', 'Camiao', '250kg espaço '),
('P7-Q8-R9', 'Carrinha', 'Caixa aberta '),
('S1-T2-U3', 'Carro', ' '),
('V4-W5-X6', 'Moto', ' '),
('Y7-Z8-01', 'Camiao', ' '),
('23-45-67', 'Carrinha', ' ');

INSERT INTO Empregados(nome,NIF,telefone,salario,cargo)
VALUES
('Miguel Oliveira', '124567890', '913456789', '1105', 'Motorista'),
('Sofia Pereira', '256789012', '923456789', '1034', 'Motorista'),
('Filipe Silva', '312456789', '961234567', '1120', 'Motorista'),
('Inês Santos', '298765432', '939876543', '1002', 'Motorista'),
('Ricardo Rodrigues', '167890234', '969876543', '1150', 'Motorista'),
('Mariana Almeida', '219876543', '923456789', '1075', 'Logistica'),
('Leonardo Costa', '190238765', '913456789', '1165', 'Motorista'),
('Catarina Ferreira', '123459876', '923456789', '1095', 'Motorista'),
('Daniel Martins', '295678901', '969876543', '1178', 'Motorista'),
('Ana Sousa', '298765430', '939876543', '1032', 'Manager');
