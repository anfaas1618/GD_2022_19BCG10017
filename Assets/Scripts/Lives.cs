using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score.lives--;
        if (Score.lives==0)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
