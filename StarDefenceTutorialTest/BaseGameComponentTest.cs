using StarDefenceTutorial.com.andaforce.axna.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.axna.graphics;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для BaseGameComponentTest, в котором должны
    ///находиться все модульные тесты BaseGameComponentTest
    ///</summary>
    [TestClass()]
    public class BaseGameComponentTest
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
        ///Тест для Конструктор BaseGameComponent
        ///</summary>
        [TestMethod()]
        public void BaseGameComponentConstructorTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height);
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        /// <summary>
        ///Тест для CollidePoint
        ///</summary>
        [TestMethod()]
        public void CollidePointTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            int x1 = 0; // TODO: инициализация подходящего значения
            int y1 = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.CollidePoint(x1, y1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для CollideWith
        ///</summary>
        [TestMethod()]
        public void CollideWithTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            BaseGameComponent gameComponent = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.CollideWith(gameComponent);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Draw(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Equals
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void EqualsTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            BaseGameComponent_Accessor target = new BaseGameComponent_Accessor(param0); // TODO: инициализация подходящего значения
            BaseGameComponent other = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            object obj = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetCenter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void GetCenterTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            BaseGameComponent_Accessor target = new BaseGameComponent_Accessor(param0); // TODO: инициализация подходящего значения
            Vector2 expected = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 actual;
            actual = target.GetCenter();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetEntityRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void GetEntityRectangleTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            BaseGameComponent_Accessor target = new BaseGameComponent_Accessor(param0); // TODO: инициализация подходящего значения
            Rectangle expected = new Rectangle(); // TODO: инициализация подходящего значения
            Rectangle actual;
            actual = target.GetEntityRectangle();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            int expected = 0; // TODO: инициализация подходящего значения
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetTimeIntervalValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void GetTimeIntervalValueTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            BaseGameComponent_Accessor target = new BaseGameComponent_Accessor(param0); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            float expected = 0F; // TODO: инициализация подходящего значения
            float actual;
            actual = target.GetTimeIntervalValue(gameTime);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для OutOfBorderCheck
        ///</summary>
        [TestMethod()]
        public void OutOfBorderCheckTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            target.OutOfBorderCheck();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            Screen gameScreen = null; // TODO: инициализация подходящего значения
            Graphics graphics = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            int width = 0; // TODO: инициализация подходящего значения
            int height = 0; // TODO: инициализация подходящего значения
            BaseGameComponent target = new BaseGameComponent(game, gameScreen, graphics, x, y, width, height); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для ParentScreen
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void ParentScreenTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            BaseGameComponent_Accessor target = new BaseGameComponent_Accessor(param0); // TODO: инициализация подходящего значения
            Screen expected = null; // TODO: инициализация подходящего значения
            Screen actual;
            target.ParentScreen = expected;
            actual = target.ParentScreen;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
