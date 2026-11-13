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
        if(timer>1)
        {
            timer = 0;
            count += varb;
            texto.text = count.ToString();
        }
        if(Time.timeScale == 100 && corout == null)
        {
            corout = StartCoroutine(changeCountFreq());
        }
    }

    private IEnumerator changeCountFreq()
    {
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 3f;
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 10f;
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 1231f;
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 76538f;
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 456874f;
        yield return new WaitForSeconds(1*Time.deltaTime);
        varb = 1f;
    }
}
