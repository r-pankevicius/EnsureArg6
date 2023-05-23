using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Types_Tests
	{
		//public object IsInt_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsInt(param, paramName);
		[Fact]
		public void IsInt_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsShort_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsShort(param, paramName);
		[Fact]
		public void IsShort_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsShort_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsShort(param, paramName);
		[Fact]
		public void IsShort_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsDecimal_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDecimal(param, paramName);
		[Fact]
		public void IsDecimal_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsDecimal_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDecimal(param, paramName);
		[Fact]
		public void IsDecimal_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsDouble_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDouble(param, paramName);
		[Fact]
		public void IsDouble_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsDouble_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDouble(param, paramName);
		[Fact]
		public void IsDouble_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsFloat_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsFloat(param, paramName);
		[Fact]
		public void IsFloat_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsFloat_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsFloat(param, paramName);
		[Fact]
		public void IsFloat_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsBool_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsBool(param, paramName);
		[Fact]
		public void IsBool_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsBool_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsBool(param, paramName);
		[Fact]
		public void IsBool_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsDateTime_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDateTime(param, paramName);
		[Fact]
		public void IsDateTime_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsDateTime_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsDateTime(param, paramName);
		[Fact]
		public void IsDateTime_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsString_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsString(param, paramName);
		[Fact]
		public void IsString_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsString_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsString(param, paramName);
		[Fact]
		public void IsString_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsOfType_Test([NotNull] object param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsOfType(param, expectedType, paramName);
		[Fact]
		public void IsOfType_Test()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsOfType_TypeTest([NotNull] Type param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsOfType(param, expectedType, paramName);
		[Fact]
		public void IsOfType_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsNotOfType_Test([NotNull] object param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsNotOfType(param, nonExpectedType, paramName);
		[Fact]
		public void IsNotOfType_Test()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsNotOfType_TypeTest([NotNull] Type param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsNotOfType(param, nonExpectedType, paramName);
		[Fact]
		public void IsNotOfType_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsAssignableToType_InstanceTest([NotNull] object param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsAssignableToType(param, expectedType, paramName);
		[Fact]
		public void IsAssignableToType_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsAssignableToType_TypeTest([NotNull] Type param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsAssignableToType(param, expectedType, paramName);
		[Fact]
		public void IsAssignableToType_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsNotAssignableToType_InstanceTest([NotNull] object param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);
		[Fact]
		public void IsNotAssignableToType_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsNotAssignableToType_TypeTest([NotNull] Type param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);
		[Fact]
		public void IsNotAssignableToType_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public object IsClass_InstanceTest([NotNull] object param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsClass(param, paramName);
		[Fact]
		public void IsClass_InstanceTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		//public Type IsClass_TypeTest([NotNull] Type param, [CallerArgumentExpression("param")] string paramName = "")
		//	=> EnsureArg.IsClass(param, paramName);
		[Fact]
		public void IsClass_TypeTest()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}
	}
}
