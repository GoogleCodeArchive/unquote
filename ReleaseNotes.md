# Release Notes #

## v2.2.2, 6/14/12 ##

Make all custom exception types serializable so that they may pass AppDomain boundaries. Other minor fixes and enhancements.

  * [Issue 5](https://code.google.com/p/unquote/issues/detail?id=5): Support TryWith expressions
  * [Issue 92](https://code.google.com/p/unquote/issues/detail?id=92): Prefix operator precedence should be reduced when return value is a lambda which is being applied
  * [Issue 93](https://code.google.com/p/unquote/issues/detail?id=93): Support 'lazy' and 'assert' keywords (treat them as function applications)
  * [Issue 98](https://code.google.com/p/unquote/issues/detail?id=98): All exceptions should be serializable

## v2.2.1, 5/21/12 ##

The only purpose of this release is to add tags to the NuGet package so that it is easily searchable in the NuGet gallery. The Unquote binary is identical to version 2.2.0, which was a substantial, contemporary release.

  * [Issue 96](https://code.google.com/p/unquote/issues/detail?id=96): Add tags to nuspec

## v2.2.0, 5/20/12 ##

Several enhancements around operator decompilation.

  * [Issue 1](https://code.google.com/p/unquote/issues/detail?id=1): Decompiler Feature Request: support custom prefix and infix operators
  * [Issue 70](https://code.google.com/p/unquote/issues/detail?id=70): Support DefaultValue decompilation
  * [Issue 72](https://code.google.com/p/unquote/issues/detail?id=72): Support Custom NumericLiteral Decompilation
  * [Issue 81](https://code.google.com/p/unquote/issues/detail?id=81): Decompiler Bug: the names for some local lambdas captured by quotations are not being demangled properly
  * [Issue 82](https://code.google.com/p/unquote/issues/detail?id=82): Improve support of standard operators
  * [Issue 83](https://code.google.com/p/unquote/issues/detail?id=83): Leading tilda for prefix operator lambdas should only be used when the operator can also be a infix operator
  * [Issue 84](https://code.google.com/p/unquote/issues/detail?id=84): Decompile non-prefix and non-infix functions with operator-based names using operator symbols
  * [Issue 85](https://code.google.com/p/unquote/issues/detail?id=85): Partially applied symbolic function causes exception
  * [Issue 86](https://code.google.com/p/unquote/issues/detail?id=86): Partialy applied symbolic function not decompiled correctly
  * [Issue 87](https://code.google.com/p/unquote/issues/detail?id=87): Support function and value names that require being surrounded by back-ticks
  * [Issue 90](https://code.google.com/p/unquote/issues/detail?id=90): Locally defined / redefined custom and standard operators should be decompiled same as top-level operators
  * [Issue 91](https://code.google.com/p/unquote/issues/detail?id=91): Decompiler bug: op\_Range and op\_RangeStep sequence construction syntax shouldn't always be used
  * [Issue 94](https://code.google.com/p/unquote/issues/detail?id=94): Fix cast precedence and associativity based on updated F# spec operator precedence table
  * [Issue 95](https://code.google.com/p/unquote/issues/detail?id=95): Unquote.Utils namespace should not be publicly visible


## v2.1.1, 4/11/12 ##

New features and bug fixes.

  * [Issue 11](https://code.google.com/p/unquote/issues/detail?id=11): Decompiler Bug: active patterns don't produce correct F# code
  * [Issue 71](https://code.google.com/p/unquote/issues/detail?id=71): Change signatures for raw evaluation to return generic argument type
  * [Issue 73](https://code.google.com/p/unquote/issues/detail?id=73): Create assertion function like raises but allowing further assertions on the exception object
  * [Issue 76](https://code.google.com/p/unquote/issues/detail?id=76): Consider wording changes for some assertion failure messages
  * [Issue 77](https://code.google.com/p/unquote/issues/detail?id=77): Decompiler Bug: TupleGet pattern missed in match expression
  * [Issue 79](https://code.google.com/p/unquote/issues/detail?id=79): Decompiler Bug: local lambdas captured by quotations are sprinted with mangled names
  * [Issue 80](https://code.google.com/p/unquote/issues/detail?id=80): Decompiler Bug: do a better job of sprinting None values

## v2.1.0, 8/18/11 ##

Added Silverlight 4 support.

  * [Issue 7](https://code.google.com/p/unquote/issues/detail?id=7): Decompiler Bug: precedence of constructor call and other tupled calls not strong enough
  * [Issue 66](https://code.google.com/p/unquote/issues/detail?id=66): If binary operator starts or ends with `*` must put space between parens when sprinting unapplied lambda
  * [Issue 68](https://code.google.com/p/unquote/issues/detail?id=68): Silverlight version of Unquote
  * [Issue 69](https://code.google.com/p/unquote/issues/detail?id=69): Remove FSharp.PowerPack.Metadata dependency


## v2.0.3, 8/7/11 ##

Several high-priority fixes.

  * [Issue 60](https://code.google.com/p/unquote/issues/detail?id=60): Double evaluation in test internal implementation obscures state related test failure causes
  * [Issue 61](https://code.google.com/p/unquote/issues/detail?id=61): reduce / reduceFully operator bug: finally path in TryFinally expressions not followed when exception raised from body
  * [Issue 62](https://code.google.com/p/unquote/issues/detail?id=62): reduce / reduceFully operator bug: with path in TryWith expressions not followed when exception raised from body
  * [Issue 63](https://code.google.com/p/unquote/issues/detail?id=63): When using pipe and testing for exception "raises" finds reflection exception instead
  * [Issue 64](https://code.google.com/p/unquote/issues/detail?id=64): Support (NoDynamicInvocation) reraise operator

## v2.0.2, 7/19/11 ##

Lots of added features and bug fixes including support for several more kinds of expressions.

  * [Issue 32](https://code.google.com/p/unquote/issues/detail?id=32): Type.FSharpName bug: generic typedef args should be printed with leading tick
  * [Issue 41](https://code.google.com/p/unquote/issues/detail?id=41): Support WhileLoop expressions
  * [Issue 42](https://code.google.com/p/unquote/issues/detail?id=42): Support ForIntegerRangeLoop expressions
  * [Issue 43](https://code.google.com/p/unquote/issues/detail?id=43): Support TryFinally expressions
  * [Issue 51](https://code.google.com/p/unquote/issues/detail?id=51): Support LetRecursive expressions
  * [Issue 53](https://code.google.com/p/unquote/issues/detail?id=53): Evaluation and Reduction with environment should use a Map instead of a List to represent the Environment
  * [Issue 54](https://code.google.com/p/unquote/issues/detail?id=54): Update precedence for bitwise operators
  * [Issue 55](https://code.google.com/p/unquote/issues/detail?id=55): Support TypeTest expressions
  * [Issue 56](https://code.google.com/p/unquote/issues/detail?id=56): Custom FSI test failed output is broken
  * [Issue 57](https://code.google.com/p/unquote/issues/detail?id=57): Create and use custom "AssertionFailureException" for generic unit test framework support
  * [Issue 58](https://code.google.com/p/unquote/issues/detail?id=58): Support functions which are static or instance members of a type
  * [Issue 59](https://code.google.com/p/unquote/issues/detail?id=59): Omit else branch of IfThenElse expressions when it's body is only a simple tuple

## v2.0.1, 7/11/11 ##

Service release fixing bugs and tweaking API for new v2.0.0 features.

  * [Issue 48](https://code.google.com/p/unquote/issues/detail?id=48) Bug: op\_UnaryPlus on int16 overlooked
  * [Issue 49](https://code.google.com/p/unquote/issues/detail?id=49) Bug: op\_LogicalNot is not supported
  * [Issue 50](https://code.google.com/p/unquote/issues/detail?id=50) Bug: left shift and right shift operators fail with primitive operands of different types
  * [Issue 52](https://code.google.com/p/unquote/issues/detail?id=52) Evaluation and Reduction Operators with Environment API breaking Change Needed for Proper Piping

## v2.0.0, 7/6/11 ##

Major release featuring custom reflection-based evaluation engine resulting in significant performance improvements.

  * [Issue 33](https://code.google.com/p/unquote/issues/detail?id=33): Decompiler Feature Request: support UnboxGeneric Intrinsic function
  * [Issue 34](https://code.google.com/p/unquote/issues/detail?id=34): Implement custom reflection-based evaluation engine
  * [Issue 35](https://code.google.com/p/unquote/issues/detail?id=35): Refactoring with breaking changes for more consistent naming in API
  * [Issue 36](https://code.google.com/p/unquote/issues/detail?id=36): Short-circuiting rules should be honored during reduction steps
  * [Issue 37](https://code.google.com/p/unquote/issues/detail?id=37): Make smarter choices about decompilation of AndOr and OrElse expressions which can't be differentiated
  * [Issue 38](https://code.google.com/p/unquote/issues/detail?id=38): Add feature for evaluating and reducing synthetic quotations with unbound variables
  * [Issue 39](https://code.google.com/p/unquote/issues/detail?id=39): Add support for typed Quote expressions (nested quotations)
  * [Issue 40](https://code.google.com/p/unquote/issues/detail?id=40): Further support for partial application lambda re-sugaring by supporting coerced vars
  * [Issue 44](https://code.google.com/p/unquote/issues/detail?id=44): Fully support VarSet, FieldSet, and PropertySet expressions
  * [Issue 45](https://code.google.com/p/unquote/issues/detail?id=45): Code documentation comments aren't unavailable in distributions
  * [Issue 46](https://code.google.com/p/unquote/issues/detail?id=46): No assembly info available
  * [Issue 47](https://code.google.com/p/unquote/issues/detail?id=47): Statically link FSharp.PowerPack.Metadata

## v1.3.0, 4/2/11 ##

Significant release: many bug fixes and feature enhancements especially in the area of re-sugaring complex expressions.

  * [Issue 9](https://code.google.com/p/unquote/issues/detail?id=9): Decompiler Bug or F# Quotation Bug: generic empty list treated as call
  * [Issue 15](https://code.google.com/p/unquote/issues/detail?id=15): Reduction Bug: error reducing sprintf Application; lhs match of Application needs to be loosened
  * [Issue 21](https://code.google.com/p/unquote/issues/detail?id=21): Decompiler Feature Request: sprint Lambda Unit vars literally
  * [Issue 22](https://code.google.com/p/unquote/issues/detail?id=22): Decompiler Bug: backwards pipe precedence incorrect
  * [Issue 23](https://code.google.com/p/unquote/issues/detail?id=23): Decompiler Feature Request: re-sugar partially applied lambda expressions
  * [Issue 24](https://code.google.com/p/unquote/issues/detail?id=24): Reduction Feature Request: do not reduce expressions which return Lambda Values
  * [Issue 25](https://code.google.com/p/unquote/issues/detail?id=25): Decompiler Feature Request: re-sugar unapplied lambda expressions
  * [Issue 26](https://code.google.com/p/unquote/issues/detail?id=26): Decompiler Feature Request: support PropertySet expressions
  * [Issue 27](https://code.google.com/p/unquote/issues/detail?id=27): Decompiler Feature Request: re-sugar Lambdas with tupled args
  * [Issue 28](https://code.google.com/p/unquote/issues/detail?id=28): Decompiler Bug or F# Quotation Bug: exception with certain list NewUnionCases
  * [Issue 29](https://code.google.com/p/unquote/issues/detail?id=29): Decompiler Enhancement: re-sugar tuple let expressions
  * [Issue 30](https://code.google.com/p/unquote/issues/detail?id=30): Decompiler Feature Request: re-sugar list and array range expressions
  * [Issue 31](https://code.google.com/p/unquote/issues/detail?id=31): Decompiler Bug: static PropetyGet expressions with args not sprinting args

## v1.2.3, 3/13/11 ##

Incremental release: bug fixes and feature enhancements.

  * [Issue 14](https://code.google.com/p/unquote/issues/detail?id=14): Decompiler Bug, UnionCaseTest: zero arg unions sprinted with "()"
  * [Issue 17](https://code.google.com/p/unquote/issues/detail?id=17): Decompiler Bug: can't differentiate between generic values and generic unit function
  * [Issue 18](https://code.google.com/p/unquote/issues/detail?id=18): Decompiler Bug: generic object constructions are sprinted with reflected name instead of generic args
  * [Issue 19](https://code.google.com/p/unquote/issues/detail?id=19): Decompiler Bug: TupleGet expressions involving tuples of length > 7 not handled correctly
  * [Issue 20](https://code.google.com/p/unquote/issues/detail?id=20): Decompiler Feature Request: name TupleGet pattern match value using "itemX" instead of "indexX"

## v1.2.2, 2/23/11 ##

Several bug fixes and feature enhancements.

  * [Issue 2](https://code.google.com/p/unquote/issues/detail?id=2): Decompiler Feature Request: support TupleGet expressions
  * [Issue 3](https://code.google.com/p/unquote/issues/detail?id=3): Decompiler Feature Request: support UnionCaseTest expressions
  * [Issue 4](https://code.google.com/p/unquote/issues/detail?id=4): Reduction Feature Request: support NewUnionCase subexpressions
  * [Issue 6](https://code.google.com/p/unquote/issues/detail?id=6): Type.FSharpName bug: can't handle generic type definiations
  * [Issue 8](https://code.google.com/p/unquote/issues/detail?id=8): Decompiler Bug: empty list error
  * [Issue 10](https://code.google.com/p/unquote/issues/detail?id=10): Type.FSharpName bug: can't handle types in modules
  * [Issue 12](https://code.google.com/p/unquote/issues/detail?id=12): xunit.gui.exe Output: bad newlines

## v1.2.1, 2/15/11 ##

Fix bug: local lambdas represented as Value fail during Application reduction rebuild.

## v1.2.0, 2/13/11 ##

Added `raises<'a when 'a :> exn> : Quotations.Expr -> unit` for testing expected exceptions.

## v1.1.0, 2/11/11 ##

Better support for exceptions within tests, expand support for more expressions

  * Better support for exceptions within tests: print printable lines up until the exception, then print the exception (before only printed the exception)
  * Support applications of lambda values (e.g. local function vs. module property)
  * Better preservation of type information for reduction evaluations which return null
  * Print "()" for function calls which 1) do not need explit type arguments 2) take only single unit arg
  * Changed FSI-mode Operator.test output to be more like unit test mode output; no longer uses tabs

## v1.0.0, 2/08/11 ##

Initial release