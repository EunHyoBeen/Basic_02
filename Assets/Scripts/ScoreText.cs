using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text Scoretext;
    public ScoreButton ScoreButton;

    private void Awake()
    {
        Scoretext = GetComponent<TMP_Text>();
        ScoreButton.Scorebutton.onClick.AddListener(RefreshUI);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RefreshUI()
    {
       Scoretext.text = ScoreButton.Score.ToString("N2");
    }
}
