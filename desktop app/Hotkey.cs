using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Data;

namespace desktop_app
{
    public class Hotkey
    {
        public Key key { get; }

        public static string asd { get; } = "asd";

        public ModifierKeys modifiers { get; }

        public ICommand command { get; }

        public UIElement owner { get; }

        public KeyBinding currBinding { get; set; }


        public Hotkey(Key _key, ModifierKeys _modifiers, ICommand _command, UIElement _owner)
        {
            key = _key;
            modifiers = _modifiers;
            command = _command;
            owner = _owner;
            UpdateKey(new KeyGesture(key, modifiers));
        }

        public override string ToString()
        {


            return (new KeyGesture(key, modifiers)).DisplayString;
        }

        public void UpdateKey(KeyGesture newBinding )
        {   if(currBinding == null )
            {
                currBinding = new KeyBinding(command, newBinding);
                owner.InputBindings.Add(new KeyBinding(command,newBinding));
                return;
            }
            int index = owner.InputBindings.IndexOf(currBinding);
            currBinding = new KeyBinding(command, newBinding);

            owner.InputBindings[index] = currBinding;


        }



    }
}
