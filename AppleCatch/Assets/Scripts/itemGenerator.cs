using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class itemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    float span = 1.0f;
    float delta = 0;
    /*public float dropSpeed = -1.3f;*/

    private void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject g = Instantiate(applePrefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            goto.transform.position = new Vector3(x, 4, z);
        }
        /*transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -1f)
        {
            Destroy(gameObject);
        }  */
    }
}

