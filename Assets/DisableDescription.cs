using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableDescription : MonoBehaviour
{
    public GameObject description;
    
    // Start is called before the first frame update
    void Start()
    {
        description.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
