using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Helpers
{
    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var values = bindingContext.ValueProvider.GetValue("userPosition");

            if (values.Length == 0)
            {
                return Task.CompletedTask;
            }

            
            var result = new UserPosition()
            {
               
            };

            
            
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
    public class UserPosition
    {
        public string UserName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
