using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArticoliThirdExample : MonoBehaviour
{
    #region Variables
    #endregion

    public void Start()
    {
        
    }

    #region Buttons Return, Next, Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
