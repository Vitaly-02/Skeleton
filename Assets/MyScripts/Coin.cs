using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerSkeleton");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.5f);
    }
    
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Player.GetComponent<Score>().CoinsScore += 1;
    }

    public bool IsCoinsCollected()
    {
        return (Player.GetComponent<Score>().CoinsScore == 2);
    }
}
