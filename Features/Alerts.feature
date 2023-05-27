Feature: Alerts

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Alert
Then Verify Allert Frame Window Option Display
	When Click on Allert Frame Window Option
	Then Verify Alert Menu Display
	When Click On Alert Tab
	And Click on Click Button to see alert
	Then Verify Alert and Click On OK
	When Click on On button click, alert will appear after seconds
	Then Verify Appear Alert and Click On OK
	When Click On button click, confirm box will appear
	Then Verify Appear Alert and Click On Cancel
	When Click On button click, prompt box will appear
	And Enter text and Click On OK
