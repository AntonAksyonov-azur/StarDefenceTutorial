using StarDefenceTutorial.com.andaforce.game.config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для ConfigurationTest, в котором должны
    ///находиться все модульные тесты ConfigurationTest
    ///</summary>
    [TestClass()]
    public class ConfigurationTest
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
        ///Тест для Конструктор Configuration
        ///</summary>
        [TestMethod()]
        public void ConfigurationConstructorTest()
        {
            Configuration target = new Configuration();
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        /// <summary>
        ///Тест для GetInstance
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            Configuration expected = null; // TODO: инициализация подходящего значения
            Configuration actual;
            actual = Configuration.GetInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
