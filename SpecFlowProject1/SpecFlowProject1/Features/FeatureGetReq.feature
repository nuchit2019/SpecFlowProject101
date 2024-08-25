Feature: FeatureGetReq

A short summary of the feature

@tag1
Scenario: Get Request Test
	Given the user send a get request with url as "https://reqres.in/api/users/2"	 
	Then request shold be success with 200s codes
