Feature: CheckBox
	Simple calculator for adding two numbers

@DemoQA
Scenario: Verification of the selected items
   Then Verify Check Box Display
	When Click on Check Box Option
	And the click on Toggle
	And Click on Notes checkbox
	Then Verify Notes Option selected