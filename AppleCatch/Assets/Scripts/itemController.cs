using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class itemController : MonoBehaviour 
{

    public float dropSpeed = -2f;
    int ratio = 2;
    private void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }  
    }
}

