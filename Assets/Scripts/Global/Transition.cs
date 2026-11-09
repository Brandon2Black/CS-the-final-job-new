using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

   public AudioSource mainMenuSource;
   public void TransitionToScene(string sceneName)
   {
    SceneManager.LoadScene(sceneName);
   mainMenuSource.Stop();
   }
}
