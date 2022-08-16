using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputMove : MonoBehaviour
{
    [SerializeField] private float movespeed;
    // Update is called once per frame
    void Update()
    {
        float movement = Time.deltaTime * movespeed;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + movement);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - movement);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector3(transform.localPosition.x - movement, transform.localPosition.y, transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector3(transform.localPosition.x + movement, transform.localPosition.y, transform.localPosition.z);
        }

    }
}
