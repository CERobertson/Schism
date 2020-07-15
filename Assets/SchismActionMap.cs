using System;
using System.Collections.Generic;
using System.Linq;

// !IMPORTANT!
// The ascending value order of the ActionMap Enum must match
// The alphabetical order the InputActions.*Actions.
// !IMPORTANT!
[Flags]
public enum ActionMap {
    None                        = 0,
    Any                         = 0x1,
    OneDimension                = 0x2,
    VehicleAttitudes            = 0x4,
    VehicleBasic                = 0x8,
    VehicleDampeners            = 0x10,
    VehicleExternalConsole      = 0x20,
    VehicleFreeLook             = 0x40,
    VehicleInternalConsole      = 0x80,
    VehicleMotors               = 0x100
}

public static class ActionMapExtensions {
    public static bool AllowAddition(this ActionMap source, ActionMap possibility) {
        var target = (source | possibility).Decompose().ToList();
        if (target.Count == 1)
            return target[0] == ActionMap.Any |
                   target[0] == ActionMap.OneDimension |
                   target[0] == ActionMap.VehicleBasic;
        else if(target.Contains(ActionMap.VehicleBasic)) {
            return !(target.Contains(ActionMap.VehicleDampeners) & target.Contains(ActionMap.VehicleExternalConsole)) &&
                   !(target.Contains(ActionMap.VehicleDampeners) & target.Contains(ActionMap.VehicleInternalConsole)) &&
                   !(target.Contains(ActionMap.VehicleExternalConsole) & target.Contains(ActionMap.VehicleInternalConsole)) &&
                   !(target.Contains(ActionMap.VehicleFreeLook) & target.Contains(ActionMap.VehicleAttitudes));
        }
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
