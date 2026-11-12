using UnityEngine;

public class Title : MonoBehaviour
{
 public Transition TransitionClass;
 public AudioSource mainMenuSource;
////void PressedPlay()
//{
//  TransitionClass.TransitionToScene("MainScene");
//}
public GameObject SettingsUI;

public void Start()
{
  mainMenuSource.Play();
}
    public void ExitButton()
    {
        Application.Quit();
    }

    public void SettingsVisible(bool yeah)
    {
      SettingsUI.gameObject.SetActive(!SettingsUI.gameObject.activeSelf);
      //Debug.Log("kai will give urena creampies");
    }
}
