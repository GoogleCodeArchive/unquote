Unquote is not just another DSL or API for making unit test assertions. Instead, assertions are written as plain, statically-checked F# [quoted expressions](http://msdn.microsoft.com/en-us/library/dd233212.aspx) and test failure messages are given as step-by-step F# expression evaluations.

Unquote integrates configuration-free with all exception-based unit testing frameworks including xUnit.net, NUnit, and MbUnit. For example, the following failing xUnit.net test

```
[<Fact>]
let ``demo Unquote xUnit support`` () =
    test <@ ([3; 2; 1; 0] |> List.map ((+) 1)) = [1 + 3..1 + 0] @>
```

produces the following failure message

```
Test 'Module.demo Unquote xUnit support' failed: 

([3; 2; 1; 0] |> List.map ((+) 1)) = [1 + 3..1 + 0]
[4; 3; 2; 1] = [4..1]
[4; 3; 2; 1] = []
false

	C:\File.fs(28,0): at Module.demo Unquote xUnit support()
```

Unquote may even be used within FSI sessions, enabling the direct migration of ad-hoc FSI tests during interactive development to formal test suites.

In addition to `test : Quotations.Expr<bool> -> unit` used for performing most assertions, Unquote has convenience operators `=?`, `>?`, `<?`, `>=?`, `<=?`, and `<>?` for performing  simple comparison assertions. And finally, Unquote has operators `raises<'a when 'a :> exn> : Quotations.Expr -> unit` and `raisesWith : Expr -> (#exn -> Expr<bool>) -> unit` for asserting whether a quoted expression raises an expected exception.

At the heart of Unquote, are (public) operators for decompiling, evaluating, and incrementally reducing F# Quotations. Unquote can decompile many F# quoted expressions as single line, non-light syntax strings. Notable decompiler features include
  * Precedence based parenthesization
  * Fully re-sugared multi-variable lambda expressions and applications
  * Sequential expressions
  * Static method calls
  * Module function calls
  * Instance method calls
  * IntrinsicFunction calls
  * Seq, List, and Array range expressions
  * Binary infix operators
  * Unary prefix operators
  * All instance and static property get expressions
  * Instance and static field get expressions
  * All variable, field, and property set expressions
  * Unit and None
  * Generic type test expressions
  * Source names of functions and modules
  * Omission of module qualification for FSI module and AutoOpen modules
  * Excellent F# type name printing, including
    * Precedence parenthesization
    * Non-generic types
    * Arbitrarily complex generic types
    * Known type abbreviations
    * Unit, tuples, functions, and arrays
    * Generic type definitions
    * Definition within Modules or namespaces
  * Detection of whether generic args are inferable
  * if...then...else and && and || short-circuiting boolean expressions
  * Implicit coercion
  * Let bindings
    * Mutable and non-mutable variables
    * Single variable assignment
    * Fully re-sugared tupled variable assignment
    * Recursive functions (including mutually recursive functions)
  * Tuple, array, union case, and object construction
  * Literal list union case construction
  * Basic union case pattern matching
  * While loops and integer for loops
  * try...with and try...finally expressions

The incremental evaluator performs reduction steps until a non-reducible expression is reached. During a reduction step, an expression will be reduced if all of its subexpressions are already reduced, recursively reducing the sub-expressions otherwise. Hence order of evaluation is not strictly adhered to, but shouldn't be a problem in practice since assertion expressions are not expected to depend on order of evaluation side effects. Except for sequential expressions, which are evaluated from left to right, and control structures and boolean operator expressions, which follow valid branch paths and short-circuiting rules. If a test expression throws an exception, the test will fail and print each reduction step up to the point of the exception, and then print the exception.

As of version 2.0.0, reduction no longer depends on the [F# Power Pack](http://fsharppowerpack.codeplex.com/) expression evaluator and instead uses a new custom reflection-based evaluator. The Unquote evaluator can be up to 50 times faster than the PowerPack evaluator, and was able to increase the execution speed of Unquote's own suite of 400+ self-hosted unit tests by about 4 times. It also supports more quotation expressions than PowerPack, such as variable, property, and field set expressions, loop expressions, and nested quotation expressions.

Please see the Wiki page GettingStarted for a simple guide to getting started with Unquote.

Unquote was inspired by [Groovy Power Asserts](http://dontmindthelanguage.wordpress.com/2009/12/11/groovy-1-7-power-assert/).


---


&lt;wiki:gadget url="http://www.ohloh.net/p/602891/widgets/project\_factoids.xml" height="195" border="0" width="100%" /&gt;

You are welcome to [Pay What You Want](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=ZNFZMKQF77YRC) for Unquote via PayPal.

Copyright 2011-2014 [Swensen Software](http://www.swensensoftware.com)