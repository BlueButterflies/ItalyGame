using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GiaGioGiuCiaCioCiuFirstExample : MonoBehaviour
{
    #region Variable
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text wordTxt;
    public Text btnGiaCia;
    public Text btnGioCio;
    public Text btnGiuCiu;

    public Image image;
    public Sprite[] sprites;

    private string[] words = { "CILIEGIA", "PARMEGGIANO", "FAGIANO","GIAGUARO","SCARAFAGGIA","PIGIAMA","VALIGIA",//0-6
                               "PRIGIONE","GIOIELLI","SEGUGIO","GIOCATTOLI","OROLOGIO","GIOSTRA","FAGIOLI",//7-13
                               "GIURIA","GIULLARE","GIUDICE",//14-16
                               "CIABATTE","CIAMBELLA","FRECIA","ROCCIA","CAMICIA","BRACCIALETTO",//17-22
                               "CIOCCOLATO","BRACCIO","CIOTOLA","RICCIO","CIONDOLO",//23-27
                               "CIUCCIO","CIUFFO","ASCIUGAMANO","DOLCIUMI"};//28-31
    private string word;
    #endregion

    public void Start()
    {
        audioSource= GetComponent<AudioSource>();

        RandomWordsAndAssingTxtImage();
    }

    #region Random words and assing wordTxt , image and buttons texts
    private void RandomWordsAndAssingTxtImage()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            wordTxt.text = "CILIE___";
            image.sprite = sprites[0];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[1])
        {
            wordTxt.text = "PARMEG___NO";
            image.sprite = sprites[1];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[2])
        {
            wordTxt.text = "FA___NO";
            image.sprite = sprites[2];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[3])
        {
            wordTxt.text = "___GUARO";
            image.sprite = sprites[3];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[4])
        {
            wordTxt.text = "SCARAFAG___";
            image.sprite = sprites[4];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[5])
        {
            wordTxt.text = "PI___MA";
            image.sprite = sprites[5];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[6])
        {
            wordTxt.text = "VALI___";
            image.sprite = sprites[6];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[7])
        {
            wordTxt.text = "PRI___NE";
            image.sprite = sprites[7];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[8])
        {
            wordTxt.text = "___IELLI";
            image.sprite = sprites[8];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[9])
        {
            wordTxt.text = "SEGU___";
            image.sprite = sprites[9];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[10])
        {
            wordTxt.text = "___CATTOLI";
            image.sprite = sprites[10];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[11])
        {
            wordTxt.text = "OROLO___";
            image.sprite = sprites[11];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[12])
        {
            wordTxt.text = "___STRA";
            image.sprite = sprites[12];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[13])
        {
            wordTxt.text = "FAG___LI";
            image.sprite = sprites[13];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[14])
        {
            wordTxt.text = "___RIA";
            image.sprite = sprites[14];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[15])
        {
            wordTxt.text = "___LLARE";
            image.sprite = sprites[15];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[16])
        {
            wordTxt.text = "___DICE";
            image.sprite = sprites[16];

            btnGiaCia.text = "GIA";
            btnGioCio.text = "GIO";
            btnGiuCiu.text = "GIU";
        }
        else if (word == words[17])
        {
            wordTxt.text = "___BATTE";
            image.sprite = sprites[17];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[18])
        {
            wordTxt.text = "___MBELLA";
            image.sprite = sprites[18];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[19])
        {
            wordTxt.text = "FRE___";
            image.sprite = sprites[19];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[20])
        {
            wordTxt.text = "ROC___";
            image.sprite = sprites[20];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[21])
        {
            wordTxt.text = "CAMI___";
            image.sprite = sprites[21];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[22])
        {
            wordTxt.text = "BRAC___LETTO";
            image.sprite = sprites[22];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[23])
        {
            wordTxt.text = "___CCOLATO";
            image.sprite = sprites[23];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[24])
        {
            wordTxt.text = "BRAC___";
            image.sprite = sprites[24];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[25])
        {
            wordTxt.text = "___TOLA";
            image.sprite = sprites[25];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[26])
        {
            wordTxt.text = "RIC___";
            image.sprite = sprites[26];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[27])
        {
            wordTxt.text = "___NDOLO";
            image.sprite = sprites[27];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[28])
        {
            wordTxt.text = "___CCIO";
            image.sprite = sprites[28];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[29])
        {
            wordTxt.text = "___FFO";
            image.sprite = sprites[29];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[30])
        {
            wordTxt.text = "AS___GAMANO";
            image.sprite = sprites[30];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
        else if (word == words[31])
        {
            wordTxt.text = "DOL___MI";
            image.sprite = sprites[31];

            btnGiaCia.text = "CIA";
            btnGioCio.text = "CIO";
            btnGiuCiu.text = "CIU";
        }
    }
    #endregion

    #region Buttons answer
    public void GiaCiaBtn()
    {
        if (word.Contains("GIA") || word.Contains("CIA"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void GioCioBtn()
    {
        if (word.Contains("GIO") || word.Contains("CIO"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void GiuCiuBtn()
    {
        if (word.Contains("GIU") || word.Contains("CIU"))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
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
        SceneManager.LoadScene(18);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
