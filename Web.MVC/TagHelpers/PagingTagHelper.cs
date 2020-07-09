using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.MVC.TagHelpers
{

    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }

        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }

        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            StringBuilder html = new StringBuilder();
            html.Append("<ul class='pagination'>");

            for (int i = 1; i <= PageCount; i++)
            {
                html.AppendFormat("<li class='page-item {0}'>", i == CurrentPage ? "active" : "");
                html.AppendFormat("<a href='/product/index?page={0}&category={1}' class='page-link'>{0}</a>", i, CurrentCategory);
                html.AppendFormat("</li>");
            }
            html.AppendFormat("</ul>");

            output.Content.SetHtmlContent(html.ToString());

            base.Process(context, output);
        }
    }
}
