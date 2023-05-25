Feature: Element

A short summary of the feature

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title
@DemoQA
Scenario Outline: Verify Text Elements
	Then Verify Element Display
	When Click On Element Option
	Then Verify Text Box Option Display
	When Click On Text Box Option
	Then Verify Text Box heading Display
	And Verify Text Fields
	When Enter Values Into Text Box Full Name <Full Name> , Email <Email>,Current Address<Current Address>And Permanent Address<Permanent Address> Submit
	Then Verify <Full Name>,<Email>,<Current Address>And <Permanent Address> Values
	Examples: 
	| Full Name | Email                  | Current Address | Permanent Address |
	| Shilpa | shilpa@gmail.com                  | Current Address | Permanent Address |
	
