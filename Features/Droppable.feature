Feature: Droppable

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Droppable
Then Verify Interactions Option Display
When Click On Interactions Option
Then Verify Droppable Option Display
When Click On Droppable Option
And Perform drag and drop
Then Verify the dropped message
