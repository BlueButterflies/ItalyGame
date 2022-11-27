using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlGliLiLliFirstExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text wordTxt;

    private string[] words = {"SIGLA","INGLESE","GLADIATORE","GLOBO","GLASSA","GLORIA",//0-5
                              "SVEGLIA","MAGLIONE","CONIGLIO","PAGLIACCIO","MANIGLIA","AGLIO","CONCHIGLIA","BIGLIE","VENTAGLIO","FOGLIA","MEDAGLIA",//6-16
                              "MOBILIERE","ITALIA","CILIEGIA","SALIERA","OLIERA","CAVALIERE","BILIARDO","CANDELIERE","LIEVITO","OLIO",//17-26
                              "ALLIEVO","ALLIETARE","GIOIELLIERE","STALLIERE","SOLLIEVO"};//27-31
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxt();
    }

    #region Random words and assing wordTxt
    private void RandomWordsAndAssingTxt()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            wordTxt.text = "SI__A";
        }
        else if (word == words[1])
        {
            wordTxt.text = "IN__ESE";
        }
        else if (word == words[2])
        {
            wordTxt.text = "__ADIATORE";
        }
        else if (word == words[3])
        {
            wordTxt.text = "__OBO";
        }
        else if (word == words[4])
        {
            wordTxt.text = "__ASSA";
        }
        else if (word == words[5])
        {
            wordTxt.text = "__ORIA";
        }
        else if (word == words[6])
        {
            wordTxt.text = "SVE___A";
        }
        else if (word == words[7])
        {
            wordTxt.text = "MA___ONE";
        }
        else if (word == words[8])
        {
            wordTxt.text = "CONI___O";
        }
        else if (word == words[9])
        {
            wordTxt.text = "PA___ACCIO";
        }
        else if (word == words[10])
        {
            wordTxt.text = "MANI___A";
        }
        else if (word == words[11])
        {
            wordTxt.text = "A___O";
        }
        else if (word == words[12])
        {
            wordTxt.text = "CONCHI___A";
        }
        else if (word == words[13])
        {
            wordTxt.text = "BI___E";
        }
        else if (word == words[14])
        {
            wordTxt.text = "VENTA___O";
        }
        else if (word == words[15])
        {
            wordTxt.text = "FO___A";
        }
        else if (word == words[16])
        {
            wordTxt.text = "MEDA___A";
        }
        else if (word == words[17])
        {
            wordTxt.text = "MOBI__ERE";
        }
        else if (word == words[18])
        {
            wordTxt.text = "ITA__A";
        }
        else if (word == words[19])
        {
            wordTxt.text = "CI__EGIA";
        }
        else if (word == words[20])
        {
            wordTxt.text = "SA__ERA";
        }
        else if (word == words[21])
        {
            wordTxt.text = "O__ERA";
        }
        else if (word == words[22])
        {
            wordTxt.text = "CAVA__ERE";
        }
        else if (word == words[23])
        {
            wordTxt.text = "BI__ARDO";
        }
        else if (word == words[24])
        {
            wordTxt.text = "CANDE__ERE";
        }
        else if (word == words[25])
        {
            wordTxt.text = "__EVITO";
        }
        else if (word == words[26])
        {
            wordTxt.text = "O__O";
        }
        else if (word == words[27])
        {
            wordTxt.text = "A___EVO";
        }
        else if (word == words[28])
        {
            wordTxt.text = "A___ETARE";
        }
        else if (word == words[29])
        {
            wordTxt.text = "GIOIE___ERE";
        }
        else if (word == words[30])
        {
            wordTxt.text = "STA___ERE";
        }
        else if (word == words[31])
        {
            wordTxt.text = "SO___EVO";
        }
    }
    #endregion

    #region Buttons answers
    public void GlBtn()
    {
        if (word.Contains("GL"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void GliBtn()
    {
        if (word.Contains("GLI"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void LiBtn()
    {
        if (word.Contains("LI"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void LliBtn()
    {
        if (word.Contains("LLI"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
    #endregion

    #region Buttons Return, Next and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(21);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
