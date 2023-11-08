/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrowthController : MonoBehaviour
{
    public SnakeTailController snakeTailController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject, 0.02f);
            snakeTailController.AddTail();
        }
    }
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrowthController : MonoBehaviour
{
    public SnakeTailController snakeTailController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Food destroyed");
            snakeTailController.AddTail();
        }
    }
}

