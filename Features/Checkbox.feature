Feature: Checkbox
	Simple calculator for adding two numbers
Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title
@DemoQA
Scenario: Verification of the selected items
   Then Verify Check Box Display
	When Click on Check Box Option
	And the click on Toggle
	And Click on Notes checkbox
	Then Verify Notes Option selected