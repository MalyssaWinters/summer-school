# Summer School

## Overview

Write a program that implements a wild set of business rules for a summer program at a very special school.

## Tasks

### Primary Tasks

- [ ] Yak Shaving
  - [ ] Create a Console Application project in Visual Studio called `SummerSchool` including a Git repository
  - [ ] Create a remote repository called `summer-school` and link it to your local repo
  - [ ] Create a `README` file in your repository explaining what this project will involve
- [ ] Menu
  - [ ] Hide enroll/unenroll based on current enrollment number
- [ ] Enroll a student
  - [ ] Show enrollment cost
- [ ] Unenroll a student
  - [ ] Show the name of the student
- [ ] Print out list of enrolled students
  - [ ] Include amount student will owe
- [ ] Calculate amount students owe
  - [ ] Malfoy
  - [ ] Potter
  - [ ] Tom/Riddle/Voldemort
  - [ ] Longbottom
  - [ ] Alliteration

### Stretch Tasks

- [ ] Calculate amount students owe
  - [ ] Weasley/Granger
  - [ ] Athletic scholarships
- [ ] Colorful output

## Details

In this project, you will write a console-based system that will take in and process student enrollments.

Your program will start by showing a menu of choices, and doing different things based upon what the user chooses.

Here is an example of what the menu might look like:

```
1. Enroll a student
2. Unenroll a student
3. Print out the list of enrolled students
4. Exit
>
```

Enrollment is limited to 15 students. If the maximum number of enrolled students has been reached, then don't show the "Enroll a student" option. Likewise, if no students are enrolled yet, don't show the "Unenroll a student" option.

Enrollment costs `£200`. When a student is enrolled, a message needs to be printed out saying how much money the student will owe.

When you display the list of students, put the amount each student will owe next to the student's name, and display the overall total of the enrollment fees at the end of the list.

```
1. Angelina	Thornton (£200)
2. Pam Barnett (£200)
3. Carol Gomez (£190)
4. Marty Marshall (£180)
5. Gordon Griffith (£180)
6. Alison Gomez (£190)
7. Kyle Lawson (£200)

Total: £1360
```

When a user chooses to enroll a student, ask them for the name of the student, and save it to whatever data structure you are using.

```
1. Enroll a student
2. Unenroll a student
3. Print out the list of enrolled students
4. Exit
> 1
What is the name of the student to enroll?
> Angelina Thornton
Angelina Thornton is now enrolled and will need to pay £200.
```

When a user chooses to unenroll a student, display a list of the enrolled students, and let them choose the student to unenroll by typing the number next to them. Confirm their choice after they make it.

```
1. Enroll a student
2. Unenroll a student
3. Print out the list of enrolled students
4. Exit
> 2
1. Angelina	Thornton (£200)
2. Pam Barnett (£200)
3. Carol Gomez (£190)
4. Marty Marshall (£180)
5. Gordon Griffith (£180)
6. Alison Gomez (£190)
7. Kyle Lawson (£200)
Which student would you like to unenroll?
> 5
Gordon Griffith has been unenrolled.
```

After any choice, you should return the user to the main menu.

### Special Cases

This school has a history with certain students, though, and has some rules that it needs to follow when enrolling students.

1. Students with the last name `Malfoy` are not to be admitted. If someone tries to enroll a `Malfoy`, print out an error message and do not add the student to the list.
1. Students with the last name `Potter` are to be charged a reduced rate. It should be 50% of the normal rate.
1. If `Tom`, `Riddle`, or `Voldemort` is in any part of a student's name, we need to do something special. Check with `@mcgonagall` on Slack to find out more information about what to do.
1. `Longbottom`s are to be admitted free of charge, as long as less than 10 students are enrolled.
1. Students with a last name that starts with the same letter as their first name receive a 10% discount.

### Stretch Tasks

The tasks below can make the project significantly more complicated. These are _optional_, **stretch** tasks for a reason!

Enhance the user interface. When printing out the list of students, highlight any special cases (ones that don't have to pay the full price) in a different color, such as yellow or cyan.

#### Extra Special Cases

1. If a `Weasley` or `Granger` enrolls, that student does not have to pay an enrollment fee, and every other student receives a 5% discount (Hermione will be teaching the course, and she said she'd charge less if any member of her family is in the course).
1. A number of students qualify for athletic scholarships. If they have the same last name as any known member of the English National Quidditch team, give them a 30% discount.




## Hints

It's generally a good idea to split your task into _methods_, especially if you need to calculate something repeatedly. Methods are also great for helping you break a large problem down into smaller problems. Start by identifying what methods might be useful in this project, and write and test those first.

There are going to be some things that are ambiguous in this project. You should use your judgment as a developer to clarify requirements that you think need to be clarified, or just make a call one way or the other based upon what you think the client wants.

If you're attempting the stretch tasks, you will probably need to look up how to use things that we haven't talked about in class. This is excellent practice!
