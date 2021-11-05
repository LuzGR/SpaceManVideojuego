using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour{

    public Text coinsText;
    public Text maxScoreText;
    public Text scoreText;
    private PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update(){
        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            int coins = GameManager.sharedInstance.collectedObject ;
            float score = controller.GetTravelledDistance();
            float maxScore = PlayerPrefs.GetFloat("maxscore", 0);

            coinsText.text = coins.ToString();
            scoreText.text = "Score:" + score.ToString("f1");
            maxScoreText.text = "MaxScore: " + maxScore.ToString("f1");

        }
    }
}
