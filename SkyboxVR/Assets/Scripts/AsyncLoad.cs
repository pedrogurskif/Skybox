using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AsyncLoad : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    IEnumerator LoadSceneCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("SampleScene");
        operation.allowSceneActivation = false;
        while(operation.progress < 0.9f) // https://docs.unity.com/en-us/engine/6000.5/script-reference/unityengine/asyncoperation/progress
        {
            yield return null;
        }
        yield return new WaitForSeconds(3f);
        operation.allowSceneActivation = true;
    }
}
