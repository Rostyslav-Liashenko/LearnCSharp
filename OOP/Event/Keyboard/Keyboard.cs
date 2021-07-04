using System;

namespace LearnEvent
{
    public class Keyboard
    {
        public event EventHandler<KeyEventArgs> KeyPress;

        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();
            if (KeyPress != null)
            {
                k.Ch = key;
                KeyPress(this, k);
            }
        }
    }
}
