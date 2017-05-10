
# The project reached end-of-life
[Saturn72.UnitTesting.Framework](https://github.com/saturn72/Saturn72.UnitTesting.Framework) repository was designed to support unit testing in the short-middle range for all [Saturn72](www.saturn72.com) projects.
Now we are in a point where there are generic solutions matching the same assertion functionality provided by the community with better support for the .Net eco-system.
This, and more have lead us to the conclusion that [Saturn72.UnitTesting.Framework](https://github.com/saturn72/Saturn72.UnitTesting.Framework) repository reached its end-of-life and that no more resources should assigned for develop new features for  it.
This repository is tracked until 01/01/2019 and we support any issue may raised. From 01/01/2019 not support will be given for [Saturn72.UnitTesting.Framework](https://github.com/saturn72/Saturn72.UnitTesting.Framework).

We are recomending moving the code to [Shouldly](https://github.com/shouldly/shouldly) since [Shouldly](https://github.com/shouldly/shouldly) this project reached stability and has better support in .Net eco-system.


# Saturn72.UnitTesting.Framework
Unit test framework for unit testing
This lib is used in all SAturn72 software products.

## Why using this framework?
Saturn72.UnitTesting.Framework is wrapper on generic unit test framework (currently we wrap NUnit), this mean faster framewrok changes when necessary.
Although this scenario is not common in simple unit test use case (when developer writes unit test for his code), when relying on unit test framework to assert complex scenarios like system tests, ui tests switching between unit test framework might occur as the selected framework does not support required feature.

