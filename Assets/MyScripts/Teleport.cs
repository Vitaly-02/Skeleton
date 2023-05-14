using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        var maxCoins = SceneManager.GetActiveScene().buildIndex == 0 ? 8 : 18;
        if (Player.GetComponent<Score>().CoinsScore == maxCoins) {
            Scene currentScene = SceneManager.GetActiveScene();
            var index = currentScene.buildIndex == 0 ? 1 : 0;
            
            //var oldScore = Player.GetComponent<Score>().CoinsScore;
            SceneManager.LoadScene(index);
            //Player = GameObject.Find("PlayerSkeleton");
            //Player.GetComponent<Score>().CoinsScore = 10;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerSkeleton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
