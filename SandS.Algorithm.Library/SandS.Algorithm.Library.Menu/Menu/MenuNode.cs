﻿using SandS.Algorithm.Library.GraphNamespace;
using System;
using System.Collections.Generic;

namespace SandS.Algorithm.Library.MenuNamespace
{
    public enum MenuNodeType
    {
        Head = 0,
        Node = 1,
        GameStart = 2,
        GameExit = 3,
    }

    public class MenuNode<T> : GraphNode<T>, ICloneable
        where T : MenuNodeBody
    {
        public MenuNode(T body,
            IEnumerable<MenuNode<T>> connections = null,
            GraphNodeColor color = GraphNodeColor.White) : base(body, connections, color)
        {
        }
    }
}