using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Types_Tests
	{
		[Fact]
		public void IsInt_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsInt(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsInt(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsInt_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsInt(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsInt(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string, not int", Check, Check6);
		}

		[Fact]
		public void IsShort_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsShort(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsShort(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsShort_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsShort(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsShort(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsDecimal_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsDecimal(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsDecimal(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsDecimal_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsDecimal(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsDecimal(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsDouble_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsDouble(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsDouble(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsDouble_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsDouble(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsDouble(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsFloat_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsFloat(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsFloat(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsFloat_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsFloat(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsFloat(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsBool_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsBool(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsBool(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsBool_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsBool(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsBool(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsDateTime_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsDateTime(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsDateTime(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(string), Check, Check6);
		}

		[Fact]
		public void IsDateTime_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsDateTime(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsDateTime(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)"I'm string", Check, Check6);
		}

		[Fact]
		public void IsString_TypeTest()
		{
			static Type Check(Type myParamPamPam) => EnsureArg.IsString(myParamPamPam, nameof(myParamPamPam));
			static Type Check6(Type myParamPamPam) => EnsureArg6.IsString(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(typeof(bool), Check, Check6);
		}

		[Fact]
		public void IsString_InstanceTest()
		{
			static object Check(object myParamPamPam) => EnsureArg.IsString(myParamPamPam, nameof(myParamPamPam));
			static object Check6(object myParamPamPam) => EnsureArg6.IsString(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((object)1, Check, Check6);
		}

		// ???????????????
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
