using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnNiSecondExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Image image;
    public Sprite[] sprites;

    private string[] words = { "SPUGNA", "GNOCCHI", "LAVAGNA", "DISEGNO", "RAGNATELA", "LEGNA", "MONTAGNA", "STAGNO", "GNOMO", "MIGNOLO", "RAGNO", //0-10
                               "MACEDONIA", "GERANIO", "CERNIERA", "PANIERE", "MATRIMONIO", "GONIOMETRO", "PRIGIONIERO", "MINIERA", "GRANITA", "CARABINIERE", "MANI" };//11-21
    private string word;

    public InputField inputTxt;
    private string input;
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
            image.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            image.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            image.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            image.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            image.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            image.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            image.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            image.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            image.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            image.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            image.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            image.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            image.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            image.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            image.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            image.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            image.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            image.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            image.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            image.sprite = sprites[19];
        }
        else if (word == words[20])
        {
            image.sprite = sprites[20];
        }
        else if (word == words[21])
        {
            image.sprite = sprites[21];
        }
    }
    #endregion

    #region Read and check input answer
    public void ReadInput(string s)
    {
        input = s;
    }

    public void CheckInputAnswer()
    {
        if (input.Contains(word) || input.Contains(word.ToLower()))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingWordTxtImage();

            inputTxt.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputTxt.text = "";
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
        SceneManager.LoadScene(28);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
