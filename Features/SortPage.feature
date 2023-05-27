Feature: SortPage

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Sort
Then Verify Interactions Option Display
When Click On Interactions Option
Then Verify Sortable Option Display
When Click On Sortable Option
And Suffle the list
And Sort the list and verify

