using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastWithAuth.Models;

namespace WeatherForecastWithAuth.Services
{
    public interface IAuthenticateService
    {
        Student Authenticate(String UserName, String Password);

    }
}
