
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartdelay = 0.5f;
    bool gameHasEnded = false;

       public GameObject CompleteLevelUI;

       public void Complete()
    {
        CompleteLevelUI.SetActive(true);
    }
    
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    public void Endgame()
    { 
        if(gameHasEnded==false){
            gameHasEnded= true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartdelay);
        }
        
    }
 
    
}
