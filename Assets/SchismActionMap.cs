using System;
using System.Collections.Generic;
using UnityEngine;

// !IMPORTANT!
// The ascending value order of the ActionMap Enum must match
// The alphabetical order the InputActions.*Actions.
// !IMPORTANT!
[Flags]
public enum ActionMap {
    _none = 0,
    OneDimension = 0x1,
    Test1 = 0x2,
    Test2 = 0x4,
    Test3 = 0x8,
    Test4 = 0x10
}

public static class ActionMapExtensions {
    public static bool AllowAddition(this ActionMap source, ActionMap possibility) {
        return source == 0;
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
