using StarDefenceTutorial.com.andaforce.axna.ui;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для ClickableLabelTest, в котором должны
    ///находиться все модульные тесты ClickableLabelTest
    ///</summary>
    [TestClass()]
    public class ClickableLabelTest
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
        ///Тест для Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            string text = string.Empty; // TODO: инициализация подходящего значения
            SpriteFont font = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            Action action = null; // TODO: инициализация подходящего значения
            ClickableLabel target = new ClickableLabel(game, text, font, position, action); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Draw(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для IsClicked
        ///</summary>
        [TestMethod()]
        public void IsClickedTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            string text = string.Empty; // TODO: инициализация подходящего значения
            SpriteFont font = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            Action action = null; // TODO: инициализация подходящего значения
            ClickableLabel target = new ClickableLabel(game, text, font, position, action); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsClicked();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsHovered
        ///</summary>
        [TestMethod()]
        public void IsHoveredTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            string text = string.Empty; // TODO: инициализация подходящего значения
            SpriteFont font = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            Action action = null; // TODO: инициализация подходящего значения
            ClickableLabel target = new ClickableLabel(game, text, font, position, action); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsHovered();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Game game = null; // TODO: инициализация подходящего значения
            string text = string.Empty; // TODO: инициализация подходящего значения
            SpriteFont font = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            Action action = null; // TODO: инициализация подходящего значения
            ClickableLabel target = new ClickableLabel(game, text, font, position, action); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.Update(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Action
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void ActionTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            ClickableLabel_Accessor target = new ClickableLabel_Accessor(param0); // TODO: инициализация подходящего значения
            Action expected = null; // TODO: инициализация подходящего значения
            Action actual;
            target.Action = expected;
            actual = target.Action;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Font
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void FontTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            ClickableLabel_Accessor target = new ClickableLabel_Accessor(param0); // TODO: инициализация подходящего значения
            SpriteFont expected = null; // TODO: инициализация подходящего значения
            SpriteFont actual;
            target.Font = expected;
            actual = target.Font;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Position
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void PositionTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            ClickableLabel_Accessor target = new ClickableLabel_Accessor(param0); // TODO: инициализация подходящего значения
            Vector2 expected = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 actual;
            target.Position = expected;
            actual = target.Position;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Rect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void RectTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            ClickableLabel_Accessor target = new ClickableLabel_Accessor(param0); // TODO: инициализация подходящего значения
            Rectangle expected = new Rectangle(); // TODO: инициализация подходящего значения
            Rectangle actual;
            target.Rect = expected;
            actual = target.Rect;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Text
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void TextTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            ClickableLabel_Accessor target = new ClickableLabel_Accessor(param0); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.Text = expected;
            actual = target.Text;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
