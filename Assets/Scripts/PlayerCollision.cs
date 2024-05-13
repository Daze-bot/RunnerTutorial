using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public bool TimerOn;

    private void Start()
    {
        TimerOn = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            TimerOn = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
