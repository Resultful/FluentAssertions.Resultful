using System;
using NUnit.Framework;
using OneOf;

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
            itemToCheck.Should().Be<Some<int>>()
                .And.ShouldBeEquivalentTo(new Some<int>
                {
                    Value = 3
                });
        }

        [Test]
        public void AssertOption_OneOf_CaseNotPresent()
        {
            var itemToCheck = OneOf<Some<int>, None>.FromT0(new Some<int>
            {
                Value = 3
            });


            Action failureAction = () => itemToCheck.Should().Be<int>();

            failureAction.ShouldThrow<AssertionException>().WithMessage("Value should be one of \"Some<Int32>, None\" but found \"Int32\" instead.");
        }

    }
}
