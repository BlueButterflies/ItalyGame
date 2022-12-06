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

    public void SceSciScheSchiBtn()
    {
        SceneManager.LoadScene(14);
    }

    public void GiaGioGiuCiaCioCiuBtn()
    {
        SceneManager.LoadScene(17);
    }

    public void GlGliLiLliBtn()
    {
        SceneManager.LoadScene(20);
    }

    public void DoppieOSingoleBtn()
    {
        SceneManager.LoadScene(23);
    }

    public void GnNiBtn()
    {
        SceneManager.LoadScene(26);
    }

    public void ArticoliBtn()
    {
        SceneManager.LoadScene(29);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Menu Start Controller
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
