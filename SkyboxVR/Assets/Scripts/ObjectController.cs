using System.Collections;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public ChangeColor tv;
    public TextSwitch txt;


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
        txt.SwitchText();
        tv.Swap();
    }

}
