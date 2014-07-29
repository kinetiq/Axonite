using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axonite.API.World;
using Axonite.GameLogic.Turns;
using Axonite.GameLogic.Warden.Validation;
using Ether.Outcomes;

namespace Axonite.GameLogic.Warden
{
    /// <summary>
    /// Validates heroes to ensure fair stats.
    /// </summary>
    public class HeroValidator
    {
        private readonly List<IHero> Heroes;
        private readonly IValidationStrategy Validator;
        private readonly MatchTypes MatchType;
       
        public HeroValidator(List<IHero> heroes, MatchTypes matchType)
        {
            this.Heroes = heroes;
            this.MatchType = matchType;
            this.Validator = ValidationStrategyFactory.GetValidatorFor(MatchType);
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
