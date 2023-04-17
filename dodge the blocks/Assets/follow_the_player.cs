
using UnityEngine;

public class follow_the_player : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset ;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Offset;
    }
}
