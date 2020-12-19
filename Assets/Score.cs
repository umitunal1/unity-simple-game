using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text score;
    void Update()
    {        
        score.text = (player.position.z * 0.5).ToString("0");       

        if (player.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
