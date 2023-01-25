using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArticoliFirstExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Sprite[] spritesFirst;
    public Sprite[] spritesSecond;

    public Image firstImage;
    public Image secondImage;

    public InputField firstInput;
    public InputField secondInput;
    private string inputFirst;
    private string inputSecond;

    private string[] words = { 
                               "cane", "agnello", "squalo", "ragno", "scimia", "cavallo", "mosca", "cigno", "ciliegia", "ascia", 
                               "zaino", "serpente", "pesce", "gnomo", "pesca", "maschera" 
                              };
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RandomWords();
    }

    #region Random words and assing images 
    private void RandomWords()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            firstImage.sprite = spritesFirst[0];
            secondImage.sprite = spritesSecond[0];
        }
        else if (word == words[1])
        {
            firstImage.sprite = spritesFirst[1];
            secondImage.sprite = spritesSecond[1];
        }
        else if (word == words[2])
        {
            firstImage.sprite = spritesFirst[2];
            secondImage.sprite = spritesSecond[2];
        }
        else if (word == words[3])
        {
            firstImage.sprite = spritesFirst[3];
            secondImage.sprite = spritesSecond[3];
        }
        else if (word == words[4])
        {
            firstImage.sprite = spritesFirst[4];
            secondImage.sprite = spritesSecond[4];
        }
        else if (word == words[5])
        {
            firstImage.sprite = spritesFirst[5];
            secondImage.sprite = spritesSecond[5];
        }
        else if (word == words[6])
        {
            firstImage.sprite = spritesFirst[6];
            secondImage.sprite = spritesSecond[6];
        }
        else if (word == words[7])
        {
            firstImage.sprite = spritesFirst[7];
            secondImage.sprite = spritesSecond[7];
        }
        else if (word == words[8])
        {
            firstImage.sprite = spritesFirst[8];
            secondImage.sprite = spritesSecond[8];
        }
        else if (word == words[9])
        {
            firstImage.sprite = spritesFirst[9];
            secondImage.sprite = spritesSecond[9];
        }
        else if (word == words[10])
        {
            firstImage.sprite = spritesFirst[10];
            secondImage.sprite = spritesSecond[10];
        }
        else if (word == words[11])
        {
            firstImage.sprite = spritesFirst[11];
            secondImage.sprite = spritesSecond[11];
        }
        else if (word == words[12])
        {
            firstImage.sprite = spritesFirst[12];
            secondImage.sprite = spritesSecond[12];
        }
        else if (word == words[13])
        {
            firstImage.sprite = spritesFirst[13];
            secondImage.sprite = spritesSecond[13];
        }
        else if (word == words[14])
        {
            firstImage.sprite = spritesFirst[14];
            secondImage.sprite = spritesSecond[14];
        }
        else if (word == words[15])
        {
            firstImage.sprite = spritesFirst[15];
            secondImage.sprite = spritesSecond[15];
        }
    }
    #endregion

    #region Read first and second input
    public void ReadFirstInput(string firstString)
    {
        inputFirst = firstString;
    }

    public void ReadSecondInput(string secondString)
    {
        inputSecond = secondString;
    }
    #endregion

    #region Check answers inputs
    public void CheckBtn()
    {
        if (inputFirst != "" && inputSecond != "")
        {
            if ((inputFirst == "il" || inputFirst == "IL" && inputSecond == "i" || inputSecond == "I") ||
            (inputFirst == "la" || inputFirst == "LA" && inputSecond == "le" || inputSecond == "LE") ||
            (inputFirst == "lo" || inputFirst == "LO" && inputSecond == "gli" || inputSecond == "GLI") ||
            (inputFirst == "l'" || inputFirst == "L'" && inputSecond == "gli" || inputSecond == "GLI") ||
            (inputFirst == "l'" || inputFirst == "L'" && inputSecond == "l'" || inputSecond == "L'"))
            {
                audioSource.PlayOneShot(audioClips[0]);
                RandomWords();
                firstInput.text = "";
                secondInput.text = "";
            }
            else
            {
                audioSource.PlayOneShot(audioClips[1]);
                firstInput.text = "";
                secondInput.text = "";
            }
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
    #endregion

    #region Buttons Return, Next, Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(30);
    }
    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
