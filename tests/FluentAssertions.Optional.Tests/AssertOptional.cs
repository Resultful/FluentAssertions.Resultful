using NUnit.Framework;
using Optional;
using FluentAssertions.Union;
using FluentAssertions.Union.Models;

namespace FluentAssertions.Optional.Tests
{
    public class Tests
    {
        [Test]
        public void AssertOption_Option_SomeFound()
        {
            //Arrange
            var itemToCheck = Option.Some( 3);

            //Assert
            itemToCheck
                .ShouldBeCase<int>()
                .And
                .Should()
                .Be(3);
        }

        [Test]
        public void AssertOption_Option_NoneFound()
        {
            //Arrange
            var itemToCheck = Option.None<int>();

            //Assert
            itemToCheck
                .ShouldBeNone();
        }

        //[Test]
        //public void AssertOption_OneOf_CaseNotPresent()
        //{
        //    var itemToCheck =
        //        OneOf<Some<int>, None>
        //            .FromT0(
        //                new Some<int>
        //                {
        //                    Value = 3
        //                });


        //    Action failureAction = () => itemToCheck.Should().BeCase<int>();

        //    failureAction.Should().Throw<AssertionException>().WithMessage(
        //        "Unable to find any Discriminated Union method on type \"OneOf<Some<Int32>,None>\" for expected type \"Int32\"");
        //}


        //[Test]
        //public void AssertOption_OneOf_NotApplicableCase()
        //{
        //    var itemToCheck = OneOf<Some<int>, None>.FromT0(new Some<int>
        //    {
        //        Value = 3
        //    });


        //    Action failureAction = () => itemToCheck.Should().BeCase<None>();

        //    failureAction.Should().Throw<AssertionException>().WithMessage(
        //        "Value should be assignable to \"None\" but found \"Some<Int32>\" instead");
        //}
    }
}
