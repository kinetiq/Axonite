using System.Collections.Generic;
using Axonite.Core.World;
using Axonite.GameLogic.ServerLogic.Turns;
using Axonite.GameLogic.ServerLogic.Warden.HeroCreation;
using Ether.Outcomes;

namespace Axonite.GameLogic.ServerLogic.Warden
{
    /// <summary>
    /// Validates heroes to ensure fair stats.
    /// </summary>
    public class HeroValidator
    {
        private readonly List<IHero> Heroes;
        private readonly IValidationStrategy Validator;
        private readonly GameTypes GameType;
       
        public HeroValidator(List<IHero> heroes, GameTypes gameType)
        {
            this.Heroes = heroes;
            this.GameType = gameType;
            this.Validator = ValidationStrategyFactory.GetValidatorFor(GameType);
        }

        public IOutcome<List<IHero>> GetValidHeroes()
        {
            var Result = new List<IHero>();
            var Messages = new List<string>();

            foreach (var Hero in Heroes)
            {
                var ValidationOutcome = Validator.Validate(Hero);

                if (ValidationOutcome.Success) 
                    Result.Add(Hero);
                else
                    Messages.AddRange(ValidationOutcome.Messages);
            }

            return Outcomes.Success(Heroes).WithMessage(Messages);
        }
    }
}
