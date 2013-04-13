using StarDefenceTutorial.com.andaforce.axna.graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для GraphicsTest, в котором должны
    ///находиться все модульные тесты GraphicsTest
    ///</summary>
    [TestClass()]
    public class GraphicsTest
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


        internal virtual Graphics CreateGraphics()
        {
            // TODO: создайте экземпляр подходящего конкретного класса.
            Graphics target = null;
            return target;
        }

        /// <summary>
        ///Тест для Render
        ///</summary>
        [TestMethod()]
        public void RenderTest()
        {
            Graphics target = CreateGraphics(); // TODO: инициализация подходящего значения
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            target.Render(spriteBatch, position);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Graphics target = CreateGraphics(); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }
    }
}
