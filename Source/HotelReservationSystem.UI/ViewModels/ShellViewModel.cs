using Caliburn.Micro;

namespace HotelReservationSystem.UI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel _viewModel;
        public ShellViewModel(LoginViewModel viewModel)
        {
            _viewModel = viewModel;
            ActivateItem(_viewModel);
        }
    }
}