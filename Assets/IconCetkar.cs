using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconCetkar : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite playIcon;
    public Sprite pauseIcon;
    private bool isPlaying = false;

    Ray ray;
    RaycastHit hit;

    void ChangeSprite()
    {   
        if(isPlaying)
        {
            spriteRenderer.sprite = playIcon;
            isPlaying = false;    
        }
        else
        {
            spriteRenderer.sprite = pauseIcon;
            isPlaying = true;
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = playIcon;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "cetkar") 
                {
                    ChangeSprite();
                }
            }
        }
    }
}
