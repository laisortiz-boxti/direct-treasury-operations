CREATE TABLE DirectTreasuryOperations -- Campos do arquivo OperacoesTesouroDireto.csv
(
	Id 			     INT AUTO_INCREMENT PRIMARY KEY,
    InvestorCode     INT, -- Codigo do Investidor	
    OperationDate    DATE, -- Data da Operacao
    BondType  		 VARCHAR(200), -- Tipo Titulo
    BondMaturityDate DATE, -- Vencimento do Titulo
    Quantity 		 DOUBLE, -- Quantidade
    BondAmount 		 DECIMAL (20, 10), -- Valor do Titulo	
    OperationAmount  DECIMAL (20, 10) -- Valor da Operacao
);

-- Em outra tabela, salvar a diferença do Valor (valor da operação) entre os dias (data da operação)
CREATE TABLE OperationAmounts
(
	AmountDifference 	 DECIMAL (20, 10),
    InitialOperationDate DATE,
    FinalOperationDate 	 DATE
);