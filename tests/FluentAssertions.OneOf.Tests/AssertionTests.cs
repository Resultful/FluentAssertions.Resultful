using System;
using NUnit.Framework;
using OneOf;
using FluentAssertions;

namespace FluentAssertions.OneOf.Tests
{
    [TestFixture]
    public class OneOfAssertionTests
    {
        [Test]
        public void AssertOption_OneOf_SomeFound()
        {
            //Arrange
            var itemToCheck = OneOf<Some<int>, None>.FromT0(new Some<int>
            {
                Value = 3
            });

            //Assert
            itemToCheck
                .Should()
                .BeCase<Some<int>>()
                .And
                .Should()
                .BeEquivalentTo(
                    new Some<int>
                    {
                        Value = 3
                    });
        }

        [Test]
        public void AssertOption_OneOf_CaseNotPresent()
        {
            var itemToCheck =
                OneOf<Some<int>, None>
                    .FromT0(
                        new Some<int>
                        {
                            Value = 3
                        });


            Action failureAction = () => itemToCheck.Should().BeCase<int>();

            failureAction.Should().Throw<AssertionException>().WithMessage(
                "Unable to find any Discriminated Union method on type \"OneOf<Some<Int32>,None>\" for expected type \"Int32\"");
        }


        [Test]
        public void AssertOption_OneOf_NotApplicableCase()
        {
            var itemToCheck = OneOf<Some<int>, None>.FromT0(new Some<int>
            {
                Value = 3
            });


            Action failureAction = () => itemToCheck.Should().BeCase<None>();

            failureAction.Should().Throw<AssertionException>().WithMessage(
                "Value should be assignable to \"None\" but found \"Some<Int32>\" instead");
        }

        //[Test]
        //public void AssertOption_StructuralComparison_OneOfGiven_Success()
        //{
        //    AssertionExtensions.SetupOneOfAssertions();

        //    var itemToCheck = OneOf<Some<int>, None>.FromT0(new Some<int>
        //    {
        //        Value = 3
        //    });

        //    var expectedValue = OneOf<Some<int>, None>.FromT0(new Some<int>
        //    {
        //        Value = 3
        //    });

        //    itemToCheck.Should().BeEquivalentTo(expectedValue);
        //}


        //[Test]
        //public void UnfoldNoRecursion()
        //{

        //    var someItem = new Some<int>
        //    {
        //        Value = 3
        //    };
        //    var itemToCheck = OneOf<Some<int>, None>.FromT0(someItem);

        //    var result = UnfoldOneOf.Unfold<OneOf<Some<int>, None>>(itemToCheck);

        //    result.Value.Should().BeEquivalentTo(someItem);
        //    result.Type.Should().Be(typeof(Some<int>));
        //}


        //[Test]
        //public void UnfoldRecursive()
        //{
        //    var someItem = new Some<int>
        //    {
        //        Value = 3
        //    };
        //    var itemToCheck = OneOf<OneOf<Some<int>, None>, None>.FromT0(someItem);

        //    var result = UnfoldOneOf.UnfoldRecursively(itemToCheck);

        //    result.Value.Should().BeEquivalentTo(someItem);
        //    result.Type.Should().Be(typeof(Some<int>));
        //}

    }
}
