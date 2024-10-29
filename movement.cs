using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    public float speed = 5.0f;
    private float horizontalinput;
    private float forwardinput;
    
    // Update is called once per frame
    void Update()
    {
        horizontalinput = input.getaxis("Horizontal");
        forwardinput = input.getaxis("Vertical");

       transform.translate(vector3.forward * Time.deltaTime * speed * forwardinput);
      
       transform.rote(vector3.down * Time.deltaTime * speed * horizontalinput);
  

  
    }
}
