using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiScoreItem : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text scoreText;
   
    public void Set(string numer, string name, string score)
    {
        numberText.text = numer;
        nameText.text = name;
        scoreText.text = score;
    }
}
