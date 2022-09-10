using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonController : MonoBehaviour
{
    public string jsonURL;
    // Start is called before the first frame update
    void Start()
    {
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
    }

  
}
