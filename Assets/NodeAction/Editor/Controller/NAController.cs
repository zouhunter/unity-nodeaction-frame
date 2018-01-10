using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using NodeGraph;
using UnityEditor;
using System;

namespace NodeAction
{
    public class NAController : NodeGraph.NodeGraphController
    {
        public override string Group
        {
            get
            {
                return "nodeaction";
            }
        }
    }
}
