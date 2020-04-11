using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator.Models;

namespace Calculator.Controllers
{
public class HomeController : Controller  
{  
    [HttpGet]  
    public IActionResult Index()  
    {  
        return View();  
    }  
  
    [HttpPost]  
    public IActionResult Index( Operation model )  
    {   
        //Генерация двух случайных чисел
        var rand = new Random();
        model.FirstNumber = rand.Next(1001)-501; 
        model.SecondNumber = rand.Next(1001)-501; 

        //Можно раскомментировать эти строки для сокращения интервала чисел до [0;2], чтобы с большей вероятностью получить ситуацию "деление на ноль"
        //model.FirstNumber = rand.Next(3); 
        //model.SecondNumber = rand.Next(3);

        //В случае, если второй операнд равен 0, происходит редирект на страницу с ошибкой об этом, 
        //на которой есть ссылка для возвращения к странице с генерацией чисел
        if (model.SecondNumber == 0) { return View ("CustomError"); }

        //Вычисления
        model.Addition = model.FirstNumber + model.SecondNumber; 
        model.Substraction = model.FirstNumber - model.SecondNumber;
        model.Division = model.FirstNumber / model.SecondNumber;
        model.Multiplication = model.FirstNumber * model.SecondNumber;

        return View( model );  
    }  
} 
}
