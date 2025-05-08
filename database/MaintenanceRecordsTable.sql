CREATE TABLE MaintenanceRecords (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CarId INT FOREIGN KEY REFERENCES Cars(Id),
    ServiceType NVARCHAR(100),
    ServiceDate DATE,
    Mileage INT,
    Notes NVARCHAR(500)
);
