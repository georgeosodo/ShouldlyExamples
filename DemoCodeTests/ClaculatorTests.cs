using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Democode;
using System.Dynamic;

namespace DemoCodeTests
{

    public class ClaculatorTests
    {
        public ClaculatorTests()
        {
            ShouldlyConfiguration.DefaultFloatingPointTolerance = 0.001;
        }

        [Fact]
        public void ShouldAddInts()
        {
            var calc = new Calculator();
            calc.AddInts(1, 2).ShouldBe(3);
        }
        [Fact]
        public void ShouldAddDoubles()
        {
            var calc = new Calculator();
            calc.AddDoubles(1.1, 2.2).ShouldBe(3.3);
        }

        [Fact]
        public void ShouldNotBeZero()
        {
            var calc = new Calculator();
            calc.AddInts(1, 2).ShouldNotBe(0);
        }
        [Fact]
        public void ShouldThrownAnExceptionWhenDivideByZero()
        {
            var calc = new Calculator();
            Should.Throw<DivideByZeroException>(() => calc.Divide(100, 0));

        }

        [Fact]
        public void ShouldThrownExceptionWhenNumberTooBig()
        {
            var calc = new Calculator();
           ArgumentOutOfRangeException ex= Should.Throw<ArgumentOutOfRangeException>(() => calc.Divide(101, 0));
            ex.ParamName.ShouldBe("number");

        }
        [Fact]
        public void ShouldAddNumbers()
        {
            var calc = new Calculator();
            Should.CompleteIn(() => calc.AddInts(1, 2), TimeSpan.FromMilliseconds(100));
        }
        [Fact]
        public void ShouldHavePropery()
        {
            dynamic person = new ExpandoObject();
            person.Name = "Sarah";
            DynamicShould.HaveProperty(person, "Name");
        }
    }
}
