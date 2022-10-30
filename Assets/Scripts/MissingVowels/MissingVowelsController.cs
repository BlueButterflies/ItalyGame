using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissingVowelsController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite lion;
    public Sprite fire;
    public Sprite tire;
    public Sprite heart;
    public Sprite flake;
    public Sprite dish;
    public Sprite feet;
    public Sprite violet;
    public Sprite schoolBack;
    public Sprite plant;
    public Sprite rain;
    public Sprite cook;
    public Sprite honey;
    public Sprite car;
    public Sprite air;
    public Sprite flower;


    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "LEONE", "FUOCO", "CUORE", "RUOTA", "FIOCCO", "PIATTO", "PIEDI", "VIOLA", "ZAINO",
                               "PIANTA", "PIOGGIA", "CUOCO", "AEREO", "AUTO", "FIORE", "MIELE"};
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        Debug.Log(word);

        if (word == "RUOTA")
        {
            text.text = "R__TA";
            images.sprite = tire;
        }
        else if (word == "LEONE")
        {
            text.text = "L__NE";
            images.sprite = lion;
        }
        else if (word == "FUOCO")
        {
            text.text = "F__CO";
            images.sprite = fire;
        }
        else if (word == "ZAINO")
        {
            text.text = "Z__NO";
            images.sprite = schoolBack;
        }
        else if (word == "CUORE")
        {
            text.text = "C__RE";
            images.sprite = heart;
        }
        else if (word == "FIOCCO")
        {
            text.text = "F__CCO";
            images.sprite = flake;
        }
        else if (word == "PIATTO")
        {
            text.text = "P__TTO";
            images.sprite = dish;
        }
        else if (word == "VIOLA")
        {
            text.text = "V__LA";
            images.sprite = violet;
        }
        else if (word == "PIEDI")
        {
            text.text = "P__DI";
            images.sprite = feet;
        }
        else if (word == "PIOGGA")
        {
            text.text = "P__GGA";
            images.sprite = rain;
        }
        else if (word == "PIANTA")
        {
            text.text = "P__NTA";
            images.sprite = plant;
        }
        else if (word == "CUOCO")
        {
            text.text = "C__CO";
            images.sprite = cook;
        }
        else if (word == "AEREO")
        {
            text.text = "__REO";
            images.sprite = air;
        }
        else if (word == "AUTO")
        {
            text.text = "__TO";
            images.sprite = car;
        }
        else if (word == "FIORE")
        {
            text.text = "F__RE";
            images.sprite = flower;
        }
        else if (word == "MIELE")
        {
            text.text = "M__LE";
            images.sprite = honey;
        }
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == "LEONE")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();

        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == "PIOGGIA" || word == "FIOCCO" || word == "VIOLA")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == "FUOCO" || word == "CUORE" || word == "RUOTA" || word == "CUOCO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (word == "PIEDE")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FifthBtn()
    {
        if (word == "PIATTO" || word == "PIANTA")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SixthBtn()
    {
        if (word == "ZAINO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SeventhBtn()
    {
        if (word == "AEREO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void EighthBtn()
    {
        if (word == "AUTO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
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
        SceneManager.LoadScene(0);
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
