using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadyController : MonoBehaviour
{
    public void OnReadyButtonClicked()
    {
        SceneManager.LoadScene("Stage1");
    }
}
