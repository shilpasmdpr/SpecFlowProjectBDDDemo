﻿Feature: UploadsAndDownloads

Background: Launch Demo QA Page
	Given Launch Demo QA URL
	Then Verify Demo QA page title

@DemoQA
Scenario: Verify Upload and Download 
    When Click On Element Option
	And Click on Upload And Download Element
	And Click on choose file and Upload a file
	Then Verify file uploaded successfully
	When Click on download button
	Then Verify file downloaded successfully

