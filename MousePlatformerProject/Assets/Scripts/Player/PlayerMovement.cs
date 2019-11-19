using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement actions

    public void MoveLeft(float speed)
    {
        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void MoveRight(float speed)
    {
        gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void Jump(float jumpSpeed)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed);
    }
}
