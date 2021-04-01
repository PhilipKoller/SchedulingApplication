
Test ID | Req No. | Test Procedure | Status | TimeStamp
--------|---------|----------------|--------|------
1|1.0 | Upon visual inspection when opening a web browser and going to the correct domain check to make sure the first page displayed is the login screen | Passed | 10/15/20
2|1.1 | Write a test method that will check to make sure the system does in fact have administrative capability |  Not Tested | 
3|1.2 | Login to the system and check to see if a dialogue box appears with access granted written in it | Passed | 10/20/20
4|1.2.1 | Login to the system and check to see if a dialogue box appears with access denied when incorrect credentials are entered | Passed | 10/20/20
5|2.0 | Login click the scheduling tab verify that you are presented with a calendar like view | Passed | 10/29/20
6|2.1 | Using administrative credentials login to the system click the calendar view click the tools button verity that you have access | Failed | 10/30/20
7|3.0 | Login to the system with user credentials click the scheduling tab click all dates on the calendar ensure a dialogue box appears with each | Failed | 10/30/20
8|3.1 | In the calendar view with user credentials click the day you want to schedule. Confirm it and inspect to see if the day in the calendar view turns green | Passed | 10/30/20
9|4.0 | Login with user credentials verify that the username is displayed in the upper right-hand corner of the screen throughout the application | Passed | 10/31/20
10|4.1 | Login with user credentials verify that name is displayed in the upper right-hand corner with the font color black | Passed | 10/31/20
11|5.0 | Login with user credentials verify that a footer is placed |  Not Tested | 
12|5.1 | Login with user credentials verify that a footer is placed with the color light blue |  Not Tested | 
13|6.1 | Login to the system with user credentials, click the scheduling tab, click a date when the dialogue box appears. Verify there is a field that ask the user to opt-in for text messaging|  Not Tested | 
14|7.0 | With user credentials schedule and confirm a date in the calendar.Once scheduled login with different user credentials click the calendar view click the same date scheduled previously verify that a message box is displayed prompting the user that the date is already taken |  Not Tested | 
15|7.2 | With user credentials login click the calendar tab click on a scheduled date verify that the dialogue box flashes red when displayed |  Not Tested | 
16|8.0 |Create a new user account click the tab to the calendar view. Verify that the step by step image is displayed showing the user around |  Not Tested | 

------

Test Readiness Review | % | 
--------|---------|
What percent of requirements are (currently) covered by test cases? | 45%
What percent of test cases are currently passing? | 37.5%
