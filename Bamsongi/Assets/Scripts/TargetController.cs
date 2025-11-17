using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class TargetController : MonoBehaviour
{
    TargetGenerator gt;

    void Start()
    {
        gt = GameObject.FindObjectOfType.GetComponent<TargetGenerator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bamsongi")
        {
            gt.Generate();
            Destroy(gameObject);
        }
    }
}

}
