using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Democode;

namespace DemoCodeTests
{
    public class NameJoinerTests
    {
        public NameJoinerTests()
        {
            
        }

        [Fact]
        public void ShouldJoinNames()
        {
            var namejoiner = new NameJoiner();
            namejoiner.Join("Sarah", "Smith").ShouldBe("Sarah Smith", Case.Insensitive);
        }

        [Fact]
        public void ShouldContainFirstName()
        {
            var namejoiner = new NameJoiner();
            namejoiner.Join("Sarah", "Smith").ShouldContain("Sarah", Case.Insensitive);

        }

        [Fact]
        public void ShouldStartWithFirstName()
        {
            var namejoiner = new NameJoiner();
            namejoiner.Join("Sarah", "Smith").ShouldStartWith("Sarah", Case.Insensitive);
        }

        [Fact]
        public void ShouldEndWithLastName()
        {
            var namejoiner = new NameJoiner();
            namejoiner.Join("Sarah", "Smith").ShouldEndWith("Smith", Case.Insensitive);
        }
        [Fact]
        public void ShouldMatchExpression()
        {
            var namejoiner = new NameJoiner();
            namejoiner.Join("Sarah", "Smith").ShouldMatch("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+");

        }

    }
}
