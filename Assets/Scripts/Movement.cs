using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 Vec;
    public float speed =23;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()  
    {  
  
        Vec = transform.localPosition;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 8*speed;  
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 8*speed;  
        transform.localPosition = Vec;  
    } 
}
