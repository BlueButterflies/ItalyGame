using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    #region Game Controller
    public void MissingVowelsBtn()
    {
        SceneManager.LoadScene(2);
    }

    public void CaCoCuCeCiBtn()
    {
        SceneManager.LoadScene(5);
    }

    public void QuOrCuBtn()
    {
        SceneManager.LoadScene(8);
    }

    public void GnaGneGniGnoGnu()
    {
        SceneManager.LoadScene(11);
    }

    public void SceSciBtn()
    {
        SceneManager.LoadScene(14);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Menu Controller
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
    #endregion
}
