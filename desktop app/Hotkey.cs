﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Data;
using System.Diagnostics;

namespace desktop_app
{
    public class Hotkey
    {
        public Key key { get; set; }

        public ModifierKeys modifiers { get; set; }

        public ICommand command { get; }

        public UIElement owner { get; }

        public string InputGestureText { get; set; } = "press key";

        public KeyBinding currBinding { get; set; }


        public Hotkey(Key _key, ModifierKeys _modifiers, ExecutedRoutedEventHandler executed , UIElement _owner)
        {
            command = new RoutedCommand();
            key = _key;
            modifiers = _modifiers;
            owner = _owner;
            owner.CommandBindings.Add(new CommandBinding(
                command, executed));

            UpdateKey(key, modifiers);
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            if (modifiers.HasFlag(ModifierKeys.Control))
                str.Append("Ctrl + ");
            if (modifiers.HasFlag(ModifierKeys.Shift))
                str.Append("Shift + ");
            if (modifiers.HasFlag(ModifierKeys.Alt))
                str.Append("Alt + ");
            if (modifiers.HasFlag(ModifierKeys.Windows))
                str.Append("Win + ");

            str.Append(key);

            return str.ToString();
        }


        public void UpdateKey(Key _key, ModifierKeys _modifiers)
        {
            key = _key;
            modifiers = _modifiers;

            InputGestureText = this.ToString();
            if (currBinding == null )
            {
                owner.InputBindings.Add(new KeyBinding(command,key,modifiers));
                currBinding = new KeyBinding(command, key, modifiers);
                return;
            }
            int index = -1
            for ()
            currBinding = new KeyBinding(command, key, modifiers);

            owner.InputBindings[index] = currBinding;


        }



    }
}
