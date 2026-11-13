using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{
    public float count = 1;
    public TextMeshPro texto;
    void Start()
    {
        StartCoroutine(changeTime());
        Time.timeScale = 1;
    }

    private IEnumerator changeTime()
    {
        yield return new WaitForSeconds(10*Time.timeScale);
        Time.timeScale = 2;
        yield return new WaitForSeconds(7*Time.timeScale);
        Time.timeScale = 3;
        yield return new WaitForSeconds(7*Time.timeScale);
        Time.timeScale = 4;
        yield return new WaitForSeconds(6*Time.timeScale);
        Time.timeScale = 6;
        yield return new WaitForSeconds(5*Time.timeScale);
        Time.timeScale = 7;
        yield return new WaitForSeconds(5*Time.timeScale);
        Time.timeScale = 8;

    }
}
