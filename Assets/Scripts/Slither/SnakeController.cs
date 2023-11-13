using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private float rotationSpeed = 200f;
    [SerializeField]
    private float velX = 0f;

    private void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        // movement
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        //rotate
        transform.Rotate(Vector3.forward * -velX * rotationSpeed * Time.fixedDeltaTime);

    }

}
