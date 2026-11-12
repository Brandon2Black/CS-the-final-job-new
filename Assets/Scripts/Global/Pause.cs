using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    void Pause()
    {
    if(isPaused)
    {
    pauseMenu.SetActive(false);
     Time.timeScale = 1f;
     isPaused = false;
    }
    else if (!isPaused)
    {
     pauseMenu.SetActive(true);
     Time.timeScale = 0f;
     isPaused = true;
    }
    
    }
}
