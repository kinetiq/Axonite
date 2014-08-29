using System;

namespace Axonite.Core.World
{
    public class HeroState
    {
        private readonly IHero m_Hero;

        public readonly Guid HeroId = Guid.NewGuid();
        public int Health = 1;
        public int Strength = 1;
        
        public HeroState(IHero hero)
        {
            this.m_Hero = hero;
        }

        public IHero Hero
        {
            get { return m_Hero; }
        }    
    }
}
