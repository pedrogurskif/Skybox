using UnityEngine;
using System.Collections;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public float count = 1;
    private float timer = 0.2f;
    public TextMeshPro texto;
    private float varb = 1;
    private Coroutine corout;

    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>0.5f*Time.timeScale)
        {
            timer = 0;
            count += varb*Time.timeScale;
            texto.text = count.ToString();
        }
        if(Time.timeScale == 100 && corout == null)
        {
            corout = StartCoroutine(changeCountFreq());
        }
    }

    private IEnumerator changeCountFreq()
    {
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 3f;
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 10f;
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 1231f;
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 76538f;
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 456874f;
        yield return new WaitForSeconds(1*Time.timeScale);
        varb = 1f;
    }
}
