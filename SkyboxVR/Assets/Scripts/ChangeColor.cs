using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{
    public Material[] mat;
    public Material off;
    public bool changeAuto;
    public MeshRenderer mesh;
    public float timeLimit;
    public float glitchFreq, glitchDuration;
    int i = 0;
    public int glitchIndex;
    private bool flipswitch;
    private bool power;

    void Start()
    {
        power = true;
        Startup();
    }

    private IEnumerator changeMat(float interval)
    {
        while(true)
        {
            yield return new WaitForSeconds(interval);
            Flip();
        }
    }

    private IEnumerator glitchMat(float freq, float glitchDur, int gidx)
    {
        while(true)
        {
            mesh.material = mat[0];
            yield return new WaitForSeconds(freq);
            mesh.material = mat[gidx];
            yield return new WaitForSeconds(glitchDur);
        }
    }

    public void Flip()
    {
        i++;
        if(i>=mat.Length)
            i = 0;
        mesh.material = mat[i];
    }

    public void TogglePower()
    {
        power = !power;
        if(power)
        {
            Startup();
        }
        else
        {
            StopAllCoroutines();
            mesh.material = off;
        }
    }

    public void Startup()
    {
        if(changeAuto)
        {
            StartCoroutine(changeMat(timeLimit));
        }

        if(glitchIndex != 0)
        {
            StartCoroutine(glitchMat(glitchFreq, glitchDuration, glitchIndex));
        }
    }
}
