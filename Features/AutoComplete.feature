Feature: AutoComplete

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Auto Complete
Then Verify Widgets Option Display
	When Click on Widgets Option
	Then Verify Auto Complete Display
	When Click on Auto Complete
	And Enter Type multiple color names
