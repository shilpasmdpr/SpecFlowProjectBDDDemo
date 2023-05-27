Feature: ToolTip

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify ToolTip
Then Verify Widgets Option Display
	When Click on Widgets Option
	Then Verify Tool Tip Option Display
	When Click On Tool Tip Option
	When Mouse hover and Capture the value
	And Mouse hover on text box and capture the value
	And Mouse hover on contrary and capture the value
	And Mouse hover on number and capture the value