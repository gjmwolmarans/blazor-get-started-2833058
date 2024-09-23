namespace Beam.Tests;

/// <summary>
/// These tests are written entirely in C#.
/// Learn more at https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-cs-files
/// </summary>
public class IndexPageTests : TestContext
{
	[Fact]
	public void CounterStartsAtZero()
	{
		// Arrange
		var cut = RenderComponent<Beam.Client.Pages.Index>();

		// Assert that content of the paragraph shows counter at zero
		Assert.Contains("Select a Frequency, or create a new one", cut.Markup);
		cut.MarkupMatches(@"<h2 diff:ignore></h2>
			<p diff:ignore></p>");
	}
}
