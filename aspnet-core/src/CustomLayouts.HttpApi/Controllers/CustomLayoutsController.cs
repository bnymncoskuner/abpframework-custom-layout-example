using CustomLayouts.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomLayouts.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CustomLayoutsController : AbpController
    {
        protected CustomLayoutsController()
        {
            LocalizationResource = typeof(CustomLayoutsResource);
        }
    }
}