using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform pt;
    
    // Start is called before the first frame update
    void Start()
    {
        pt = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = pt.position.x;
        temp.y = pt.position.y;
        transform.position = temp;
    }
}
