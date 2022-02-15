CREATE TABLE [dbo].[EmpReg]
(
	[Employee_Name] VARCHAR(50) NULL , 
    [ID] VARCHAR(50) NOT NULL, 
[Gender] VARCHAR(50) NULL,
    
    [PresentAddress] VARCHAR(50) NULL, 
    [PermanentAddress] VARCHAR(50) NULL, 
    [ContactNo] VARCHAR(50) NULL, 
    [Nationalty] VARCHAR(50) NULL, 
    [NIDNO] VARCHAR(50) NULL, 
    [Religion] VARCHAR(50) NULL, 
    [Age] VARCHAR(50) NULL, 
    [Designation] VARCHAR(50) NULL, 
  
    [HireDate] VARCHAR(50) NULL, 
    [Salary] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ID]) 
    
)
