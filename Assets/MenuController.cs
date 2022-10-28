using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void MissingVowelsBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void CaCoCuCeCiBtn()
    {
        SceneManager.LoadScene(2);
    }
}
