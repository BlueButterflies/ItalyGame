using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnNiFirstExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Image image;
    public Sprite[] sprites;

    public Text wordTxt;

    private string[] words = { "SPUGNA", "GNOCCHI", "LAVAGNA", "DISEGNO", "RAGNATELA", "LEGNA", "MONTAGNA", "STAGNO", "GNOMO", "MIGNOLO", "RAGNO", //0-10
                               "MACEDONIA", "GERANIO", "CERNIERA", "PANIERE", "MATRIMONIO", "GONIOMETRO", "PRIGIONIERO", "MINIERA", "GRANITA", "CARABINIERE", "MANI" };//11-21
    private string word; 
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingWordTxtImage();
    }

    #region Random words and assing text word and image
    private void RandomWordsAndAssingWordTxtImage()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            wordTxt.text = "SPU__A";
            image.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            wordTxt.text = "__OCCHI";
            image.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            wordTxt.text = "LAVA__A";
            image.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            wordTxt.text = "DISE__O";
            image.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            wordTxt.text = "RA__ATELA";
            image.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            wordTxt.text = "LE__A";
            image.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            wordTxt.text = "MONTA__A";
            image.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            wordTxt.text = "STA__O";
            image.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            wordTxt.text = "__OMO";
            image.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            wordTxt.text = "MI__OLO";
            image.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            wordTxt.text = "RA__O";
            image.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            wordTxt.text = "MACEDO__A";
            image.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            wordTxt.text = "GERA__O";
            image.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            wordTxt.text = "CER__ERA";
            image.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            wordTxt.text = "PA__ERE";
            image.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            wordTxt.text = "MATRIMO__O";
            image.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            wordTxt.text = "GO__OMETRO";
            image.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            wordTxt.text = "PRIGIO__ERO";
            image.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            wordTxt.text = "MI__ERA";
            image.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            wordTxt.text = "GRA__TA";
            image.sprite = sprites[19];
        }
        else if (word == words[20])
        {
            wordTxt.text = "CARABI__ERE";
            image.sprite = sprites[20];
        }
        else if (word == words[21])
        {
            wordTxt.text = "MA__";
            image.sprite = sprites[21];
        }
    }
    #endregion

    #region Answers buttons GN anD NI
    public void GnBtn()
    {
        if (word.Contains("GN"))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingWordTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void NiBtn()
    {
        if (word.Contains("NI"))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingWordTxtImage();
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
        SceneManager.LoadScene(27);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
