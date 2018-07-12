//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using OneOf;

//namespace FluentAssertions.OneOf
//{
//    internal static class UnfoldOneOf
//    {
//        internal static IEnumerable<Type> GetAllOneOfTypes() => new[]
//        {
//            typeof(OneOf<>),
//            typeof(OneOf<,>),
//            typeof(OneOf<,,>),
//            typeof(OneOf<,,,>),
//            typeof(OneOf<,,,,>),
//            typeof(OneOf<,,,,,>),
//            typeof(OneOf<,,,,,,>),
//            typeof(OneOf<,,,,,,,>),
//            typeof(OneOf<,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>),
//            typeof(OneOf<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>)
//        };

//        internal static TypeValuePair Convert<T>(T value) => new TypeValuePair(typeof(T), value);

//        internal static Lazy<List<Type>> OneOfTypes
//            = new Lazy<List<Type>>(
//                () => GetAllOneOfTypes().ToList()
//            );

//        internal static TypeValuePair Unfold<T>(T item)
//            => Unfold(item, typeof(T));

//        internal static TypeValuePair Unfold(object item, Type itemType)
//        {
//            Unfold(item, itemType, out var result);
//            return result;
//        }

//        private static bool Unfold(object item, Type itemType, out TypeValuePair result)
//        {
//            if (!itemType.IsConstructedGenericType)
//            {
//                result = new TypeValuePair(itemType, item);
//                return false;
//            }
//            var genericType = itemType.GetGenericTypeDefinition();
//            if (OneOfTypes.Value.All(x => genericType != x))
//            {
//                result = new TypeValuePair(itemType, item);
//                return false;
//            }
//            var genericArguments = itemType.GetGenericArguments();
//            var method = AssertionHelpers.ResolveMethod(typeof(UnfoldOneOf), "Unfold", genericArguments.Length);
//            var concreteMethod = method.MakeGenericMethod(genericArguments);
//            result = (TypeValuePair)concreteMethod.Invoke(null, new[] { item });
//            return true;
//        }

//        internal static TypeValuePair UnfoldRecursively<T>(T item)
//            => UnfoldRecursively(item, typeof(T));

//        internal static TypeValuePair UnfoldRecursively(object item, Type itemType)
//        {
//            if (Unfold(item, itemType, out var result))
//            {
//                return UnfoldRecursively(result.Value, result.Type);
//            }
//            return result;
//        }
//    }
//}
