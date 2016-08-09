﻿using System;

namespace SandS.Algorithm.Library.EnumsNamespace
{
    [Flags]
    public enum InputKeyPressType
    {
        OnUp = 0,
        OnDown = 1,
    }

    [Flags]
    public enum MouseButton
    {
        Left = 0,
        Middle = 1,
        Right = 2,
    }

    [Flags]
    public enum Commands
    {
        Wait = 0,
        MoveUp = 1,
        MoveDown = 2,
        MoveLeft = 4,
        MoveRight = 8,
    }
}