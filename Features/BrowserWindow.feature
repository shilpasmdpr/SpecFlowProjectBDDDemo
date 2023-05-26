Feature: BrowserWindow

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
 Scenario: Write logic to handle (New tab, New Window and New Window message)
	Then Verify Allert Frame Window Option Display
	When Click on Allert Frame Window Option
	Then Verify Browser Windows Display
	When Click on Browser Windows
	When Click On New Tab
	Then Verify New Tab Content
	When Click On New Window
	Then Verify New Window Content
	When Click On New Window
	Then Verify New Window Message

