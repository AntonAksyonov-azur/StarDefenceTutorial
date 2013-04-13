using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для ScreenManagerTest, в котором должны
    ///находиться все модульные тесты ScreenManagerTest
    ///</summary>
    [TestClass()]
    public class ScreenManagerTest
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
        ///Тест для ActivatePreviousScreen
        ///</summary>
        [TestMethod()]
        public void ActivatePreviousScreenTest()
        {
            ScreenManager.ActivatePreviousScreen();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для ActivateScreen
        ///</summary>
        [TestMethod()]
        public void ActivateScreenTest()
        {
            Screen screen = null; // TODO: инициализация подходящего значения
            ScreenManager.ActivateScreen(screen);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для ActivateScreenByIndex
        ///</summary>
        [TestMethod()]
        public void ActivateScreenByIndexTest()
        {
            int index = 0; // TODO: инициализация подходящего значения
            ScreenManager.ActivateScreenByIndex(index);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для ActivateScreenByName
        ///</summary>
        [TestMethod()]
        public void ActivateScreenByNameTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            ScreenManager.ActivateScreenByName(name);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для AddScreen
        ///</summary>
        [TestMethod()]
        public void AddScreenTest()
        {
            Screen screen = null; // TODO: инициализация подходящего значения
            ScreenManager.AddScreen(screen);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            ScreenManager.Draw(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для GetActiveScreen
        ///</summary>
        [TestMethod()]
        public void GetActiveScreenTest()
        {
            Screen expected = null; // TODO: инициализация подходящего значения
            Screen actual;
            actual = ScreenManager.GetActiveScreen();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetScreenByIndex
        ///</summary>
        [TestMethod()]
        public void GetScreenByIndexTest()
        {
            int index = 0; // TODO: инициализация подходящего значения
            Screen expected = null; // TODO: инициализация подходящего значения
            Screen actual;
            actual = ScreenManager.GetScreenByIndex(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetScreenByName
        ///</summary>
        [TestMethod()]
        public void GetScreenByNameTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen expected = null; // TODO: инициализация подходящего значения
            Screen actual;
            actual = ScreenManager.GetScreenByName(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetScreensCount
        ///</summary>
        [TestMethod()]
        public void GetScreensCountTest()
        {
            int expected = 0; // TODO: инициализация подходящего значения
            int actual;
            actual = ScreenManager.GetScreensCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            ScreenManager.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }
    }
}
