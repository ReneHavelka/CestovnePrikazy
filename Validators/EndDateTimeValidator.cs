using FluentValidation;
using System.Diagnostics;

namespace CestovnePrikazy.Validators
{
    internal class EndDateTimeValidator : AbstractValidator<DateTime>
    {
        DateTime _endDateTime;

        public EndDateTimeValidator(DateTime startDateTime, DateTime endDateTime)
        {
            _endDateTime = endDateTime;

            RuleFor(_endDateTime => _endDateTime)
                    .Must(_endDateTime => _endDateTime > startDateTime).WithMessage("Koniec pracovnej cesty musí byť neskorší ako začiatok.");
        }

        public void EndDateTimeValidate()
        {

            try
            {
                this.ValidateAndThrow(_endDateTime);
            }
            catch
            {
                throw;
            }
        }
    }
}
