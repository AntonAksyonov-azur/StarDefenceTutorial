using StarDefenceTutorial.com.andaforce.axna.graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для SpritemapTest, в котором должны
    ///находиться все модульные тесты SpritemapTest
    ///</summary>
    [TestClass()]
    public class SpritemapTest
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
        ///Тест для Конструктор Spritemap
        ///</summary>
        [TestMethod()]
        public void SpritemapConstructorTest()
        {
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight);
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        /// <summary>
        ///Тест для AddAnimation
        ///</summary>
        [TestMethod()]
        public void AddAnimationTest()
        {
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight); // TODO: инициализация подходящего значения
            string name = string.Empty; // TODO: инициализация подходящего значения
            Point firstFramePosition = new Point(); // TODO: инициализация подходящего значения
            int framesCount = 0; // TODO: инициализация подходящего значения
            float frameRate = 0F; // TODO: инициализация подходящего значения
            bool loop = false; // TODO: инициализация подходящего значения
            target.AddAnimation(name, firstFramePosition, framesCount, frameRate, loop);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для GetCurrentFrameRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void GetCurrentFrameRectangleTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Spritemap_Accessor target = new Spritemap_Accessor(param0); // TODO: инициализация подходящего значения
            Rectangle expected = new Rectangle(); // TODO: инициализация подходящего значения
            Rectangle actual;
            actual = target.GetCurrentFrameRectangle();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для PlayAnimation
        ///</summary>
        [TestMethod()]
        public void PlayAnimationTest()
        {
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight); // TODO: инициализация подходящего значения
            string name = string.Empty; // TODO: инициализация подходящего значения
            int forceFrame = 0; // TODO: инициализация подходящего значения
            target.PlayAnimation(name, forceFrame);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RemoveAnimation
        ///</summary>
        [TestMethod()]
        public void RemoveAnimationTest()
        {
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight); // TODO: инициализация подходящего значения
            string name = string.Empty; // TODO: инициализация подходящего значения
            target.RemoveAnimation(name);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Render
        ///</summary>
        [TestMethod()]
        public void RenderTest()
        {
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight); // TODO: инициализация подходящего значения
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
            Texture2D source = null; // TODO: инициализация подходящего значения
            int frameWidth = 0; // TODO: инициализация подходящего значения
            int frameHeight = 0; // TODO: инициализация подходящего значения
            Spritemap target = new Spritemap(source, frameWidth, frameHeight); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }
    }
}
