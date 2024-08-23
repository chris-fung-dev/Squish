using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyFollowPlayerScript : MonoBehaviour
{
    public bool ShouldFollowPlayer1;
    public bool ShouldFollowPlayer2;

    public Vector3 offset;
    public Transform target1;
    public Transform target2;
    public float smoothspeed;
    public bool p1haskey;
    public bool p2haskey;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player1"))
        {
            ShouldFollowPlayer2 = false;
            ShouldFollowPlayer1 = true;
        }
        if(other.gameObject.CompareTag("Player2"))
        {
            ShouldFollowPlayer2 = true;
            ShouldFollowPlayer1 = false;
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (ShouldFollowPlayer1)
        {
            p1haskey = true;
            Vector3 desiredposition = target1.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
            transform.position = smoothPosition;
        }

        if (ShouldFollowPlayer2)
        {
            p2haskey = true;
            Vector3 desiredposition = target2.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
            transform.position = smoothPosition;
        }
    }
}
