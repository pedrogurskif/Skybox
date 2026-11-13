using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{
    public float[] intervals;
    public float[] times;
    private int i = 0;
    void Start()
    {
        StartCoroutine(changeTime());
        Time.timeScale = 1;
    }

    private IEnumerator changeTime()
    {
        while(i<times.Length)
        {
            yield return new WaitForSeconds(intervals[i]*Time.timeScale);
            Time.timeScale = times[i];
            i++;
        }
        yield return new WaitForSeconds(intervals[i]*Time.timeScale); //1:15
        SceneManager.LoadScene("SampleScene");
        
    }
}
