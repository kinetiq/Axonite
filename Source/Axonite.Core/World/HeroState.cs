namespace Axonite.Core.World
{
    public class HeroState
    {
        private readonly IHero m_Mind;

        //Stats, etc.

        public HeroState(IHero hero)
        {
            this.m_Mind = hero;
        }

        public IHero Mind
        {
            get { return m_Mind; }
        }    
    }
}
