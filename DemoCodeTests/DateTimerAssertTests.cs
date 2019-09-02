using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Democode;

namespace DemoCodeTests
{
    public class DateTimerAssertTests
    {
        [Fact]
        public void ShouldHaveDateOfBirth()
        {
            var person = new Person( new DateTime(1900,1,25));
            person.DateOfBirth.ShouldBe(new DateTime(1900, 1, 25));
            
        }

    }
}
