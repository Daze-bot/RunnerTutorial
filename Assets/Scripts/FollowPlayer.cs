using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform player;
    public float offsetZ = -5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, transform.position.y, player.position.z + offsetZ);
    }
}
