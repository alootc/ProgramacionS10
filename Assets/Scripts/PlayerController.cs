using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform transforms;
    private SpriteRenderer spriteRenderers;
    
    public float speed;
    public int directionx;
    public int directiony;


    void Awake()
    {
        spriteRenderers = GetComponent<SpriteRenderer>();   
        transforms = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transforms.position.x + speed * directionx * Time.deltaTime, transform.position.y + speed * directiony * Time.deltaTime);
        if (transforms.position.x > 8.0f)
        {
            directionx = -1;
            spriteRenderers.flipX = true;
        }
        if (transforms.position.x < -8.0f)
        {
            directionx = 1;
            spriteRenderers.flipX = false;
        }
        if (transform.position.y > 4.15f)
        {
            directiony = -1;
            spriteRenderers.flipY = true;
        }
        if (transform.position.y < -4.15f)
        {
            directiony = 1;
            spriteRenderers.flipY = false;
        }
    }
}
