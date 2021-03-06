﻿using EmployeesList_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesList_Homework.Controllers
{
    public class HomeController : Controller
    {
        private static IEnumerable<Employee> _employees = new List<Employee>() {
            new Employee() { Id = 1, Name = "Денис", Surename = "Огурцов", Patronymic = "Сергеевич", Gender = "Мужской", Age = 38, Profession = "Электрормонтёр"},
            new Employee() { Id = 2, Name = "Ольга", Surename = "Самохвалова", Patronymic = "Викторовна", Gender = "Женский", Age = 32, Profession = "Бухгалтер"},
            new Employee() { Id = 3, Name = "Виктор", Surename = "Быков", Patronymic = "Николаевич", Gender = "Мужской", Age = 55, Profession = "Мастер"},
            new Employee() { Id = 4, Name = "Олег", Surename = "Костерин", Patronymic = "Викторович", Gender = "Мужской", Age = 38, Profession = "Инженер АСУ ТП"},
            new Employee() { Id = 5, Name = "Юрий", Surename = "Корюнин", Patronymic = "Анатольевич", Gender = "Мужской", Age = 46, Profession = "Слесарь"},
            new Employee() { Id = 6, Name = "Анна", Surename = "Огурцова", Patronymic = "Александровна", Gender = "Женский", Age = 35, Profession = "Инженер по ТБ"},
        };

        
        public IActionResult EmployeesList()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            Employee employee = _employees.FirstOrDefault(emp => emp.Id == id);

            return View(employee);
        }
    }
}
