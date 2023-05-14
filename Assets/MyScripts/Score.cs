using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int CoinsScore;
    private GUIStyle scoreFont;

    private void OnGUI()
    {
        GUI.Label(new Rect(15, 15, 1000, 1000), "<b>Coins: " + CoinsScore + "</b>", scoreFont);
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreFont =  new GUIStyle();
        scoreFont.fontSize = 64;
        scoreFont.richText = true;
        scoreFont.stretchHeight = true;
        scoreFont.stretchWidth = true;
        scoreFont.alignment = TextAnchor.UpperLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
