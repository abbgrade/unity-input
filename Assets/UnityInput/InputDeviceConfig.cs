using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Configuration of an Input Device.
/// </summary>
public class InputDeviceConfig : MonoBehaviour
{
    public bool windowsOnly = false; //!< Use this for OS-specific config.
    public bool macOnly = false; //!< Use this for OS-specific config.
    public bool isJoystick = false; //!< Uses joystick axes & buttons.

    // all joystick names that should use this config are in this list
    // known problem: on mac the name of a xbox controller (non-wireless) is an empty string
    public List<string> joystickNames;

    public float sensitivity = 1; //!< Sensitivity of this device config (input manager sensitivity is overriden).
    public float deadZone = 0;

    public List<ButtonMapping> buttonMappings = new List<ButtonMapping>();
    public List<AxisMapping> axisMappings = new List<AxisMapping>();

    public string GetButton(ButtonType buttonType)
    {
        foreach (ButtonMapping mapping in buttonMappings)
        {
            if (mapping.target == buttonType)
                return mapping.button;
        }
        return "";
    }

    public AxisMapping GetAxisMapping(AxisType axisType)
    {
        foreach (AxisMapping mapping in axisMappings)
        {
            if (mapping.target == axisType)
                return mapping;
        }
        return null;
    }

    [System.Serializable]
    public class ButtonMapping
    {
        public ButtonType target;
        public string button;
    }

    [System.Serializable]
    public class AxisMapping
    {
        public AxisType target;
        public string axis;
        public float min = -1f;
        public float max = 1f;
        public bool inversed = false;

        public float InverseFactor { get { return inversed ? -1f : 1f; } }
    }
}

[System.Flags]
public enum ButtonType
{
    None = 0,
    LeftBlinker = 1,
    RightBlinker = 2,
    ShiftUp = 4,
    ShiftDown = 8,
    Action5 = 16,
    Action6 = 32,
    Action7 = 64,
    Action8 = 128,
    Action9 = 256,
    Action10 = 512
}

public enum AxisType
{
    Wheel,
    Clutch,
    Brake,
    Throttle,
    LookHorizontal,
    LookVertical,
    WheelSensivity,
    Axis9,
    Axis10
}