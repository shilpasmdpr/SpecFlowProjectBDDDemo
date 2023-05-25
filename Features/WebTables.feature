Feature: WebTables
	Simple calculator for adding two numbers

@DemoQA
Scenario: Edit the contents of the Web Table
	Then Verify Web Tables Element Display
	When Click On Web Tables Element
	And Click On Edit Web Tables
	Then Verify Registration Heading Display
   When Enter Values Into Text Box Full Name <First Name> , Last Name <Last Name>, Email <Email>, Age <Age> ,Salary <Salary> And Department<Department> Submit
   Then Verify <First Name> , <Last Name>, <Age>, <Email> ,<Salary> ,<Department>