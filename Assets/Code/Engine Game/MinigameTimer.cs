using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MinigameTimer : MonoBehaviour
{
    public float maxTime;
    public TextMeshProUGUI TMP;

    private void Awake()
    {
        TMP.text = maxTime.ToString();
        StartCoroutine(Timer());
    }

    public IEnumerator Timer()
    {
        while (maxTime > 0f)
        {
            yield return new WaitForSeconds(1f);
            maxTime -= 1f;
            TMP.text = maxTime.ToString();
        }
        EventManager.InvokeOnMinigameEnd();
        StopAllCoroutines();
        SceneManager.LoadScene("Garage_mainmenu");
    }
}
