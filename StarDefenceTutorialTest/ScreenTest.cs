using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorialTest
{
    
    
    /// <summary>
    ///Это класс теста для ScreenTest, в котором должны
    ///находиться все модульные тесты ScreenTest
    ///</summary>
    [TestClass()]
    public class ScreenTest
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
        ///Тест для Конструктор Screen
        ///</summary>
        [TestMethod()]
        public void ScreenConstructorTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name);
            Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        /// <summary>
        ///Тест для AddComponent
        ///</summary>
        [TestMethod()]
        public void AddComponentTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            DrawableGameComponent gameComponent = null; // TODO: инициализация подходящего значения
            target.AddComponent(gameComponent);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.Initialize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для OnDraw
        ///</summary>
        [TestMethod()]
        public void OnDrawTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.OnDraw(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для OnRemove
        ///</summary>
        [TestMethod()]
        public void OnRemoveTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            target.OnRemove();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для OnUpdate
        ///</summary>
        [TestMethod()]
        public void OnUpdateTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            GameTime gameTime = null; // TODO: инициализация подходящего значения
            target.OnUpdate(gameTime);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RemoveComponent
        ///</summary>
        [TestMethod()]
        public void RemoveComponentTest()
        {
            string name = string.Empty; // TODO: инициализация подходящего значения
            Screen target = new Screen(name); // TODO: инициализация подходящего значения
            DrawableGameComponent gameComponent = null; // TODO: инициализация подходящего значения
            target.RemoveComponent(gameComponent);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для UpdateLists
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void UpdateListsTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Screen_Accessor target = new Screen_Accessor(param0); // TODO: инициализация подходящего значения
            target.UpdateLists();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StarDefenceTutorial.exe")]
        public void NameTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Screen_Accessor target = new Screen_Accessor(param0); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
