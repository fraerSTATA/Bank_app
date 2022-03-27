using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app.Infrastructure.ViewModels
{
    class ViewModelLocator
    {
        public AutorisationViewModel Autorisation => App.Services.GetRequiredService<AutorisationViewModel>();

        public RegistationViewModel Registration => App.Services.GetRequiredService<RegistationViewModel>();

        public UserInterfaceViewModel userInterface => App.Services.GetRequiredService<UserInterfaceViewModel>();

        public MakeCreditViewModel MakeCredit => App.Services.GetRequiredService<MakeCreditViewModel>();

        public ReferentInterfaceViewModel ReferentInterface => App.Services.GetRequiredService<ReferentInterfaceViewModel>();

        public Users_Credit_Requests_ViewModel UserCreditRequests => App.Services.GetRequiredService<Users_Credit_Requests_ViewModel>();
    }
}
