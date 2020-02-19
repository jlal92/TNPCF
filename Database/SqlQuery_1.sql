Create table tblMembership
(
 Id int primary key identity,
 Name nvarchar(50)
)

Insert into tblMembership values('Founder')
Insert into tblMembership values('Member')


Create table tblMember
(
 MemberId int Primary Key Identity(1,1),
 Name nvarchar(50),
 Phone nvarchar(10),
 Email nvarchar(50),
 MembershipType nvarchar (10),
 Gender nvarchar(10),
 City nvarchar(50),
 MembershipId int
)

Alter table tblMember
add foreign key (MembershipId)
references tblMembership(Id)

Insert into tblMember values('Jose', '9544613564', 'test@test.com', 'Founder','Male','Boca Raton',1)
Insert into tblMember values('Juan', '123456789', 'test2@test.com', 'Member','Male','Boynton Beach',2)
Insert into tblMember values('Kelly', '987654321', 'test3@test.com', 'Member','Female','Boca Raton',2)
Insert into tblMember values('Enrique', '7008764351', 'test4@test.com', 'Founder','Male','Ocala',1)
Insert into tblMember values('Rodolfo', '5611234567', 'Rodolfo@test.com', 'Founder','Male','Boca Raton',1)
Insert into tblMember values('Nick', '5619871234', 'Nick@test.com', 'Member','Male','Boca Raton',2)
Insert into tblMember values('Melvin', '561456789', 'Melvin@test.com', 'Founder','Male','Delray Beach',1)
