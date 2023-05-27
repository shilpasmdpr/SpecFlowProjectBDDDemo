Feature: CreateUser

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario Outline: Verify User Creation
Then Verify Book Store Application Option Display
When Click on Book Store Application
Then Verify login option Display
When Click on login option
When Click on New User
Then Verify Register to Book Store Heading
When Enter FirstName <FirstName> , LastName <LastName>, UserName <UserName> and <Password>
Then Verify CAPTCHA
When Click On Register Button
Then Verify User Creation Successful Message
Examples: 
|FirstName|LastName|Password|
|Shilpa|MV|Password@123456|