using System.Collections;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private ChangeColor objectScript;
    public MeshRenderer cursor;
    public Material GazedAtMaterial, InactiveMaterial;

    public void Start()
    {
        objectScript = gameObject.GetComponent<ChangeColor>();
        SetMaterial(false);
    }

    public void OnPointerEnter()
    {
        SetMaterial(true);
    }

    public void OnPointerExit()
    {
        SetMaterial(false);
    }

    public void OnPointerClick()
    {
        objectScript.Flip();
    }

    private void SetMaterial(bool gazedAt)
    {
        if(InactiveMaterial != null && GazedAtMaterial != null)
        {
            cursor.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
