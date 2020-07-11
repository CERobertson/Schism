using System;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum ActionMap {
    _none = 0,
    MenuOneDimension = 0x1,
    Test1 = 0x2,
    Test2 = 0x4,
    Test3 = 0x8,
    Test4 = 0x10
}

public static class ActionMapExtensions {
    public static bool AllowAddition(this ActionMap source, ActionMap possibility) {

        return false;
    }
    public static bool Contains(this ActionMap source, ActionMap value) => (source & value) != 0;
    public static IEnumerable<ActionMap> Decompose(this ActionMap source) {
        foreach (ActionMap actionMap in typeof(ActionMap).GetEnumValues()) {
            if (actionMap != 0 && source.Contains(actionMap)) {
                yield return actionMap;
            }
        }
    }
}
