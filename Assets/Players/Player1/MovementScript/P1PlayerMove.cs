

using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class P1PlayerMove : MonoBehaviour
{
     public Rigidbody2D rb;
    public Animator anim;
    public Groundcheck check;
    private float horizontalInput;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Animationtrigger trigger;
    public AudioSource LandedSound;

    public PlayerInput playerInput;

    void OnEnable()
    {
        // Get the PlayerInput component attached to this GameObject
        playerInput = GetComponent<PlayerInput>();

        // Enable input for Player 2
        if (playerInput != null)
        {
            playerInput.ActivateInput();
        }
    }

    void OnDisable()
    {
        // Disable input for Player 2
        if (playerInput != null)
        {
            playerInput.DeactivateInput();
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>().x;
    }
    private void Move(Vector2 direction)
    {
        horizontalInput = direction.x;
    }

    private void FixedUpdate()
    {
        // Move the player horizontally only while jumping
        if (!check.grounded)
        {
            Vector3 movement = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, 0);
            rb.velocity = movement;
        }

        // Jumping
        if (check.grounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            LandedSound.Play();
        }

        if (rb.velocity.y > 0)
        {
            anim.SetBool("JumpP1", true);
            anim.SetBool("JumpP2", false);
            anim.SetBool("JumpP3", false);
        }
        if (rb.velocity.y < 0)
        {
            anim.SetBool("JumpP1", false);
            anim.SetBool("JumpP2", true);
            anim.SetBool("JumpP3", false);
        }

        if (trigger.SquishCheck)
        {
            anim.SetBool("JumpP1", false);
            anim.SetBool("JumpP2", false);
            anim.SetBool("JumpP3", true);
        }
        
    }

}

