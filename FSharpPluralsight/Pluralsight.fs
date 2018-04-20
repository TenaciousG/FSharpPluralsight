﻿module Pluralsight

let square x = x * x

//Map the following into a list: the result of the function square for each item in the list: [1;2;3]
let squared = List.map square [1;2;3] 

//disse er like:
square 3 + 1
(square 3) + 1


let distance x y = x - y |> abs
let distance2 x y = abs x - y

let d1 = distance 10 5 // = 5
let d2 = distance2 10 5 // = 5

// Function type signature
//val square : x:int -> int
// first comes types of function arguments
// value after last arrow is return type

//Higher order functions (functions that takes functions as arguments)
// List.map
//val it : (('a -> 'b) -> 'a list -> 'b list)
// 'a means unconstrained type variable. can be substituted for any concrete type (generics?)
//so... function first parameter is a function that takes any type (a) and returns any type (b)
//second parameter is a list of a (why not 'a:list ??)
//function returns a list of b (why not 'b:list ??)



//currying
//  Currying is when you break down a function that takes multiple arguments into a series of functions that take part of the arguments
//partial application
//  applying some, but not all of a functions arguments
let distanceFrom5 = distance 5
//val distanceFrom5 : (int -> int)
distanceFrom5 -5
(distance 5) 2 //another way of doing this. the parenthesis will evaluate to a function first, then pass 2 as argument



//prefix functions
//  function name comes first, and arguments follow after
//infix function
//  referred to an operator in f#
//  (+) 1 3

// home made infix operator
let (+--&) x y = x + y
3 +--& 5 // 8
3 +--& 5 +--& 2 //10


//Anonymous functions or Lambda expressions
// fun: identifies a lambda
// x is parameter
// -> points at function body
List.map (fun x -> x * x) [1;2;3] //[1,4,9]
//distance function
(fun x y -> x - y |> abs) 20 35 //15
//can specify types if neccessary
(fun (x:int) (y:int) -> x - y |> abs) 20 35 //15


//Recursive function
// rec means recursive function
let rec recTill20 x = 
    let count = x + 1
    if count = 20 then
        count
        else recTill20 count
recTill20 1
//
// better way of writing it:
// function indicates a pattern matching function (argument is anonymous, because it goes straight into pattern match, and is not called by name)
// count is a variable pattern (it will match on any value, and the argument is assigned to the variable and can be reused in the expression)
let rec recTill25 = function
    | 20 -> 20
    | count -> recTill25 (count + 1)

//another example
// [] is empty list *base case
// x::xs means x=head of list, xs=tail of list
// returns 1 plus length of rest of list
let rec length = function
    | [] -> 0
    | x::xs -> 1 + length xs

length [1;2;5]

//factorial
//let rec factorial n =
//        if n < 2 then
//            1
//        else
//            n * factorial (n-1)



 //Piping
 sin 7.
 
 //7. |> sin

 //7. |> sin
