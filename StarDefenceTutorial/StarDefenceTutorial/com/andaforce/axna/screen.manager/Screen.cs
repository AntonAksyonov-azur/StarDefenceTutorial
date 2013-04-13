using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.entity;

namespace StarDefenceTutorial.com.andaforce.axna.screen.manager
{
    public class Screen
    {
        internal string Name { get; private set; }

        internal List<AXNAGameComponent> GameComponents = new List<AXNAGameComponent>();
        internal List<AXNAGameComponent> AddList = new List<AXNAGameComponent>();
        internal List<AXNAGameComponent> RemoveList = new List<AXNAGameComponent>();

        internal Screen(String name)
        {
            Name = name;
        }

        internal virtual bool Initialize()
        {
            return true;
        }

        internal virtual void OnRemove()
        {
            GameComponents.RemoveRange(0, GameComponents.Count);
        }

        internal void AddComponent(AXNAGameComponent gameComponent)
        {
            AddList.Add(gameComponent);
        }

        internal void RemoveComponent(AXNAGameComponent gameComponent)
        {
            RemoveList.Add(gameComponent);
        }

        internal virtual void OnUpdate(GameTime gameTime)
        {
            UpdateLists();

            foreach (AXNAGameComponent gameComponent in GameComponents)
            {
                gameComponent.Update(gameTime);
            }
        }

        private void UpdateLists()
        {
            // Добавление
            foreach (AXNAGameComponent gameComponent in AddList)
            {
                gameComponent.ParentScreen = this;
                GameComponents.Add(gameComponent);
            }

            // Удаление
            foreach (AXNAGameComponent gameComponent in RemoveList)
            {
                gameComponent.ParentScreen = null;
                GameComponents.Remove(gameComponent);
            }

            AddList.RemoveRange(0, AddList.Count);
            RemoveList.RemoveRange(0, RemoveList.Count);
        }

        internal virtual void OnDraw(GameTime gameTime)
        {
            AXNA.SpriteBatch.Begin();

            foreach (AXNAGameComponent gameComponent in GameComponents)
            {
                gameComponent.Draw(gameTime);
            }

            AXNA.SpriteBatch.End();
        }
    }
}