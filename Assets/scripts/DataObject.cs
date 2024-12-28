using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu(fileName = "DataObject", menuName = "Scriptable Objects/DataObject")]
public class DataObject : ScriptableObject
{
    [Header("Game Data")]
    public int nuts = 0;
    public int bolts = 0;
}
