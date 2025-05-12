//Numbers, sequences/lists, mapping, filtering, folding

//1. Given a list of integers, return a new list with each element squared
//let squareList (numbers: int list) : int list =
//  numbers |> List.map (fun x -> x * x)
//let input = [1; 2; 3; 4; 5]
//let result = squareList input
//printfn "Squared list: %A" result

//2.Write a function that filters out all odd numbers from a given list of integers, returning a list of only the even numbers.
//let filterEvenNumbers (numbers: int list) : int list = 
//    numbers |> List.filter (fun x -> x % 2 = 0)
//let input = [1; 2; 3; 4; 5]
//let evenNumbers = filterEvenNumbers input
//printfn "Even numbers: %A" evenNumbers

//3.Write a function that takes a list of numbers and returns the sum of all positive numbers in the list.
//let sumPositiveNumbers (numbers: int list) : int =
//    numbers |> List.filter (fun x -> x > 0) |> List.sum
//let input = [-1; 2; -3; 4; -6; 5]
//let sum = sumPositiveNumbers input
//printfn "Sum of positive numbers: %d" sum

//4.Given a list of names (strings), return a new list with each name capitalized.
//let capitalizeNames (names: string list) : string list =
//    names |> List.map (fun x -> x.ToUpper())
//let input = ["Levi"; "Éva"; "Zsófi"; "László"]
//let result = capitalizeNames input
//printfn "Capitalized names: %A" result

//5.Write a function that takes a list of strings and an integer n, returning a list of strings where each string has a length greater than n.
//let filterStringsByLength (strings: string list) (n: int) : string list =
//    strings |> List.filter (fun x -> x.Length > n)
//let input = ["Csemegy"; "Káposzta"; "cseresznye"; "Kecske"]
//let result = filterStringsByLength input 5
//printfn "Strings with length greater than 5: %A" result

//6.Write a function that takes a list of integers and an divisor, and returns the count of numbers which are divisible by it.
//let countDivisibleBy (numbers: int list) (divisor: int) : int =
//    numbers |> List.filter (fun x -> x % divisor = 0) |> List.length
//let input = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
//let divisor = 2
//let count = countDivisibleBy input divisor
//printfn "Numbers divisible by %d: %d" divisor count

//7.Create a function that takes a list and an element, and returns all the indices of the list where this element can be found.
//let findIndices (list: 'a list) (element: 'a) : int list =
//    list |> List.mapi (fun i x -> if x = element then i else -1) |> List.filter (fun x -> x <> -1)
//let input = [1; 5; 3; 4; 9; 2; 3; 2; 1]
//let element = 2
//let indices = findIndices input element
//printfn "Indices of %d: %A" element indices

//8.Given a list of strings, write a function that concatenates only those strings that are longer than a given length n.
//let concatenateLongStrings (strings: string list) (n: int) : string =
//    strings |> List.filter (fun x -> x.Length > n) |> List.reduce (fun acc x -> acc + x)
//let input = ["Csemegy"; "Káposzta"; "cseresznye"; "Kecske"]
//let n = 5
//let result = concatenateLongStrings input n
//printfn "Concatenated strings longer than %d: %s" n result

//9.Assuming a list of tuples where each tuple contains an (id, value), write a function to find the tuple with the maximum value.
//let findMaxValueTuple (tuples: (int * int) list) : (int * int) =
//    tuples |> List.maxBy (fun x -> snd x)
//let input = [(1, 10); (2, 20); (3, 30); (4, 40); (5, 50)]
//let result = findMaxValueTuple input
//printfn "Tuple with maximum value: %A" result

//10.Given a list of elements that could repeat, write a function that returns a list of tuples, each containing an element from the input list and the number of times it appears.
//let countElementOccurrences (elements: 'a list) : ('a * int) list =
//    elements |> List.groupBy id |> List.map (fun (k, v) -> (k, v.Length))
//let input = [1; 2; 3; 4; 5; 2; 3; 2; 1]
//let result = countElementOccurrences input
//printfn "Element occurrences: %A" result //format (element, appearances)


//Discriminated unions

//11.Define a DU for a traffic light (Red, Yellow, Green). Write a function that takes a traffic light state and returns the next state.
//type TrafficLight = Red | Yellow | Green
//let nextTrafficLight (light: TrafficLight) : TrafficLight =
//    match light with
//    | Red -> Green
//    | Yellow -> Red
//    | Green -> Yellow
//let currentLight = Green
//let nextLight = nextTrafficLight currentLight
//printfn "Next traffic light: %A" nextLight

//12.Create a DU for basic arithmetic operations (Add, Subtract, Multiply, Divide). Implement a function that takes two numbers and an operation, then performs the operation on the numbers
//type Operation = Add | Subtract | Multiply | Divide
//let performOperation (op: Operation) (a: float) (b: float) : float =
//    match op with
//    | Add -> a + b
//    | Subtract -> a - b
//    | Multiply -> a * b
//    | Divide -> a / b
//let a = 6.0
//let b = 9.0
//let operation = Add
//let result = performOperation operation a b
//printfn "Result of operation: %A" result

//13.Define a DU for different shapes (e.g., Circle, Rectangle, Square, etc.) Write a function that calculates the area of the given shape.
//type Shape = 
//    | Circle of float 
//    | Rectangle of float * float 
//    | Square of float
//let calculateArea (shape: Shape) : float =
//    match shape with
//    | Circle r -> 3.14 * r * r
//    | Rectangle (a, b) -> a * b
//    | Square a -> a * a
//let circle = Circle 5.0
//let rectangle = Rectangle (3.0, 4.0)
//let square = Square 5.0
//let circleArea = calculateArea circle
//let rectangleArea = calculateArea rectangle
//let squareArea = calculateArea square
//printfn "Circle area: %f" circleArea
//printfn "Rectangle area: %f" rectangleArea
//printfn "Square area: %f" squareArea

