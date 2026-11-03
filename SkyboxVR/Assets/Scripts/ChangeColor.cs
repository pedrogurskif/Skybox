using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material on, off;
    public MeshRenderer mesh;
    private float timer;
    private bool flipswitch;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.8f)
        {
            Flip();
        }
    }

    void Flip()
    {
        flipswitch = !flipswitch;
        timer = 0;
        if(flipswitch)
        {
            mesh.material = on;
        }
        else
        {
            mesh.material = off;
        }
    }
}
