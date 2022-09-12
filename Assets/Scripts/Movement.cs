using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{int mask = 1 << 10;
    Vector3 _vec;
    [SerializeField]
    float groundDistance=10f;
    private bool isCharacterGrounded;
    public float speed = 23;
    public TMP_Text ScoreTextGover;
    public GameObject canvas;
    public LayerMask GroundLayer;
    // Start is called before the first frame update
    private bool HandleIsGrounded()
    {
        
        return Physics.CheckSphere(transform.position, groundDistance, GroundLayer);
    } 

    // Update is called once per frame
    void Update()
    {



        if (HandleIsGrounded())
        {
            _vec = transform.localPosition;
            _vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 8 * speed;
            _vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 8 * speed;
            transform.localPosition = _vec;
        }
        if (transform.position.y < -10)
        {    
            canvas.SetActive(true);
            ScoreTextGover.text = Score.score.ToString();
            Destroy(gameObject,1f);
           
        }
    } 
}
