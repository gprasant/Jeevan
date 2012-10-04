Jeevan  Stem cell bank
--------------------------

Hi, 

We're a Doctor and a programmer team trying it to make stem cell treatment easier one step at a time. This project is an inventory for embryonic stem cells  along with a stem cell matching algorithm. 

### Features included in first release 
 * Inventory management of cord blood units. 
 * Stem cell matching algorithm and request notification. 
 
### Match request
 The matching algorithm works based on a 6D vector of [alleles](http://en.wikipedia.org/wiki/Human_leukocyte_antigen#Examining_HLA_types). 
 The alleles are of the form (HLA A1, HLA A2, HLA B1, HLA B2, DRB 1, DRB 2). A successful match should satisfy 2 criteria : 
  
  1. The DRB components should be identical for both the compared samples. 
  	
  	for eg. 
  	(1, 2, 3, 4, 5, 6) and (1, 2, 3, 4, 5, 5) are **not** allowed matches
  
  2. The number of total matches between components of the 2 compared samples should not be less than 5.  
    
	  for eg. 
	  (1, 2, 3, 4, 5, 6) and (1, 2, 3, 3, 5, 6) is an allowed match
	  but (1, 2, 3, 4, 5, 6) and (1 , 2, 2, 2, 5, 6) is **not**
 
### Getting started

**Getting started with Git and GitHub**

 * [Setting up Git for Windows and connecting to GitHub](http://help.github.com/win-set-up-git/)
 * [Forking a GitHub repository](http://help.github.com/fork-a-repo/)
 * [The simple gude to GIT guide](http://rogerdudler.github.com/git-guide/)


### Discussing ideas 

* [Trello Board](https://trello.com/board/jeevanbank/4f9be89b27b09e4124312c5c) - add ideas, or claim an idea and start working on it!


 


