using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material on, off;
    public MeshRenderer mesh;
    private float timer;
    public float timeLimitDenise;
    private bool flipswitch;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeLimitDenise)
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
