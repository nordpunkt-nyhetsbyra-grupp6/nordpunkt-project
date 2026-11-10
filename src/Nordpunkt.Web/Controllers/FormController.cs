using Microsoft.AspNetCore.Mvc;
using Nordpunkt.Web.Services;
using Nordpunkt.Web.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Nordpunkt.Web.Controllers;

public class FormController(
    IUmbracoContextAccessor umbracoContextAccessor,
    IUmbracoDatabaseFactory databaseFactory,
    ServiceContext services,
    AppCaches appCaches,
    IProfilingLogger profilingLogger,
    IPublishedUrlProvider publishedUrlProvider,
    FormSubmissionsService formSubmissions)
    : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{
    private readonly FormSubmissionsService _formSubmissions = formSubmissions;

    [HttpPost]
    public IActionResult HandleTipForm(TipFormViewModel model)
    {
        if (!ModelState.IsValid)
            return CurrentUmbracoPage();

        var result = _formSubmissions.SaveTipRequest(model);

        if (!result)
        {
            TempData["FormError"] = "Något gick fel och ditt tips skickades inte. Försök igen om en stund.";
            return RedirectToCurrentUmbracoPage();
        }

        TempData["FormSuccess"] = "Tack! Redaktionen har tagit emot ditt tips.";
        return RedirectToCurrentUmbracoPage();
    }
}
