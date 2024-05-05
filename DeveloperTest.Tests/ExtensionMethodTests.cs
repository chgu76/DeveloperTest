namespace DeveloperTest.Tests
{
	public class ExtensionMethodTests
	{
		[Fact]
		public void ExtensionMethods_Add_ReturnSum()
		{
			int sum = ExtensionMethods.Add(12, 13);

			Assert.Equal(25, sum);

			Assert.NotEqual(1, sum);
		}
	}
}