using UnityEngine;

public class TextSwitch : MonoBehaviour
{
    private bool textOn = true;
    private Vector3 startScale;

    void Start()
    {
        startScale = gameObject.transform.localScale;
    }

    public void SwitchText()
    {
        textOn = !textOn;
        if(textOn)
        {
            gameObject.transform.localScale = startScale;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
