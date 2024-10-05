﻿using FluentAssertions;
using MasterTDD.Services.Module1;

namespace MasterTDD.UnitTests.Services.Module1
{
    public class FibonacciServiceShould
    {
        [Fact]
        public void Return0_AtPosition1()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(1);

            fibonacciNumber.Should().Be(0);
        }

        [Fact]
        public void Return1_AtPosition2()
        {
            var fibonacciNumber = FibonacciService.GetNumberAtPosition(2);

            fibonacciNumber.Should().Be(1);
        }
    }
}
