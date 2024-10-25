using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    public ScoreButton ScoreButton;

    private void Awake()
    {
        Scoretext = GetComponent<TextMeshProUGUI>();
        ScoreButton.Scorebutton.onClick.AddListener(RefreshUI);
    }


    void RefreshUI()
    {
       Scoretext.text = ScoreButton.Score.ToString();
    }
}
