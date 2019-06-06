CREATE TABLE Suppliers(
	Id INT Identity(1,1) NOT NULL,
	SupplierId UniqueIdentifier NOT NULL,
	Name VARCHAR(150) NOT NULL,
	Address VARCHAR(300) NOT NULL,
	ContactNumber VARCHAR(30),
	IsActive BIT DEFAULT(0) NOT NULL,
	Remarks VARCHAR(500) NULL,
	PRIMARY KEY(SupplierId)
)
