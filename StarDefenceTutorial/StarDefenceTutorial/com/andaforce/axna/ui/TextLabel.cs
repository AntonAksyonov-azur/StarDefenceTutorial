using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.game.service.observer;

namespace StarDefenceTutorial.com.andaforce.axna.ui
{
    public class TextLabel : BaseGameComponent, ITextObserver
    {
        private readonly TextString _text;

        public TextLabel(TextString text, float x, float y, int width = 0, int height = 0)
            : base(text, x, y, width, height)
        {
            _text = text;
        }

        public void UpdateTextParameter(string text)
        {
            _text.Text = text;
        }
    }
}