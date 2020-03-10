using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{

    public GameObject myFirstPrefab;
    public GameObject mySecondPrefab;

    public Camera myCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Ray ray;
            RaycastHit hit;
            ray = myCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                GameObject myPrefab;
                if (Input.GetMouseButtonDown(0))
                {
                    myPrefab = myFirstPrefab;
                }
                else
                {
                    myPrefab = mySecondPrefab;
                }
                Instantiate(myPrefab, hit.point, Quaternion.identity);
            }
        }
    }
}
