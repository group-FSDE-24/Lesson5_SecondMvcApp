using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lesson5_SecondMvcApp.TagHelpers;

public class EmailTagHelper : TagHelper
{
    private string name = "email";
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
    }
}
