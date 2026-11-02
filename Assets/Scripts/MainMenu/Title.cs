using UnityEngine;

public class Title : MonoBehaviour
{
 public Transition TransitionClass;
////void PressedPlay()
//{
//  TransitionClass.TransitionToScene("MainScene");
//}
public GameObject SettingsUI;
    public void ExitButton()
    {
        Application.Quit();
    }

    public void SettingsVisible(bool yeah)
    {
      SettingsUI.gameObject.SetActive(!SettingsUI.gameObject.activeSelf);
    }
}
