using StarDefenceTutorial.com.andaforce.axna.graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для AnimTest, в котором должны
    ///находиться все модульные тесты AnimTest
    ///</summary>
    [TestClass()]
    public class AnimTest
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
        ///Тест для Конструктор Anim
        ///</summary>
        [TestMethod()]
        public void AnimConstructorTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Point firstFramePosition = new Point(); // TODO: инициализация подходящего значения
            int framesCount = 0; // TODO: инициализация подходящего значения
            float frameRate = 0F; // TODO: инициализация подходящего значения
            bool loop = false; // TODO: инициализация подходящего значения
            Anim target = new Anim(name, firstFramePosition, framesCount, frameRate, loop);
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }
    }
}
