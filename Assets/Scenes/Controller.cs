using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Controller: MonoBehaviour
{
    public List<PlayerInput> playerInputs = new List<PlayerInput>(); // Assign these in the Inspector

    private Dictionary<Gamepad, PlayerInput> assignedControllers = new Dictionary<Gamepad, PlayerInput>();

    private void OnEnable()
    {
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnDisable()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if (change == InputDeviceChange.Added && device is Gamepad gamepad)
        {
            AssignControllerToPlayer(gamepad);
        }
    }

    private void AssignControllerToPlayer(Gamepad gamepad)
    {
        if (!assignedControllers.ContainsKey(gamepad))
        {
            for (int i = 0; i < playerInputs.Count; i++)
            {
                if (!assignedControllers.ContainsValue(playerInputs[i]))
                {
                    assignedControllers.Add(gamepad, playerInputs[i]);
                    playerInputs[i].SwitchCurrentControlScheme(gamepad);
                    Debug.Log("Assigned " + gamepad.displayName + " to Player " + (i + 1));
                    break;
                }
            }
        }
    }
}
