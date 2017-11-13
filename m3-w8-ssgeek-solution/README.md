
# Day 1 - HTTP GET

On the Solar System Geek home page there are links for three different calculation tools to "Explore the Solar System". Implement these calculators as specified below and modify the home page links to point to your implementations.

## Alien Weight Calculator
Given a weight on earth, this calculator should compute the equivalent weight on another planet in the solar system.  Use the [gravity of the alien planet](http://www.aerospaceweb.org/question/astronomy/q0227.shtml) compared to earth gravity to calculate the alien weight.

### **Input**
![Alien Weight Calculator Input](etc/alien_weight_input.png)

### **Output**
![Alien Weight Calculator Output](etc/alien_weight_output.png)

<p style="page-break-before: always;"></p>

## Alien Age Calculator
Given an age in Earth years, this calculator should compute the equivalent age in [years for another planet in the solar system](http://www.enchantedlearning.com/subjects/astronomy/age.shtml).

### **Input**
![Alien Age Calculator Input](etc/alien_age_input.png)

### **Output**
![Alien Age Calculator Input](etc/alien_age_output.png)

<p style="page-break-before: always;"></p>

## Alien Travel Calculator
Given a destination planet, mode of transportation, and age of the traveler at the start of the journey, this calculator should compute the total travel time and age of the traveler upon arrival. The calculation should be based on the [average distance between planets in the solar system](http://theplanets.org/distances-between-planets/) and the following table of modes of transportation and their speeds:

| Mode of Transport | Speed   |
| ----------------- | ------- | 
| Walking				| 3mph    | 
| Car					| 100mph  | 
| Bullet Train		| 200mph  | 
| Boeing 747			| 570mph  | 
| Concorde			| 1350mph | 

### **Input**
![Alien Road Trip Calculator Input](etc/alien_roadtrip_input.png)

### **Output**
![Alien Road Trip Calculator Input](etc/alien_roadtrip_output.png)

<p style="page-break-before: always;"></p>

# Day 2 - HTTP POST

You are developing an online bulletin board web component for SSGeek. It is a general forum posting, so anyone is welcome to join and post without needing to login.

The feature has two requirements:
1. Provide a page that allows a site user to submit a new post to the bulletin board
2. Provide a page to view all posts on the bulletin board

A database script(`scripts/ssgeek.sql`), an interface (`IForumPostDAL`), and a data access class (for you to implement) has been provided.

**Your implementation must apply dependency injection and should be unit tested.**

## Submitting a New Post

Users can navigate to a page on the web application that provides them with a form to submit a new post for a bulletin board.

The page will provide the user with the form to submit:

* Username
* Subject
* Message

![Submit a Post](etc/new_post.png)

## Viewing a Post

The View Posts page allows users the ability to see any posts that were previously submitted to the web application.

The page should display to the user all of the prior posts. You can use any type of layout that you prefer. 

![Forum Post Listing](etc/forum_posts.png)

<p style="page-break-before: always;"></p>

## BONUS

Create a form that allows website visitors to sign up to win a prize.

Each visitor needs to provide their name, and answer a space trivia question.

Leverage HTTP POST and the Post-Redirect-Get pattern to
1. Show the user the form
2. Have the user post their answer
3. Redirect the user to the correct action based on the input

![Trivia Question](etc/bonus_survey.png)

Based on the user's answer, they will see a Correct or Incorrect page letting them know the outcome.

![Correct Page](etc/bonus_correct_answer.png)

![Incorrect PAge](etc/bonus_incorrect_answer.png)

<p style="page-break-before: always;"></p>

# Day 3 - SESSION

You'll be creating a shopping cart that allows your website visitor the ability to view products, select a product, and add it to the their shopping cart.

**You should unit test when possible**

## Product List Page

The product listing page displays all of the inventory that the SSGeek shop contains (product data is available in `scripts/ssgeek-orders.sql`).

**Requirements**

- When the user clicks on the image of a product they are navigated to the **Product Detail** page
- Use the URL pattern `/ShoppingCart/Index` 

![Product List Page](etc/products.png)

## Product Detail Page

The product detail page displays the data for a specific product and allows users to add products to their shopping cart.

**Requirements**

- When the user enters a quantity into the textbox and *presses Enter* or *presses Add to Cart* the product is added to their shopping cart
- After the user adds an item to their shopping cart, they are redirected to the View Cart page
- Use the URL pattern `/ShoppingCart/Detail/{product-id}`

![Product Detail Page](etc/product_detail.png)

## View Shopping Cart

The View Shopping Cart page displays all of the items that are in the visitor's shopping cart to purchase.

**Requirements**

- Use the URL pattern `/ShoppingCart/ViewCart`

![Shopping Cart](etc/view_cart.png)


# Day 5 - TEMPORARY REDIRECT DATA

You'll be working on the Forum Post page that you created on DAY 2 to display a confirmation message when the user posts a new forum message.

**Requirements**

- When the user visits the `Forum/` page, display a list of the existing forum posts.
- Immediately after the user submits a new Forum post from the `Forum/New` page, display the list of existing forum posts with a success message at the top.

![New Post Success](etc/new_post_success.png)
