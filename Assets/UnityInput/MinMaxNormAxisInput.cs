using UnityEngine;

public class MinMaxNormAxisInput
{
    private float MaxInput = 1f;
    private float MinInput = -1f;

    private const float Noise = 0.0001f; //!< Prevent division by Zero

    private AxisType Axis;
    public float Threshold = 0.01f;
    public bool Idle = true;

    public MinMaxNormAxisInput(AxisType axis)
    {
        Axis = axis;
        InputDeviceConfig.AxisMapping axisMapping = InputManager.activeDevice.config.GetAxisMapping(axis);
        DebugUtil.Assert(axisMapping != null, string.Format("Axis {0} have to be mapped.", axis));
        MinInput = axisMapping.min;
        MaxInput = axisMapping.max;
    }

    private float Range
    {
        get
        {
            return MaxInput - MinInput;
        }
    }

    public float Value
    {
        get
        {
            float rawInput = InputManager.activeDevice.state.GetAxis(Axis);
            float input = (rawInput - MinInput) / (Range + Noise);

            if (Idle && rawInput > Threshold)
                Idle = false;

            return input;
        }
    }
}