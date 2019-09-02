using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Democode;

namespace DemoCodeTests
{
    public class PlayerCharacterTests
    {
        [Fact]
        public void ShouldCreateDefaultCharacter()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.ShouldSatisfyAllConditions(
                () => playerCharacter.IsNoob.ShouldBe(true),
                () => playerCharacter.Name.ShouldNotBeNullOrEmpty(),
                () => playerCharacter.Weapons.ShouldNotBeEmpty()
                );                       
        }

        [Fact]
        public void ShouldBeNoobByDefault()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.IsNoob.ShouldBe(true);
        }

        [Fact]
        public void ShouldHaveADefaultName()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Name.ShouldNotBeNullOrEmpty();
        }
        [Fact]
        public void ShouldGainHealthAfterSleeping()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Health = 100;
            playerCharacter.sleep();

            //playerCharacter.Health.ShouldBeGreaterThan(100);
            playerCharacter.Health.ShouldBeInRange(101, 200);
        }

        [Fact]
        public void ShouldHaveAtLeastOneWeapon()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Weapons.ShouldNotBeEmpty();
        }

        [Fact]
        public void ShouldHaveAnyEmptyWeapons()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Weapons.ShouldAllBe(weapon => !string.IsNullOrWhiteSpace(weapon));
        }

        [Fact]
        public void ShouldHaveALongBow()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Weapons.ShouldContain("Long Bow");
        }

    }
}
