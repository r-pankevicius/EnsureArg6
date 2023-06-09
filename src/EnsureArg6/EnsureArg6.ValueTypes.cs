﻿using System;
using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.ValueTypes.cs
	public static partial class EnsureArg6
    {
        public static bool IsTrue(bool value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsTrue(value, paramName, optsFn);

        public static bool IsFalse(bool value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsFalse(value, paramName, optsFn);

        public static T IsNotDefault<T>(T value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : struct
            => Ensure.Any.IsNotDefault(value, paramName, optsFn);

        public static T? IsNotNull<T>(
            T? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : struct
            => Ensure.Any.IsNotNull(value, paramName, optsFn);

        public static Guid IsNotEmpty(Guid value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => Ensure.Guid.IsNotEmpty(value, paramName, optsFn);
    }
}
