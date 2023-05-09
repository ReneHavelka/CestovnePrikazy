using FluentValidation;
using System.Diagnostics;

namespace CestovnePrikazy.Validators
{
    public class SelectionValidator : AbstractValidator<int>
    {
        int _iD;
        public SelectionValidator(int iD)
        {
            _iD = iD;
            RuleFor(_iD => _iD)
                    .Must(_iD => _iD > 0).WithMessage("Toto je povinný údaj.");
        }

        public void SelectionValidate()
        {
            try
            {
                this.ValidateAndThrow(_iD);
            }
            catch
            {
                throw;
            }
        }
    }
}
