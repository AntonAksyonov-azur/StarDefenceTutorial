using StarDefenceTutorial.com.c3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для Primitives2DTest, в котором должны
    ///находиться все модульные тесты Primitives2DTest
    ///</summary>
    [TestClass()]
    public class Primitives2DTest
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
        ///Тест для CreateArc
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void CreateArcTest()
        {
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            float startingAngle = 0F; // TODO: инициализация подходящего значения
            float radians = 0F; // TODO: инициализация подходящего значения
            List<Vector2> expected = null; // TODO: инициализация подходящего значения
            List<Vector2> actual;
            actual = Primitives2D_Accessor.CreateArc(radius, sides, startingAngle, radians);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для CreateCircle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void CreateCircleTest()
        {
            double radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            List<Vector2> expected = null; // TODO: инициализация подходящего значения
            List<Vector2> actual;
            actual = Primitives2D_Accessor.CreateCircle(radius, sides);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для CreateThePixel
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void CreateThePixelTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Primitives2D_Accessor.CreateThePixel(spriteBatch);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawArc
        ///</summary>
        [TestMethod()]
        public void DrawArcTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 center = new Vector2(); // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            float startingAngle = 0F; // TODO: инициализация подходящего значения
            float radians = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawArc(spriteBatch, center, radius, sides, startingAngle, radians, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawArc
        ///</summary>
        [TestMethod()]
        public void DrawArcTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 center = new Vector2(); // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            float startingAngle = 0F; // TODO: инициализация подходящего значения
            float radians = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawArc(spriteBatch, center, radius, sides, startingAngle, radians, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawCircle
        ///</summary>
        [TestMethod()]
        public void DrawCircleTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawCircle(spriteBatch, x, y, radius, sides, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawCircle
        ///</summary>
        [TestMethod()]
        public void DrawCircleTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 center = new Vector2(); // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawCircle(spriteBatch, center, radius, sides, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawCircle
        ///</summary>
        [TestMethod()]
        public void DrawCircleTest2()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawCircle(spriteBatch, x, y, radius, sides, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawCircle
        ///</summary>
        [TestMethod()]
        public void DrawCircleTest3()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 center = new Vector2(); // TODO: инициализация подходящего значения
            float radius = 0F; // TODO: инициализация подходящего значения
            int sides = 0; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawCircle(spriteBatch, center, radius, sides, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 point1 = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 point2 = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, point1, point2, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x1 = 0F; // TODO: инициализация подходящего значения
            float y1 = 0F; // TODO: инициализация подходящего значения
            float x2 = 0F; // TODO: инициализация подходящего значения
            float y2 = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, x1, y1, x2, y2, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest2()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x1 = 0F; // TODO: инициализация подходящего значения
            float y1 = 0F; // TODO: инициализация подходящего значения
            float x2 = 0F; // TODO: инициализация подходящего значения
            float y2 = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, x1, y1, x2, y2, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest3()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 point = new Vector2(); // TODO: инициализация подходящего значения
            float length = 0F; // TODO: инициализация подходящего значения
            float angle = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, point, length, angle, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest4()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 point1 = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 point2 = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, point1, point2, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawLine
        ///</summary>
        [TestMethod()]
        public void DrawLineTest5()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 point = new Vector2(); // TODO: инициализация подходящего значения
            float length = 0F; // TODO: инициализация подходящего значения
            float angle = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawLine(spriteBatch, point, length, angle, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawPoints
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void DrawPointsTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            List<Vector2> points = null; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D_Accessor.DrawPoints(spriteBatch, position, points, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawRectangle
        ///</summary>
        [TestMethod()]
        public void DrawRectangleTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 location = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 size = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawRectangle(spriteBatch, location, size, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawRectangle
        ///</summary>
        [TestMethod()]
        public void DrawRectangleTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Rectangle rect = new Rectangle(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float thickness = 0F; // TODO: инициализация подходящего значения
            Primitives2D.DrawRectangle(spriteBatch, rect, color, thickness);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawRectangle
        ///</summary>
        [TestMethod()]
        public void DrawRectangleTest2()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 location = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 size = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawRectangle(spriteBatch, location, size, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для DrawRectangle
        ///</summary>
        [TestMethod()]
        public void DrawRectangleTest3()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Rectangle rect = new Rectangle(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.DrawRectangle(spriteBatch, rect, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 location = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 size = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float angle = 0F; // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, location, size, color, angle);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            float w = 0F; // TODO: инициализация подходящего значения
            float h = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, x, y, w, h, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest2()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Rectangle rect = new Rectangle(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float angle = 0F; // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, rect, color, angle);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest3()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 location = new Vector2(); // TODO: инициализация подходящего значения
            Vector2 size = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, location, size, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest4()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Rectangle rect = new Rectangle(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, rect, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для FillRectangle
        ///</summary>
        [TestMethod()]
        public void FillRectangleTest5()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            float w = 0F; // TODO: инициализация подходящего значения
            float h = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            float angle = 0F; // TODO: инициализация подходящего значения
            Primitives2D.FillRectangle(spriteBatch, x, y, w, h, color, angle);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для PutPixel
        ///</summary>
        [TestMethod()]
        public void PutPixelTest()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            float x = 0F; // TODO: инициализация подходящего значения
            float y = 0F; // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.PutPixel(spriteBatch, x, y, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для PutPixel
        ///</summary>
        [TestMethod()]
        public void PutPixelTest1()
        {
            SpriteBatch spriteBatch = null; // TODO: инициализация подходящего значения
            Vector2 position = new Vector2(); // TODO: инициализация подходящего значения
            Color color = new Color(); // TODO: инициализация подходящего значения
            Primitives2D.PutPixel(spriteBatch, position, color);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }
    }
}
