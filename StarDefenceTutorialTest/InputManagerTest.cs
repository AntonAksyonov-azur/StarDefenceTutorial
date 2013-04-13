using StarDefenceTutorial.com.andaforce.axna;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для InputManagerTest, в котором должны
    ///находиться все модульные тесты InputManagerTest
    ///</summary>
    [TestClass()]
    public class InputManagerTest
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
        ///Тест для GetMousePositionToPoint
        ///</summary>
        [TestMethod()]
        public void GetMousePositionToPointTest()
        {
            Point expected = new Point(); // TODO: инициализация подходящего значения
            Point actual;
            actual = InputManager.GetMousePositionToPoint();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetMousePositionToVector2
        ///</summary>
        [TestMethod()]
        public void GetMousePositionToVector2Test()
        {
            Vector2 expected = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 actual;
            actual = InputManager.GetMousePositionToVector2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsKeyDown
        ///</summary>
        [TestMethod()]
        public void IsKeyDownTest()
        {
            Keys key = new Keys(); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsKeyDown(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsKeyPressed
        ///</summary>
        [TestMethod()]
        public void IsKeyPressedTest()
        {
            Keys key = new Keys(); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsKeyPressed(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseLeftClick
        ///</summary>
        [TestMethod()]
        public void IsMouseLeftClickTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseLeftClick();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseLeftDown
        ///</summary>
        [TestMethod()]
        public void IsMouseLeftDownTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseLeftDown();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseMiddleClick
        ///</summary>
        [TestMethod()]
        public void IsMouseMiddleClickTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseMiddleClick();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseMiddleDown
        ///</summary>
        [TestMethod()]
        public void IsMouseMiddleDownTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseMiddleDown();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseRightClick
        ///</summary>
        [TestMethod()]
        public void IsMouseRightClickTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseRightClick();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseRightDown
        ///</summary>
        [TestMethod()]
        public void IsMouseRightDownTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseRightDown();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseWheelDown
        ///</summary>
        [TestMethod()]
        public void IsMouseWheelDownTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseWheelDown();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsMouseWheelUp
        ///</summary>
        [TestMethod()]
        public void IsMouseWheelUpTest()
        {
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = InputManager.IsMouseWheelUp();
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
            InputManager.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }
    }
}
