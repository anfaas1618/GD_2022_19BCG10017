using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text LivesText;
    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.score.ToString();
        LivesText.text = Score.lives.ToString();
    }
}
