using System;
using System.Management.Automation;
using PoShApiClient.Models.Requests;

namespace MyModule
{
    [Cmdlet(VerbsCommon.Get, "WeatherForecast")]
    public class GetWeatherForecast : BaseCmdlet<WeatherForecastRequest> 
    {

    }

    public abstract class BaseCmdlet<TRequestDto> : PSCmdlet, IDynamicParameters where TRequestDto : new()
    {
        public virtual object GetDynamicParameters()
        {
            return new TRequestDto();
        }
    }
}