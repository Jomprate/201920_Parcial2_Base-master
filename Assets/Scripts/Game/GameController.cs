﻿using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public delegate void OnTaggedChange(string newTagged);

    public event OnTaggedChange onTaggedChange;

    [SerializeField]
    private float playTime = 60F;

    [SerializeField]
    private int playerCount = 4;

    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private bool instantiateHumanPlayer = true;

  

    private Dictionary<string, int> taggedScore = new Dictionary<string, int>();

    public string GetWinner()
    {
        return string.Empty;
    }

    // Start is called before the first frame update
    private void Start()
    {
        onTaggedChange += UpdateTaggedScore;

        taggedScore.Clear();

        for (int i = 0; i < playerCount; i++)
        {
            string prefabPath = i == 0 && instantiateHumanPlayer ? "HumanPlayer" : "AIPlayer";

            GameObject playerInstance = Instantiate(Resources.Load<GameObject>(prefabPath));

            #region Create Displacement
            float x = Random.Range(-20f, 20f);
            float z = Random.Range(-20f, 20f);
            playerInstance.transform.position = new Vector3(x , 1, z);
            #endregion

            playerInstance.name = string.Format("Player{0}", i + 1);

            taggedScore.Add(playerInstance.name, 0);
        }



        Invoke("EndGame", playTime);
    }
    private void Update()
    {
        
    }

    private void EndGame()
    {
        onTaggedChange -= UpdateTaggedScore;
    }

    private void UpdateTaggedScore(string newTaggedPlayer)
    {
        taggedScore[newTaggedPlayer] += 1;
    }
}