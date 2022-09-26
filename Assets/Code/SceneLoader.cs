using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ToPark()
    {
        SceneManager.LoadScene("Image_scroll");
    }
    public void ToCity()
    {
        SceneManager.LoadScene("main_game");
    }
    public void ToEndless()
    {
        SceneManager.LoadScene("Endless_style_select");
    }
    public void ToMain()
    {
        SceneManager.LoadScene("Garage_mainmenu");
    }

    public void ToTire()
    {
        SceneManager.LoadScene("tire_minigame");
    }

    public void ToEngine()
    {
        SceneManager.LoadScene("engine_minigame");
    }

    public void ToBody()
    {
        SceneManager.LoadScene("body_minigame");
    }

    public void ToMinigame()
    {
        SceneManager.LoadScene("Minigame_select");
    }
}
