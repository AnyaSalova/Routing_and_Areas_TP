using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

/// <summary>
/// Пользовательское ограничение маршрута: переменная должна начинаться с буквы 'A' или быть не задана.
/// </summary>
public class CustomRouteConstraint : IRouteConstraint
{
    /// <summary>
    /// Проверяет, удовлетворяет ли значение пользовательскому ограничению.
    /// </summary>
    /// <param name="httpContext">Контекст HTTP-запроса.</param>
    /// <param name="route">Маршрут.</param>
    /// <param name="routeKey">Ключ маршрута.</param>
    /// <param name="values">Словарь значений маршрута.</param>
    /// <param name="routeDirection">Направление маршрута.</param>
    /// <returns>True, если значение удовлетворяет ограничению; иначе False.</returns>
    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        // Ограничение: uvar должен начинаться с 'A' или быть не задан
        if (values.TryGetValue(routeKey, out var value) && value != null)
        {
            string str = value.ToString();
            return string.IsNullOrEmpty(str) || str.StartsWith("A");
        }
        return true;
    }
} 