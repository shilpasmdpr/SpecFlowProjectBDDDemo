Feature: DatePicker

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Date Picker
Then Verify Widgets Option Display
	When Click on Widgets Option
	Then Verify Date Picker Display
	When Click on Date Picker
	And Update The Date 
	When Update Date And Time
