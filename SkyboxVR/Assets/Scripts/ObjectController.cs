using System.Collections;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public ChangeColor tv;
    public CharacterControllerVR playerCode;
    private bool yetToInteract = true;

    public void OnPointerEnter()
    {
        Debug.Log("enter");
    }

    public void OnPointerExit()
    {
        Debug.Log("exit");
    }

    public void OnPointerClick()
    {
        Debug.Log("click");
        if(yetToInteract)
        {
            StartCoroutine(playerCode.floatTime()); // https://discussions.unity.com/t/115556/2
            yetToInteract = false;
        }
        tv.Swap();
    }

}
