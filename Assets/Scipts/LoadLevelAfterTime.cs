using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterTime : MonoBehaviour
{

    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
            
        }
    }

}
