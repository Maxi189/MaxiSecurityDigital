Insert Into Condominio (Nome, CEP, CodPostal, Rua, Numero, Cidade, Estado, Provincia, Pais)
     Values ('Palmares', '04844-210', null, 'Av. Dona Belmira Marin', 2000, 'São Paulo', 'SP', null, 'Brasil'),
            ('Spanish City', null, 'La Bambla', '00001', 2021, 'Barcelona', null, 'Catalunha', 'Espanha')

Insert Into Predio (Nome, Numero, IdCondominio)
     Values ('Prédio Nº1', 1, 1),
            ('Prédio Nº2', 2, 1),
            ('Prédio Nº3', 3, 1),
            ('Prédio Nº4', 4, 2),
            ('Prédio Nº5', 5, 2)

Insert Into Morador (Nome, Sobrenome, CPF, RG, DocCivil, Sexo, DataNascimento, CEP, CodigoPostal, Rua, Numero, Cidade, Estado, Provincia, Pais, Celular, Fixo, EMail, IdCondominio, Foto)
     Values ('Gustavo', 'da Silva Oliveira', '123.456.789-10', '12.345.678-9', null, 'Masculino', '2001-10-10', '04844-210', null, 'Av. Dona Belmira Marin', 2000, 'São Paulo', 'SP', null, 'Brasil', '(11) 98765-4321', '5584-9107', 'gustavo@email.com', 1, null),
            ('Teste', '2', null, null, '123-45-97', 'Feminino', '2019-10-08', null, '00001', 'La Bambla', 2021, 'Barcelona', null, 'Catalunha', 'Espanha', '12345-6789', '555-1234', 'teste@email.com', 2, null)

Insert Into Apartamento (Numero, Bloco, Ramal, IdMorador, IdPredio, IdCondominio)
     Values (54, 'Bloco 2', 'Ramal 71', 1, 4, 2),
            (76, 'Bloco 5', 'Ramal 131', 1, 1, 1)

Insert Into Visitante (Nome, Sobrenome, CPF, RG, DocCivil, Sexo, Celular, Fixo, DataNascimento, EMail, Foto)
     Values ('Juliano', 'Rosa de Jesus', '594.381.971-41', '59.587.162-7', null, 'Masculino', '(11) 68291-0271', '5556-9861', '2003-10-23', 'juliano@email.com', null),
            ('Ryan', 'Gonçalves', '555.981.089-01', '99.101.598-9', '025-10-18', 'Masculino', '(11) 84910-1018', '5481-0185', '2002-06-12', 'ryan@email.com', null)

Select * From Condominio

Select * From Predio

Select * From Morador

Select * From Apartamento

Select * From Visitante;