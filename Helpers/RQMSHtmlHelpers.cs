using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MvcApplication1.Helpers
{
    public static class RQMSHtmlHelpers
    {
        public static MvcHtmlString MyTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> helper,Expression<Func<TModel, TProperty>> expression,bool isDateField=false)
        {
            if (isDateField)
            {
                return helper.TextBoxFor(expression, new { @class = "datepicker data-change"});
            }
            else
            {
                return helper.TextBoxFor(expression, new { @class = "data-change" });
            }
        }

        public static MvcHtmlString MyTextBoxFor1<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression,string placeHolder, bool isDateField = false)
        {
            if (isDateField)
            {
                return helper.TextBoxFor(expression, new { @class = "datepicker data-change", placeholder = placeHolder});
            }
            else
            {
                return helper.TextBoxFor(expression, new { @class = "data-change", placeholder = placeHolder });
            }
        }

        public static MvcHtmlString CheckBoxStringFor<TModel>(this HtmlHelper<TModel> html, Expression<Func<TModel, string>> expression)
        {
            // get the name of the property
            string[] propertyNameParts = expression.Body.ToString().Split('.');
            string propertyName = propertyNameParts[propertyNameParts.Length-1];

            // get the value of the property
            Func<TModel, string> compiled = expression.Compile();
            string booleanStr = html.ViewData.Model!=null ?compiled(html.ViewData.Model):"false";

            if (booleanStr.ToUpper().Equals("Y"))
            {
                booleanStr = "true";
            }
            // convert it to a boolean
            bool isChecked = false;
            Boolean.TryParse(booleanStr, out isChecked);

            TagBuilder checkbox = new TagBuilder("input");
            checkbox.MergeAttribute("id", propertyName);
            checkbox.MergeAttribute("name", propertyName);
            checkbox.MergeAttribute("type", "checkbox");
            checkbox.MergeAttribute("value", "true");
            if (isChecked)
                checkbox.MergeAttribute("checked", "checked");

            TagBuilder hidden = new TagBuilder("input");
            hidden.MergeAttribute("name", propertyName);
            hidden.MergeAttribute("type", "hidden");
            hidden.MergeAttribute("value", "false");

            return MvcHtmlString.Create(checkbox.ToString(TagRenderMode.SelfClosing) + hidden.ToString(TagRenderMode.SelfClosing));
        }
    }
}