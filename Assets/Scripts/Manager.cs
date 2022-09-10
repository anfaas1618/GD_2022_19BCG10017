using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Manager : MonoBehaviour
{enum Direction 
    {
        Left,
        Right,
        Front,
        Back
    }

    public GameObject myPrefab;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    public float ttl = 0;
    // Start is called before the first frame update
    [SerializeField]
     GameObject pulpit;

     [SerializeField] private GameObject manager;
    void Start()
    {
        
        timerIsRunning = true;
        manager = GameObject.FindWithTag("manager");
        timeRemaining = manager.GetComponent<JsonController>().randomTime;
        ttl = manager.GetComponent<JsonController>().destroyTime;
     PlaneInstantiate planeInstantiate=   manager.GetComponent<PlaneInstantiate>();
     myPrefab = planeInstantiate.myPrefab;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                int direction = Random.Range(0, 3);
                
                switch (direction)
                {
                    case (int)Direction.Back : Instantiate(myPrefab, new Vector3(gameObject.transform.position.x+90, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
                                                break;
                    case (int)Direction.Front : Instantiate(myPrefab, new Vector3(gameObject.transform.position.x-90, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
                        break;
                    case (int)Direction.Left : Instantiate(myPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z+90), Quaternion.identity);
                        break;
                    case (int)Direction.Right : Instantiate(myPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z-90), Quaternion.identity);
                        break;
                }
               Destroy(gameObject,ttl);
                timerIsRunning = false;
            }
        }
    }
}