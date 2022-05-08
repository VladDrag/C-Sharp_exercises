using System;
using FluentAssertions;
using Xunit;

// get age from user; -> returns INT

// add 2 numbers; -> returns INT

// determine if a number is even or odd -> returns STRING

namespace tester_program.Tests
{
	public class SolutionTests
	{
		[Fact]
		public void returns_the_numbr_inputted_correctly()
		{
			//arrange
			var solution = new Solution();

			//act
			var result = solution.get_age("3");

			//assert for input = 3;
			result.Should().Be(3);
		}

		[Fact]
		public void returns_negative_input()
		{
			//arrange
			var solution = new Solution();

			//act
			var result = solution.get_age("-3");

			//assert for input = -3;
			result.Should().Be(-3);
		}

		[Fact]
		public void returns_correct_positive_addition()
		{
			//arrrange
			var solution = new Solution();

			//act
			var result = solution.add(3, 4);

			//assert for input = 3, 4;
			result.Should().Be(7);
		}

		[Fact]
		public void returns_correct_negative_addition()
		{
			//arrange
			var solution = new Solution();

			//act
			var result = solution.add(-3, -4);

			//assert for input = -3 , -4;
			result.Should().Be(-7);
		}

	}
}