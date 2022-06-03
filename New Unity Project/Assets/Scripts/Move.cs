using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        Destroy(gameObject, 3);
    }

    private void FixedUpdate()
    {
        transform.position += speed * Vector3.left * Time.deltaTime;
    }

}
