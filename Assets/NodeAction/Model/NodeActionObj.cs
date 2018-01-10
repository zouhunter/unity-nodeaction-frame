using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using WorldActionSystem;
using NodeGraph;
using NodeGraph.DataModel;

namespace NodeAction
{
    [CreateAssetMenu(menuName = "生成/NodeActionObj")]
    public class NodeActionObj : ScriptableObject
    {
        public string graphGuid;
        public int totalCommand;
        public List<NodeActionInfo> actionInfos;
        public List<ActionPrefabItem> prefabList = new List<ActionPrefabItem>();
    }

}