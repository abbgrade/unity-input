using UnityEngine;

/// <summary>
/// Add a capacity to a ButtonInput to prevent bouncing behavior and return a smooth output.
/// </summary>
class SlothfulButtonInput
{
    private ButtonType buttonType;
    private RingBuffer<bool> valueBuffer;
    private bool previousState;

    /// <param name="buttonType">The observed button</param>
    /// <param name="timeFrame">The time, that the input is bufferd to smooth the output.</param>
    public SlothfulButtonInput(ButtonType buttonType, float timeFrame)
    {
        this.buttonType = buttonType;

        int capacity = Mathf.CeilToInt(timeFrame / Time.fixedDeltaTime);
        valueBuffer = new RingBuffer<System.Boolean>(capacity);
    }

    private bool state
    {
        get
        {
            int sum = 0;
            foreach (bool x in valueBuffer)
                if (x)
                    sum++;
            return sum / valueBuffer.Capacity >= 0.5;
        }
    }

    public void Update()
    {
        valueBuffer.Add(InputManager.activeDevice.GetButton(buttonType));

        DownSide = state && (state != previousState);

        previousState = state;
    }

    public bool DownSide { get; private set; } //!< The down side of the button press action

}
