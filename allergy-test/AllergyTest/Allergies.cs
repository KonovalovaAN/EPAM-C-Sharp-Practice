using System;

namespace AllergyTest
{
    /// <summary>
    /// Encapsulate the information about allergy test score and its analysis.
    /// </summary>
    public class Allergies
    {
        private readonly int score;

        /// <summary>
        /// Initializes a new instance of the <see cref="Allergies"/> class with test score.
        /// </summary>
        /// <param name="score">The allergy test score.</param>
        /// <exception cref="ArgumentException">Thrown when score is less than zero.</exception>
        public Allergies(int score)
        {
            if (score < 0)
            {
                throw new ArgumentException("Score cannot be less than zero.", nameof(score));
            }

            this.score = score;
        }

        /// <summary>
        /// Determines on base on the allergy test score for the given person, whether or not they're allergic to a given allergen(s).
        /// </summary>
        /// <param name="allergen">Allergen to check.</param>
        /// <returns>true if there is an allergy to this allergen, false otherwise.</returns>
        public bool IsAllergicTo(Allergens allergen)
        {
#pragma warning disable SA1101 // Prefix local calls with this
            return (score & (int)allergen) != 0;
#pragma warning restore SA1101 // Prefix local calls with this
        }

        /// <summary>
        /// Determines the full list of allergies of the person with the given allergy test score.
        /// </summary>
        /// <returns>Full list of allergies of the person with the given allergy test score.</returns>
        public Allergens[] AllergensList()
        {
            var allergens = Enum.GetValues(typeof(Allergens));
            var result = new List<Allergens>();

#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
            foreach (Allergens allergen in allergens)
            {
#pragma warning disable SA1101 // Prefix local calls with this
                if (IsAllergicTo(allergen))
                {
                    result.Add(allergen);
                }
#pragma warning restore SA1101 // Prefix local calls with this
            }
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions

            return result.ToArray();
        }
    }
}
