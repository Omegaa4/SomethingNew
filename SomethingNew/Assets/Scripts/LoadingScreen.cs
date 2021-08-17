using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public LevelLoader levelLoader;

    public Animator transition;

    public float transitionTime = 1f;

    public void LoadStartMenu()
    {
        levelLoader.LoadNextLevel();
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(LevelIndex);
    }


}
