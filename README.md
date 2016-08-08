# Saturn72.UnitTesting.Framework
Unit test framework for unit testing
This lib is used in all SAturn72 software products.

##Why using this framework?
Saturn72.UnitTesting.Framework is wrapper on generic unit test framework (currently we wrap NUnit), this mean faster framewrok changes when necessary.
Although this scenario is not common in simple unit test use case (when developer writes unit test for his code), when relying on unit test framework to assert complex scenarios like system tests, ui tests switching between unit test framework might occur as the selected framework does not support required feature.

