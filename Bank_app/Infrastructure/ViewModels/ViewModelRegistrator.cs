﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Bank_app.Infrastructure.ViewModels
{
   public static class ViewModelRegistator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddScoped<AutorisationViewModel>()
            .AddScoped<RegistationViewModel>()
            .AddScoped<UserInterfaceViewModel>()
            .AddScoped<MakeCreditViewModel>()
             .AddScoped<ReferentInterfaceViewModel>()
            .AddScoped<Users_Credit_Requests_ViewModel>()
           ;
    }
}
