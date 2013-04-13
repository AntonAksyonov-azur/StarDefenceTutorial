using StarDefenceTutorial.com.andaforce.game.screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для MenuScreenTest, в котором должны
    ///находиться все модульные тесты MenuScreenTest
    ///</summary>
    [TestClass()]
    public class MenuScreenTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Конструктор MenuScreen
        ///</summary>
        [TestMethod()]
        public void MenuScreenConstructorTest()
        {
            MenuScreen target = new MenuScreen();
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        /// <summary>
        ///Тест для Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            MenuScreen target = new MenuScreen(); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.Initialize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
