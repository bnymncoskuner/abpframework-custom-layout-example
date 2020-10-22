using System;
using System.Collections.Generic;
using System.Text;
using CustomLayouts.Localization;
using Volo.Abp.Application.Services;

namespace CustomLayouts
{
    /* Inherit your application services from this class.
     */
    public abstract class CustomLayoutsAppService : ApplicationService
    {
        protected CustomLayoutsAppService()
        {
            LocalizationResource = typeof(CustomLayoutsResource);
        }
    }
}
