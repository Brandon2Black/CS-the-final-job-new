using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
   public void TransitionToScene(string sceneName)
   {
    SceneManager.LoadScene(sceneName);
   }
}
