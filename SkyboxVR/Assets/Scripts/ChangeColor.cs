using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{
    public Material[] mat;
    public bool changeAuto;
    public MeshRenderer mesh;
    public float timeLimit;
    int i = 0;
    private bool flipswitch;

    void Start()
    {
        if(changeAuto)
        {
            StartCoroutine(changeMat(timeLimit));
        }
    }

    private IEnumerator changeMat(float interval)
    {
        while(true)
        {
            yield return new WaitForSeconds(interval);
            Flip();
        }
    }

    public void Flip()
    {
        i++;
        if(i>=mat.Length)
            i = 0;
        mesh.material = mat[i];
    }
}
