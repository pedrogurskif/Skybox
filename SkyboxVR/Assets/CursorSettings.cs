using UnityEngine;
using UnityEngine.UI;

public class CursorSettings : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
