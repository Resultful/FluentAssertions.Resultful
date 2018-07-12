//using System;
//using System.Linq;
//using System.Reflection;
//using FluentAssertions.Equivalency;
//using FluentAssertions.Execution;
//using OneOf;
//using OneOf.Types;

//namespace FluentAssertions.OneOf
//{
//    public static partial class AssertionExtensions
//    {
//        private static readonly Lazy<object> _initialised = new Lazy<object>(() =>
//        {
//            AssertionOptions.EquivalencySteps.Insert<OneOfEquivalencyStep>();
//            return null;
//        });

//        public static void SetupOneOfAssertions()
//        {
//            var _ = _initialised.Value;
//        }
//    }

//    public class OneOfEquivalencyStep : IEquivalencyStep
//    {

//        public bool CanHandle(IEquivalencyValidationContext context, IEquivalencyAssertionOptions config)
//        {
//            var subjectType = context.Subject.GetType();
//            return IsGenericOneOf(subjectType.GetGenericTypeDefinition());
//        }

//        private bool IsGenericOneOf(Type type)
//            => type == typeof(OneOf<,>);

//        public bool Handle(IEquivalencyValidationContext context, IEquivalencyValidator parent, IEquivalencyAssertionOptions config)
//        {
//            var expectationType = config.GetExpectationType(context);

//            var unfoldedExpectation = UnfoldOneOf.Unfold(context.Expectation, expectationType);
//            var (newExpectationType, unfoldedValue) = unfoldedExpectation;

//            var genericArgs = expectationType.GetGenericArguments();
//            var item = context.Subject;
//            var subjectType = item.GetType();
//            var method = AssertionHelpers.ResolveMethod(typeof(AssertionHelpers), "CheckItemHelper", genericArgs.Length + 1);

//            var concreteMethod = method.MakeGenericMethod(new []{ newExpectationType }.Concat(genericArgs).ToArray());
//            var value = concreteMethod.Invoke(null, new[] { item, AssertionScope.Current  });

//            if (config.IsRecursive)
//            {
//                parent.AssertEqualityUsing(CreateForOneOf(context, unfoldedExpectation, new TypeValuePair(subjectType, value)));
//            }
//            else
//            {
//                value.Should().Be(unfoldedValue, context.Because, context.BecauseArgs);
//            }

//            return true;
//        }

//        private IEquivalencyValidationContext CreateForOneOf(IEquivalencyValidationContext context, TypeValuePair expectation, TypeValuePair subject)
//        {
//            string memberDescription = AssertionHelpers.PrettyPrint(expectation.Type);
//            string propertyPath = (context.SelectedMemberDescription.Length == 0) ? "pair" : context.SelectedMemberDescription + String.Empty;
//            return new EquivalencyValidationContext
//            {
//                SelectedMemberInfo = context.SelectedMemberInfo,
//                Subject = subject.Value,
//                Expectation = expectation.Value,
//                SelectedMemberPath = $"{context.SelectedMemberPath}.<{memberDescription}>",
//                SelectedMemberDescription = propertyPath + memberDescription,
//                Because = context.Because,
//                BecauseArgs = context.BecauseArgs,
//                CompileTimeType = subject.Type,
//                RootIsCollection = context.RootIsCollection,
//                Tracer = context.Tracer
//            };
//        }
//    }
//}
