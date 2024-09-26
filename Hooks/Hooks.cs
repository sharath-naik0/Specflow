﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class Hooks
    {
        private readonly ScenarioContext _scenarioContext;


        public Hooks(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;

        }


        [BeforeScenario]
        public void Setup()
        {

            Console.WriteLine("Running before every scenario");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
            _scenarioContext["WebDriver"] = driver;
        }
        [AfterScenario]
        public void TearDown()
        {

            Console.WriteLine("Running after every scenario");
            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver?.Quit();

        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestContext.Progress.WriteLine("Running before TestRun");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.Progress.WriteLine("Running after TestRun");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("Running before every Step");
        }
        [AfterStep]
        public void AfterStep()
        {
            Console.WriteLine("Running after every Step");
        }
    }
}

