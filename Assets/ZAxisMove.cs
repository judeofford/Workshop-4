using UnityEngine;
    
public class ZAxisMove : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private float movespeed;

    private void Update()
    {
        var z = Mathf.PingPong(Time.time*movespeed, distance);
        var pos = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
        transform.localPosition = pos;  
    }
}

