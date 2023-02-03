using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
   public void ShowNextLevel()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
