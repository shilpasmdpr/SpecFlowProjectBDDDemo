Feature: Button

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify the button selected by the message displayed on button click
	Then Verify Button Element Display
	When Click on Button Element
	Then Verify Button Page Heading
	When Double Click on Double Click Me Button
	Then Verify Double Click Me message
	When Right Click on Right Click Me Button
	Then Verify Right Click Me  message
	When Click on Click Me Button
	Then Verify Click Me message
