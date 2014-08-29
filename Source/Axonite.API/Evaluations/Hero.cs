using System;
using Axonite.Core.World;

namespace Axonite.API.Evaluations
{
    /// <summary>
    /// ReadOnly hero that's safe for the API to expose. We can't expose IHero or HeroState
    /// obviously, because then the user could make changes.
    /// </summary>
    public class Hero : ReadOnlyEntityBase
    {
        public readonly Guid HeroId;
        public readonly int Health = 0;
        public readonly int Strength = 0;

        //TODO: whatever other facts Heroes are allowed to percieve about other heroes.

        public Hero(HeroState hero)
        {
            this.HeroId = hero.HeroId;
            this.Health = hero.Health;
            this.Strength = hero.Strength;
        }

    }
}
