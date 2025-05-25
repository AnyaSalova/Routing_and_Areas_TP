using Microsoft.AspNetCore.Mvc;

public class MyController : Controller
{
    /// <summary>
    /// Стартовая страница лабораторной работы.
    /// </summary>
    public IActionResult StartPage()
    {
        return View("Start");
    }

    /// <summary>
    /// Метод для демонстрации передачи пользовательской переменной через маршрут.
    /// </summary>
    public IActionResult Start0(string? uvar)
    {
        // Получаем значение uvar через RouteData.Values
        var routeUvar = RouteData.Values["uvar"]?.ToString();
        string result = string.IsNullOrEmpty(routeUvar) ? "Пользовательская переменная не задана" : routeUvar;
        return View("StrictView", result);
    }
} 