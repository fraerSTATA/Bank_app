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
    }
}
