using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleKey : MonoBehaviour
{
    public bool ShouldFollowPlayer1;
    public bool ShouldFollowPlayer2;

    public Vector3 offset;
    public Transform target1;
    public Transform target2;
    public float smoothspeed;
    public bool p1PurpleKey;
    public bool p2PurpleKey;
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
            p1PurpleKey= true;
            Vector3 desiredposition = target1.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
            transform.position = smoothPosition;
        }

        if (ShouldFollowPlayer2)
        {
            p2PurpleKey= true;
            Vector3 desiredposition = target2.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
            transform.position = smoothPosition;
        }
    }
}
