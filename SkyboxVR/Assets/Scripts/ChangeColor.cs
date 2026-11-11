using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{
    public Material[] mat;
    public bool changeAuto;
    public MeshRenderer mesh;
    public float timeLimit;
    int i = 0;

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
            Swap();
        }
    }

    public void Swap()
    {
        i++;
        if(i>=mat.Length)
            i = 0;
        mesh.material = mat[i];
    }
}
