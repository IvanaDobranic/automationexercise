Feature: CheckOut
	As a user 
	I want to be able to add product to cart
	So I can successfully make a purchase

@mytag
Scenario: User can place an order for purchase
	Given user opens products page
		And searches for 'Winter Top' term
		And opens first search result
	When user click on Add to Cart button
		And proceeds to cart
		And shopping cart will be displayed with expected product inside
		And user click on 'Proceed To Checkout' button
		And user add comment about order
		And click on 'Place Order' button
		And user fills all required fields
		And user click on 'Pay and Confirm Order'
		Then user will successfully place an order