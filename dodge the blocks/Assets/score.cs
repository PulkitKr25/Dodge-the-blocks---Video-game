using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text=player.position.z.ToString("0");
    }
}
