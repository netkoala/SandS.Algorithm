﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandS.Algorithm.Library.Graph
{
    public abstract class AbstractGraphNode<T>
    {
        public AbstractGraphNode(T body, IEnumerable<AbstractGraphNode<T>> connections = null, GraphNodeColor color = GraphNodeColor.White)
        {
            this.Color = color;

            if (connections == null)
            {
                connections = new List<AbstractGraphNode<T>>();
            }

            this.Children = connections.ToList();

            this.Body = body;
        }

        public abstract GraphNodeColor Color { get; set; }

        public abstract IList<AbstractGraphNode<T>> Children { get; protected set; }

        public abstract T Body { get; set; }

        internal abstract void Connect(AbstractGraphNode<T> node);
        internal abstract void Disconnect(AbstractGraphNode<T> node);

    }
}
