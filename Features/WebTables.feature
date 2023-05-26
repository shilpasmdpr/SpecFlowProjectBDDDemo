Feature: WebTables
	Simple calculator for adding two numbers
Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title
@DemoQA
Scenario Outline: Edit the contents of the Web Table
When Click On Element Option
	Then Verify Web Tables Element Display
	When Click On Web Tables Element
	And Click On Edit Web Tables
	Then Verify Registration Heading Display
   When Enter Values Into Text Box Full Name <First Name> , Last Name <Last Name>, Email <Email>, Age <Age> ,Salary <Salary> And Department<Department> Submit
   Then Verify <First Name> , <Last Name>, <Age>, <Email> ,<Salary> ,<Department>
   Examples: 
   | First Name | Last Name | Email            | Age | Salary | Department |
   | Shilpa     | MV        | shilpa@gmail.com | 30  | 10000  | Testing    |