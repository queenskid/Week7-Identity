![cf](http://i.imgur.com/7v5ASc8.png) Week 7 Lab : Identity
=====================================

## To Submit this Assignment
- fork this repository (on day 26)
- create a new branch **For each lab** named `Week6DayX-`; + `<your name>` **e.g.** `Week7Day1-amanda`
- write your code
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas
- Include a Readme.md (contents described below)

## Directions
This lab will span over the course of the week. You will be building out your web app that will include .NET core Identity Framework. At the end of the week, your final submission should contain the applicaiton completed as a whole. This includes
completed documentation and tests. 
<br /> <br />

** Everyday's lab is dependant upon what we completed in class. Check back every day for the updated assignment.**

### Day 1
- Build out the beginning of your Identity site. You may use the MVC Template provided in VS
- Make updates to the template to customize it to fit the theme/topic of your appliction (i.e. update the home page,  you must use bootstrap/css/html)
- **Comment** all of the controllers (and actions), Models, DbContext, and Startup file.
  - These comments should be throurough, detailed, and should prove your understanding of the codebase

### Day 2 (Class 33)
Modifications **may** be required from your templated project....
- Create 2 different types of users (Member-type and Admin-type)
- Create a different registration page for the Admin page (this can be a hidden link)
- Attach at least 4 claims (including their Role) to the registration process.
- Redirect the user, dependant on their role, to a specific page, upon login (can you figure out how to lock down a page dependant on their Role?)
- Create a standard CRUD controller to manipulate data within your site. An example of this is my "Pages" folder in the Demo Code (you may scaffold, but be sure you comment. If you choose not to scaffold, dont forget to add your new DBContext, and views appropriately)
- Restrict your CRUD controller to specific access

### Day 3 (Class 34)
Modifications **may** be required from your templated project....
- Update your applicaiton to include at least 2 roles (based off of the ammended lecture on day 34)
- Add at least one role based policy and one custom Authorization Handler policy to your application
- Implement both of these policies in your site


## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards

- **Readme.md required for submission. Missing readme document and tests will result in a best score of 2/10**
