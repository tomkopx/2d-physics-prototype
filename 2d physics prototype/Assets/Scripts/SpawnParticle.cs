using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    int test;
    public GameObject pixel;
    public GameObject water;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("1"))
        {
            test = 0;
        }
        if (Input.GetKey("2"))
        {
            test = 1;
        }


        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point);
            }

            if(test == 0)
            {
                GameObject obj = Instantiate(pixel, hit.point, Quaternion.identity) as GameObject;
            }
            else if(test == 1)
            {
                GameObject obj = Instantiate(water, hit.point, Quaternion.identity) as GameObject;
            }
           
        }
    }


}
