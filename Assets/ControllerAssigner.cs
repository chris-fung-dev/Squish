using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerAssigner : MonoBehaviour
{
    public PlayerInput playerInput;
    public int controllerIndexToAssign; // Index of the controller you want to assign (e.g., 0 for the first controller)

    void Start()
    {
        if (playerInput == null)
        {
            Debug.LogError("PlayerInput reference not set!");
            return;
        }

        if (controllerIndexToAssign >= Gamepad.all.Count)
        {
            Debug.LogError("Controller index out of range!");
            return;
        }

        Gamepad assignedController = Gamepad.all[controllerIndexToAssign];
        if (assignedController == null)
        {
            Debug.LogError("Controller not found!");
            return;
        }

        AssignController(assignedController);
    }

    // Assign the controller to the PlayerInput component
    void AssignController(Gamepad controller)
    {
        playerInput.SwitchCurrentControlScheme(controller);
    }
}