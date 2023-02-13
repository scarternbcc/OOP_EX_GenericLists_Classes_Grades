# Generic List Exercise - Grades

Using the starter file provided and the video, code the form to allow Professor Carver to display a grade based on the number of points she enters:

The grading scale is as follows:

| Minimum Points | Maximum Points | Grade |
| -------------- | -------------- | ----- |
| 0              | 299            | F     |
| 300            | 349            | D     |
| 350            | 399            | C     |
| 400            | 449            | B     |
| 450            | 500            | A     |

1. Create a class called **GradeInfo** in a new file that has an **integer** field named **maxPoints** and a **string** field named **letterGrade**.

2. In the **form**, create a method called **MakeEntry**.  It should have **2 parameters** - 1 named **value** and the other named **grade**.  The responsibility of the method is to create a new instance of **GradeInfo**, set its attributes to the values passed in as arguments,  and add it to a Generic List of **GradeInfo** called **grades**.  The grades generic list should be declared as a form field so it has form level scope, and you should instantiate it at the time of declaring it.

3. On **form load**, populate the **grades** list for each grade in the scale above by calling the **MakeEntry** method 5 times.

4. When **Find Grade** button is clicked

   1. Ensure that the user entered a valid integer between 0 and 500.  If they did not display a message (see video)

   2. If the number they entered is valid, use LINQ to find the letter grade for the score that is entered and display it in a message box. (HINT:  .FirstOrDefault())

      

