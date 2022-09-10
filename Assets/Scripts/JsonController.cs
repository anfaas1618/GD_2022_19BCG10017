using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class JsonController : MonoBehaviour
{
    public string jsonURL;

    public GameObject player;
    public GameObject mPulpit;

    private Movement movement;

    public float maxTime = 0;

    public float minTime = 0;

    public float destroyTime = 0;
    public float randomTime =0;
    // Start is called before the first frame update
    void Start()
    
    {
        
         movement = player.GetComponent<Movement>();
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        WWW _www = new WWW(jsonURL);
        yield return _www;
        if (_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Oops something went wrong");
        }

    }
    private void processJsonData(string _url)
    {
        JsonTest data = JsonUtility.FromJson<JsonTest>(_url);
        Debug.Log(data.pulpit_data.pulpit_spawn_time);
        movement.speed = data.player_data.speed;
        maxTime = data.pulpit_data.max_pulpit_destroy_time;
        minTime = data.pulpit_data.min_pulpit_destroy_time;
        destroyTime = data.pulpit_data.pulpit_spawn_time;
        randomTime = Random.Range(minTime, maxTime);
        mPulpit.SetActive(true);
        player.SetActive(true);
    }

  
}
