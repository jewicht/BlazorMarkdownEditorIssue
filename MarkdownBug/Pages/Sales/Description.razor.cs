using PSC.Blazor.Components.MarkdownEditor;

namespace MarkdownBug.Pages.Sales;
partial class Description
{
    static string[] HiddenIcons = ["side-by-side", "fullscreen", "image", "preview"];

    MarkdownEditor MarkdownEditor;

    string LanguageCode = string.Empty;
    int TradeTypeID;

    string MarkdownString = string.Empty;
    string MarkdownHTML = string.Empty;

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }
}
