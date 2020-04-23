using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -20f; // a
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject); // b


            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();                                                    // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed(); // c
        }
    }

  
}
