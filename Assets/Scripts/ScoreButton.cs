using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button Scorebutton;

    public int Score = 0;


    private void Awake()
    {
        Scorebutton = GetComponent<Button>();
        Scorebutton.onClick.AddListener(PointUp);
    }

    public void PointUp()
    {
        Score++;
        
    }
}
