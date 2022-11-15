using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissingVowelsController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;
                           
    private string[] words = { "RUOTA","LEONE","FUOCO","ZAINO","CUORE","FIOCCO","PIATTO","VIOLA","PIEDI","PIOGGIA","PIANTA","CUOCO",
                                "AEREO","AEROPORTO","AUTO","AUTOBUS","FIORE","MIELE","MUSEO"};
    private string word;
    #endregion           

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtImage();
    }

    #region Rnadom words and assing txt and image 
    private void RandomWordsAndAssingTxtImage()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "R__TA";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "L__NE";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "F__CO";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "Z__NO";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "C__RE";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "F__CCO";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "P__TTO";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "V__LA";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "P__DI";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "P__GGA";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "P__NTA";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "C__CO";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "__REO";
            images.sprite = sprites[13];
        }
        else if (word == words[13])
        {
            text.text = "__REOPORTO";
            images.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            text.text = "__TO";
            images.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            text.text = "__TOBUS";
            images.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            text.text = "F__RE";
            images.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            text.text = "M__LE";
            images.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            text.text = "MUS__";
            images.sprite = sprites[18];
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[1] || word == words[18])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();

        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[9] || word == words[5] || word == words[7])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[2] || word == words[4] || word == words[0] || word == words[11])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (word == words[8] || word == words[17])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FifthBtn()
    {
        if (word == words[7] || word == words[10])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SixthBtn()
    {
        if (word == words[3])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SeventhBtn()
    {
        if (word == words[12] || word == words[13])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void EighthBtn()
    {
        if (word == words[14] || word == words[15])
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

    #region Buttons Return, Exit, Next
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Next()
    {
        SceneManager.LoadScene(2);
    }
    #endregion
}
