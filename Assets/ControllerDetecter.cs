using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerDetecter : MonoBehaviour
{

    public PlayerInput player1Input;
    public PlayerInput player2Input;

    private string keyboardScheme = "keyboard&mouse";
    private string defaultControllerScheme = "Gamepad";

    void Start()
    {
        InputSystem.onDeviceChange += OnDeviceChange;
        AssignPlayerDevices();
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if (change == InputDeviceChange.Added || change == InputDeviceChange.Removed)
        {
            AssignPlayerDevices();
        }
    }

    private void AssignPlayerDevices()
    {
        var devices = InputSystem.devices;

        InputDevice keyboardDevice = null;
        InputDevice[] gamepadDevices = new InputDevice[2];

        foreach (var device in devices)
        {
            if (device is Keyboard)
            {
                keyboardDevice = device;
            }
            else if (device is Gamepad gamepad)
            {
                if (gamepadDevices[0] == null)
                {
                    gamepadDevices[0] = gamepad;
                }
                else if (gamepadDevices[1] == null)
                {
                    gamepadDevices[1] = gamepad;
                }
            }
        }

        if (gamepadDevices[0] != null)
        {
            player1Input.SwitchCurrentControlScheme(defaultControllerScheme, gamepadDevices[0]);
        }
        else
        {
            player1Input.SwitchCurrentControlScheme(keyboardScheme, keyboardDevice);
        }

        if (gamepadDevices[1] != null)
        {
            player2Input.SwitchCurrentControlScheme(defaultControllerScheme, gamepadDevices[1]);
        }
        else
        {
            player2Input.SwitchCurrentControlScheme(keyboardScheme, keyboardDevice);
        }
    }
}

