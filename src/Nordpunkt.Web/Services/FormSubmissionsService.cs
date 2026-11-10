using Nordpunkt.Web.ViewModels;
using Umbraco.Cms.Core.Services;

namespace Nordpunkt.Web.Services;

public class FormSubmissionsService(IContentService contentService)
{
    private readonly IContentService _contentService = contentService;

    public bool SaveTipRequest(TipFormViewModel model)
    {
        try
        {
            // Containern är inte publicerad, så vi når den inte via Models Builder. Vi hämtar den via alias.
            var container = _contentService.GetRootContent()
                .FirstOrDefault(x => x.ContentType.Alias == "tipSubmissions");

            if (container == null)
                return false;

            var requestName = $"{DateTime.Now:yyyy-MM-dd HH:mm} - {model.Title}";
            var request = _contentService.Create(requestName, container.Id, "tipRequest");

            request.SetValue("tipRequestTitle", model.Title);
            request.SetValue("tipRequestDescription", model.Description);
            request.SetValue("tipRequestName", model.Name);
            request.SetValue("tipRequestEmail", model.Email);
            request.SetValue("tipRequestPhone", model.Phone);

            var saveResult = _contentService.Save(request);

            return saveResult.Success;
        }
        catch
        {
            return false;
        }
    }
}
