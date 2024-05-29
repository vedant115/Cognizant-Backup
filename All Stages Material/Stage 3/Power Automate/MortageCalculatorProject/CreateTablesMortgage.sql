-- Table for Customer Details
CREATE TABLE CustomerDetails (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(255),
    Email VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Address TEXT
);

-- Table for Mortgage Information
CREATE TABLE MortgageInfo (
    CustomerID INT,
    LoanAmount DECIMAL(15, 2),
    HomeValue DECIMAL(15, 2),
    Downpayment DECIMAL(15, 2),
    InterestRate DECIMAL(5, 2),
    DurationYears INT,
    MonthlyHOA DECIMAL(10, 2),
    AnnualPropertyTax DECIMAL(10, 2),
    AnnualHomeInsurance DECIMAL(10, 2),
    MonthlyTotal DECIMAL(15, 2),
    MonthlyMortgage DECIMAL(15, 2),
    MonthlyPropertyTax DECIMAL(10, 2),
    MonthlyAHI DECIMAL(10, 2),
    YearlyTotal DECIMAL(15, 2),
    YearlyMortgage DECIMAL(15, 2),
    YearlyPropertyTax DECIMAL(10, 2),
    YearlyHOA DECIMAL(10, 2),
    HomeInsurance DECIMAL(10, 2),
    TotalInterestPaid DECIMAL(15, 2),
    FOREIGN KEY (CustomerID) REFERENCES CustomerDetails(CustomerID)
);
