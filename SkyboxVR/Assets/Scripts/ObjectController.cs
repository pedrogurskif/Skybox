using System.Collections;
using UnityEngine;
using FMODUnity;

public class ObjectController : MonoBehaviour
{
    public ChangeColor tv;
    public CharacterControllerVR playerCode;
    public StudioEventEmitter pointerEnterSound, pointerExitSound;
    private bool yetToInteract = true;

    public void OnPointerEnter()
    {
        Debug.Log("enter");
        pointerEnterSound.Play();
    }

    public void OnPointerExit()
    {
        Debug.Log("exit");
        pointerExitSound.Play();
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
