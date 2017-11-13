# Product Review Exercise

![Squirrel Cigar Parties For Dummies](etc/forDummies.png)

You have been tasked with developing a promotional site for the best selling book, **"Squirrel Parties for Dummies"** by Craig Castelaz.

**Your project should utilize dependency injection! A DAO interface has been provided and you will need to implement the interface to communicate with a database.the same DAO for viewing all reviews that have been submitted**

The home page of the site should provides a list of product reviews submitted from the web.  The application should: 

1. Providing a page that allows a site user to submit a new review
2. Display previously submitted reviews on the home page

## Submitting a New Review

Users can navigate to a page on the web application that provides them with a form to submit a new review.

The page will provide the user with the form to submit:

* Username (required)
* Rating (required) [1-5 stars]
* Review Title  (required)
* Review Text  (required)

![Submit Review Form](etc/new_review.png)

The data should be submitted via HTTP POST. Once the submission is received, it should be saved in the database. The user should be redirected to the Home Page.

## Viewing Reviews

The Home Page allows users the ability to see any reviews that were previously submitted to the web application.

The page should display to the user all of the prior reviews. You can use any format you like, this is just an example:

![Submit Review Form](etc/all_reviews.png)