//14.Define a DU for temperature scales (Celsius, Fahrenheit). Write a function that converts temperatures between the scales
//type Temperature = Celsius | Fahrenheit
//let convertTemperature (temp: float) (scale: Temperature) : float =
//    match scale with
//    | Celsius -> (temp * 9.0 / 5.0) + 32.0
//    | Fahrenheit -> (temp - 32.0) * 5.0 / 9.0
//let celsiusTemp = 25.0
//let fahrenheitTemp = 77.0
//let convertedCelsius = convertTemperature fahrenheitTemp Celsius
//let convertedFahrenheit = convertTemperature celsiusTemp Fahrenheit
//printfn "Converted to Celsius: %f" convertedCelsius
//printfn "Converted to Fahrenheit: %f" convertedFahrenheit

//15.Create a DU to represent a simplified JSON value. Include cases for JsonObject, JsonArray, JsonString, JsonNumber, and JsonBoolean. 
//   Write a function that takes such a JSON value and pretty-prints it to a string.
//type JsonValue =
//    | JsonObject of (string * JsonValue) list
//    | JsonArray of JsonValue list
//    | JsonString of string
//    | JsonNumber of float
//    | JsonBoolean of bool
//let rec prettyPrintJson (json: JsonValue) : string =
//    match json with
//    | JsonObject pairs ->
//        let pairStrings = pairs |> List.map (fun (k, v) -> sprintf "\"%s\": %s" k (prettyPrintJson v))
//        sprintf "{ %s }" (String.concat ", " pairStrings)
//    | JsonArray values ->
//        let valueStrings = values |> List.map prettyPrintJson
//        sprintf "[ %s ]" (String.concat ", " valueStrings)
//    | JsonString s -> sprintf "\"%s\"" s
//    | JsonNumber n -> sprintf "%f" n
//    | JsonBoolean b -> sprintf "%b" b
//let json = JsonObject [("name", JsonString "John"); ("age", JsonNumber 30.0); ("isStudent", JsonBoolean false)]
//let jsonS = prettyPrintJson json
//printfn "JSON string: %s" jsonS


//Functions, recursion

//16.Write a recursive function to compute the nth Fibonacci number.
//let rec fibonacci (n: int) : int =
//    match n with
//    | 0 -> 0
//    | 1 -> 1
//    | _ -> fibonacci (n - 1) + fibonacci (n - 2)
//let n = 10
//let fib = fibonacci n
//printfn "Fibonacci number at %d: %d" n fib

//17.Implement a recursive binary search algorithm that searches for a given element within a sorted array.
//let rec binarySearch (arr: int array) (element: int) (low: int) (high: int) : int =
//    if low > high then -1
//    else
//        let mid = low + (high - low) / 2
//        match arr.[mid] with
//        | x when x = element -> mid
//        | x when x < element -> binarySearch arr element (mid + 1) high
//        | _ -> binarySearch arr element low (mid - 1)
//let arr = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]
//let element = 7
//let index = binarySearch arr element 0 (Array.length arr - 1)
//printfn "Element %d found at index: %d" element index

//18.Write a recursive function to sort a list of integers using the merge sort algorithm.
//let rec mergeSort (numbers: int list) : int list =
//    let rec merge (left: int list) (right: int list) : int list =
//        match left, right with
//        | [], _ -> right
//        | _, [] -> left
//        | h1::t1, h2::t2 ->
//            if h1 < h2 then h1 :: merge t1 right
//            else h2 :: merge left t2
//    let rec split (lst: int list) : int list * int list =
//        match lst with
//        | [] -> [], []
//        | [x] -> [x], []
//        | h1::h2::t ->
//            let left, right = split t
//            h1 :: left, h2 :: right
//    match numbers with
//    | [] -> []
//    | [x] -> [x]
//    | _ ->
//        let left, right = split numbers
//        merge (mergeSort left) (mergeSort right)
//let input = [5; 3; 8; 1; 2; 9; 4; 7; 6]
//let sorted = mergeSort input
//printfn "Sorted list: %A" sorted

//19.Given a binary tree (as a nested structure of nodes), write a recursive function to compute the depth of the tree.
//type Node = { Value: int; Left: Node option; Right: Node option }
//let rec treeDepth (node: Node option) : int =
//    match node with
//    | None -> 0
//    | Some n -> 1 + max (treeDepth n.Left) (treeDepth n.Right)
//let tree = { Value = 1; Left = Some { Value = 2; Left = None; Right = None }; Right = Some { Value = 3; Left = None; Right = None } }
//let depth = treeDepth (Some tree)
//printfn "Tree depth: %d" depth

//20.Create a recursive function to check whether a given string is a palindrome (reads the same backward as forward).
//let isPalindrome (s: string) : bool =
//    let rec isPalindromeHelper (s: string) (low: int) (high: int) : bool =
//        if low >= high then true
//        else if s.[low] <> s.[high] then false
//        else isPalindromeHelper s (low + 1) (high - 1)
//    isPalindromeHelper s 0 (s.Length - 1)
//let input = "radar"
//let palindrome = isPalindrome input
//printfn "Is palindrome: %b" palindrome