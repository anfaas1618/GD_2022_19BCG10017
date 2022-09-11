using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{int mask = 1 << 10;
    Vector3 _vec;
    public float speed =23;
    public LayerMask layers;
    public float rayDistance;
    private bool grounded;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        
        grounded = Physics.Raycast(ray, out hit, rayDistance, layers);
        
            _vec = transform.localPosition;
            _vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 8 * speed;
            _vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 8 * speed;
            transform.localPosition = _vec;

        

        if (transform.position.y < -10)
        {    
            canvas.SetActive(true);
            Destroy(gameObject,1f);
           
        }
    } 
}
