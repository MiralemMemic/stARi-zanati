using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconBravadzija : MonoBehaviour
{

    public GameObject description;

    Ray ray;
    RaycastHit hit;

    void Awake()
    {
        description.SetActive(false);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "bravadzija")
                {
                    if(description.activeSelf) description.SetActive(false);
                    else description.SetActive(true);
                }
            }
        }
    }
}
