using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public PlayerCollision gameEndingCollision;

    // Update is called once per frame
    void Update()
    {
        if (gameEndingCollision.TimerOn && player.position.y >= 0.5)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else
        {
            gameEndingCollision.TimerOn = false;
        }
    }
}
