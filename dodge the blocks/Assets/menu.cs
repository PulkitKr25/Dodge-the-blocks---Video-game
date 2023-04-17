using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
   public void StartGame()
   {
        Debug.Log("Game has Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   } 
    
}
