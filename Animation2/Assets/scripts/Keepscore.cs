using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Keepscore : MonoBehaviour
{
    private TMP_Text scorefield;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scorefield = GetComponent<TMP_Text>();
        score = 0;
        scorefield.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int add)
    {
        score += add;
        scorefield.text = "" + score;
    }
}
