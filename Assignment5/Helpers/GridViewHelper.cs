namespace Assignment5.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Newtonsoft.Json.Linq;

    public class GridColumn<TModel>
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public Expression<Func<TModel, object>> ValueExpression { get; set; }

    }

    public static class HtmlHelperExtensions
    {
        public static IHtmlContent GridView<TModel>(this IHtmlHelper<IEnumerable<TModel>> htmlHelper, IEnumerable<TModel> data, IEnumerable<GridColumn<TModel>> columns)
        {
            var table = new TagBuilder("table");
            table.AddCssClass("table");

            var thead = new TagBuilder("thead");
            var tbody = new TagBuilder("tbody");

            var tr = new TagBuilder("tr");
            foreach (var column in columns)
            {
                var th = new TagBuilder("th");
                th.InnerHtml.Append(column.Header);
                tr.InnerHtml.AppendHtml(th);
            }
            thead.InnerHtml.AppendHtml(tr);

            foreach (var item in data)
            {
                tr = new TagBuilder("tr");
                foreach (var column in columns)
                {
                    var td = new TagBuilder("td");

                    // Ensure column and its ValueExpression are not null before accessing
                    if (column != null && column.ValueExpression != null && column.ValueExpression.Compile() != null)
                    {
                        td.InnerHtml.AppendHtml(column.ValueExpression.Compile()(item).ToString());
                    }
                    else
                    {
                        td.InnerHtml.AppendHtml("N/A"); // or handle differently if ValueExpression is null
                    }
                    tr.InnerHtml.AppendHtml(td);
                }
                tbody.InnerHtml.AppendHtml(tr);
            }

            table.InnerHtml.AppendHtml(thead);
            table.InnerHtml.AppendHtml(tbody);

            return table;
        }
    }
}
