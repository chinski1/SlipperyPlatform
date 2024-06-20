using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wincondition : MonoBehaviour
{
    public string VictoryScene;
  private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player Entered");
        SceneManager.LoadScene(VictoryScene);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player Exited");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is here");
    }
}
