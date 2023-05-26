/*
 -- Criação da tabela Categoria
CREATE TABLE Categoria (
    CategoriaId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255)
);

-- Criação da tabela Produto
CREATE TABLE Produto (
    ProdutoId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255),
    Preco DECIMAL(10, 2) NOT NULL,
    Imagem NVARCHAR(255),
    CategoriaId INT FOREIGN KEY REFERENCES Categoria(CategoriaId)
);

-- Criação da tabela Avaliacao
CREATE TABLE Avaliacao (
    AvaliacaoId INT IDENTITY(1,1) PRIMARY KEY,
    Pontuacao INT NOT NULL,
    Comentario NVARCHAR(255),
    DataAvaliacao DATE,
    ProdutoId INT FOREIGN KEY REFERENCES Produto(ProdutoId)
);

-- Criação da tabela Comentario
CREATE TABLE Comentario (
    ComentarioId INT IDENTITY(1,1) PRIMARY KEY,
    Texto NVARCHAR(255) NOT NULL,
    DataComentario DATE,
    ProdutoId INT FOREIGN KEY REFERENCES Produto(ProdutoId)
);

-- Criação da tabela Usuario
CREATE TABLE Usuario (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);
*/


/*

-- Inserção de dados na tabela Categoria
INSERT INTO Categoria (Nome, Descricao)
VALUES
    ('Notebooks', 'Notebooks e laptops'),
    ('Discos Rígidos', 'Discos rígidos para armazenamento'),
    ('Memórias', 'Módulos de memória RAM'),
    ('Processadores', 'Unidades de processamento central (CPUs)');

-- Inserção de dados na tabela Produto
INSERT INTO Produto (Nome, Descricao, Preco, Imagem, CategoriaId)
VALUES
    ('Notebook Dell XPS 13', 'Notebook ultrafino com tela de alta resolução', 2799.00, 'xps-13.jpg', 1),
    ('Notebook HP Spectre x360', 'Notebook conversível com design elegante', 1899.00, 'spectre-x360.jpg', 1),
    ('HD Seagate Barracuda 2TB', 'Disco rígido de 2TB para armazenamento', 79.99, 'barracuda-2tb.jpg', 2),
    ('HD Western Digital Black 1TB', 'Disco rígido de alto desempenho de 1TB', 99.99, 'wd-black-1tb.jpg', 2),
    ('Memória Corsair Vengeance RGB Pro 16GB', 'Módulo de memória DDR4 de 16GB com iluminação RGB', 129.99, 'vengeance-rgb-16gb.jpg', 3),
    ('Memória Kingston HyperX Fury 8GB', 'Módulo de memória DDR4 de 8GB para jogos', 64.99, 'hyperx-fury-8gb.jpg', 3),
    ('Processador Intel Core i9-10900K', 'Processador de 10ª geração Intel Core i9 desbloqueado', 499.99, 'i9-10900k.jpg', 4),
    ('Processador AMD Ryzen 7 5800X', 'Processador de 7ª geração AMD Ryzen 7 para alto desempenho', 399.99, 'ryzen-7-5800x.jpg', 4);
    
-- Inserção de mais produtos de informática (exemplos adicionais)
-- ...

-- Inserção de dados na tabela Avaliacao
INSERT INTO Avaliacao (Pontuacao, Comentario, DataAvaliacao, ProdutoId)
VALUES
    (4, 'Ótimo produto!', '2022-01-05', 1),
    (5, 'Recomendo!', '2022-02-10', 2),
    (3, 'Poderia ser melhor', '2022-03-15', 1);

-- Inserção de dados na tabela Comentario
INSERT INTO Comentario (Texto, DataComentario, ProdutoId)
VALUES
    ('Gostei bastante!', '2022-01-07', 1),
    ('Produto de qualidade!', '2022-02-12', 2),
    ('Podia ter mais opções de cores', '2022-03-18', 3);

-- Inserção de dados na tabela Usuario
INSERT INTO Usuario (Nome, Email)
VALUES
    ('João Silva', 'joao@example.com'),
    ('Maria Souza', 'maria@example.com');

    */
