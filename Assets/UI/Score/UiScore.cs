using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiScore : MonoBehaviour
{
    [SerializeField] private List<UiScoreItem> items = new List<UiScoreItem>();
    
    [SerializeField] private UiScoreItem scoreItemPrefab;
    [SerializeField] private Transform content;
    private int maxElements = 6;

    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField scoreInput;
    [SerializeField] private Button confirmButton;

    private int Players;

    private void Awake()
    {
        confirmButton.onClick.AddListener(OnConfirmClicked);
    }

    private void OnConfirmClicked()
    {
        string playerName = nameInput.text;
        string playerScore = scoreInput.text;
        Players += 1;
        AddPlayer($"{Players }", playerName, playerScore);
        nameInput.text = "";
        scoreInput.text = "";
        
    }
    
    private void Start()
    {
        for (Players = 0; Players < maxElements; Players++)
        {
            string randomScore = Random.Range(0, 1000).ToString();
            AddPlayer((Players +1).ToString(), "Player 1" + Players, randomScore);
            
        }
        Sort();
    }

    private void OnDestroy()
    {
        confirmButton.onClick.RemoveAllListeners();
        
    }
    private void Sort()
    {
        items[3].transform.SetSiblingIndex(0);
        
    }

    private void AddPlayer(string numer, string name, string score)
    {
        UiScoreItem item = Instantiate(scoreItemPrefab,content);
        item.Set(numer, name, score);
        items.Add(item);    
    }
}
