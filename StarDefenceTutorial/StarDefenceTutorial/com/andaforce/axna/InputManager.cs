using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StarDefenceTutorial.com.andaforce.axna
{
    internal static class InputManager
    {
        private static KeyboardState _keyState;
        private static KeyboardState _keyOldState;
        private static MouseState _mouseState;
        private static MouseState _mouseOldState;

        internal static void Update(GameTime gameTime)
        {
            _keyOldState = _keyState;
            _mouseOldState = _mouseState;

            _keyState = Keyboard.GetState();
            _mouseState = Mouse.GetState();
        }

        internal static bool IsKeyDown(Keys key)
        {
            return _keyState.IsKeyDown(key);
        }

        internal static bool IsKeyPressed(Keys key)
        {
            return IsKeyDown(key) && _keyOldState.IsKeyUp(key);
        }

        internal static bool IsKeyUp(Keys key)
        {
            return !IsKeyDown(key) && _keyOldState.IsKeyDown(key);
        }

        internal static bool IsMouseLeftDown()
        {
            return _mouseState.LeftButton == ButtonState.Pressed;
        }

        internal static bool IsMouseLeftClick()
        {
            return IsMouseLeftDown() && _mouseOldState.LeftButton == ButtonState.Released;
        }

        internal static bool IsMouseRightDown()
        {
            return _mouseState.RightButton == ButtonState.Pressed;
        }

        internal static bool IsMouseRightClick()
        {
            return IsMouseRightDown() && _mouseOldState.RightButton == ButtonState.Released;
        }

        internal static bool IsMouseMiddleDown()
        {
            return _mouseState.MiddleButton == ButtonState.Pressed;
        }

        internal static bool IsMouseMiddleClick()
        {
            return IsMouseMiddleDown() && _mouseOldState.MiddleButton == ButtonState.Released;
        }

        internal static bool IsMouseWheelUp()
        {
            return _mouseState.ScrollWheelValue > _mouseOldState.ScrollWheelValue;
        }

        internal static bool IsMouseWheelDown()
        {
            return _mouseState.ScrollWheelValue < _mouseOldState.ScrollWheelValue;
        }

        internal static Vector2 GetMousePositionToVector2()
        {
            return new Vector2(_mouseState.X, _mouseState.Y);
        }

        internal static Point GetMousePositionToPoint()
        {
            return new Point(_mouseState.X, _mouseState.Y);
        }

        internal static int GetMouseX()
        {
            return _mouseState.X;
        }

        internal static int GetMouseY()
        {
            return _mouseState.Y;
        }


    }
}
