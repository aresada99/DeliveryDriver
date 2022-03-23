using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;
    public float destroyDelay=1f;
    public Color32 hasPackageColor = new Color32(1, 1,1,1);
    public Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && hasPackage == false)
        {
            hasPackage = true;
            Debug.Log("Package picked up!");
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }
        if(collision.tag == "Customer" && hasPackage == true)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package successfuly delivered!");
        }
    }

}
