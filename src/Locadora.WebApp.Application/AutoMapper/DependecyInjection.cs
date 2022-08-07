using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.WebApp.Application.AutoMapper
{
    public static class DependecyInjection
    {
        public static void ConfigureDependeciesServices(this IServiceCollection serviceCollection)
        {            
            serviceCollection.AddAutoMapper(typeof(DomainToViewModelMap), typeof(ViewModelToDomainMap));
        }
    }
}
