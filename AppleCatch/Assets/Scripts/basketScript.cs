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
            if(Physics.Raycast(ray, out hit))
            {
                
            }
        }
    }
}
