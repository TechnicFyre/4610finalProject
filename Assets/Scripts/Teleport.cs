using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;
        if ( pos.x > 2 ) pos.x = -2;
        if ( pos.x < -2 ) pos.x = 2;
        if ( pos.y > 2 ) pos.y = -2;
        if ( pos.y < -2 ) pos.y = 2;
        if ( pos.z > 2 ) pos.z = -2;
        if ( pos.z < -2 ) pos.z = 2;
        gameObject.transform.position = pos;
    }
}
