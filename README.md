# SimpleUserManagementApplication
Simple user account management application with basic CRUD operations to manage a user base.

Functionality:
* View a list of all the users with pagination
* Create a new user
* Edit a specific user's details (except password and username)
* Edit a specific user's password
* Delete a specific user
* Check username and password combination

Features:
* Styled and responsive using AngularJS Material
* 8 user accounts are seeded into database upon application startup
* Email and password pattern validation using ng-messages
* Passwords are hashed using Pbkdf2 and HMACSHA1 with a 32 byte hash and 32 byte salt
* Follows AngularJS styleguide from [here] (https://github.com/johnpapa/angular-styleguide/blob/master/a1/README.md#application-structure-lift-principle)



## Next steps
* Implement logging and exception handling
* Implement token based authorization
* Implement more nUnit tests
* Implement Angular Material datepicker
* Implement pattern validation on phone and mobile fields
* Implement better responsivity on mobile and tablet devices
