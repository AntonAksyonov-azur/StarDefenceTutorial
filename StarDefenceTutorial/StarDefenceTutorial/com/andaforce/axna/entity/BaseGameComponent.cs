using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.c3;

namespace StarDefenceTutorial.com.andaforce.axna.entity
{
    /// <summary>
    ///     This is a game component that implements IUpdateable.
    /// </summary>
    public class BaseGameComponent : AXNAGameComponent
    {
        public float Angle;
        public Rectangle Hitbox;
        public Vector2 Position;
        public Graphics Graphic;

        public bool IsVisible = true;
        public bool IsActive = true;

        public BaseGameComponent(Graphics graphics, float x, float y, int width, int height)
        {
            Graphic = graphics;
            Hitbox = new Rectangle(0, 0, width, height);
            Position = new Vector2(x, y);
        }

        #region Basic actions
        public override void Draw(GameTime gameTime)
        {
            if (Graphic != null && IsVisible)
            {
                Graphic.Render(AXNA.SpriteBatch, Position);
            }

            if (AXNA.DebugMode)
            {
                AXNA.SpriteBatch.DrawRectangle(GetEntityRectangle(), Color.Red);
                AXNA.SpriteBatch.DrawRectangle(new Rectangle((int)Position.X - 3, (int)Position.Y - 3, 6, 6), Color.Lime);
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (Graphic != null && IsActive)
            {
                Graphic.Update(gameTime);
            }
        }

        #endregion

        #region Collide functions
        public bool CollideWith(BaseGameComponent gameComponent)
        {
            Rectangle thisRectange = GetEntityRectangle();
            Rectangle collideRectange = gameComponent.GetEntityRectangle();

            return thisRectange.Intersects(collideRectange);
        }

        public bool CollidePoint(int x, int y)
        {
            Rectangle thisRectange = GetEntityRectangle();

            return thisRectange.Contains(x, y);
        }

        public Rectangle GetEntityRectangle()
        {
            var entityRectangle =
                 new Rectangle(
                     (int)Position.X + Hitbox.X, (int)Position.Y + Hitbox.Y, Hitbox.Width, Hitbox.Height);

            return entityRectangle;
        }
        #endregion
    }
}