using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class basketScript : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);

                transform.position = new Vector3(x, 0, z);
            }
        }
    }

   /* private void OnTriggerEnter(Collider other)
    {
        Debug.Log("잡았노!");
        if (other.gameObject.tag=="apple")
        {
            Debug.Log("사과");
            aud.PlayOneShot(appleSE);
        }
        else if (other.gameObject.tag=="bomb")
        {
            Debug.Log("폭");
            aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }*/
}
