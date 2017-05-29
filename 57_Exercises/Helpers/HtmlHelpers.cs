using System.Linq;
using System.Linq.Expressions;

namespace System.Web.Mvc
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString PlacholderFor<TModel, TValue>(this HtmlHelper<TModel> self, Expression<Func<TModel, TValue>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, self.ViewData);
            var placholderAttribute = metadata.AdditionalValues.FirstOrDefault(a => a.Key == "Placeholder");

            return MvcHtmlString.Create(placholderAttribute.Key == null ? "" : placholderAttribute.Value.ToString());
        }
    }
}