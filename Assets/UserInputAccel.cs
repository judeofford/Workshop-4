using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputAccel : MonoBehaviour
{
    Vector3 speeds = new Vector3(0f, 0f, 0f);
    // Update is called once per frame
    void Update()
    {
        float xmove = Time.deltaTime * speeds.x;
        float zmove = Time.deltaTime * speeds.z;
        transform.localPosition = new Vector3(transform.localPosition.x + xmove, transform.localPosition.y, transform.localPosition.z + zmove);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speeds.z = speeds.z + 0.1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speeds.z = speeds.z - 0.1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speeds.x = speeds.x - 0.1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speeds.x = speeds.x + 0.1;
        }

        
    }
}
