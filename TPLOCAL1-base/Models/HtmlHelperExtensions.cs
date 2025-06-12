using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace TPLOCAL1.Models;

public static class HtmlHelperExtensions
{
    public static string CurrentViewName(this HtmlHelper html)
    {
        return Path.GetFileNameWithoutExtension(((RazorView)html.ViewContext.View).Path);
    }
}