namespace DeveloperTest.Tests
{
	public class ExtensionMethodTests
	{
		[Fact]
		public void ExtensionMethods_Add_ReturnSum_OK()
		{
			int sum = ExtensionMethods.Add(12, 13);

			Assert.Equal(25, sum);

		}

		[Fact]
		public void ExtensionMethods_Add_ReturnSum_NotOK()
		{
			int sum = ExtensionMethods.Add(12, 13);

			Assert.NotEqual(1, sum);
		}
	}
}