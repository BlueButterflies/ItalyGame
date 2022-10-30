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
    public Text btnFirst;
    public Text btnSecond;
    public Text btnThird;
    public Text btnFourth;
    public Text btnFive;
    public Text btnSixth;
    public Text btnSeven;
    public Text btnEight;

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

    private bool vocalsEO;
    private bool vocalsIO;
    private bool vocalsUO;
    private bool vocalsAE;
    private bool vocalsIE;
    private bool vocalsIA;
    private bool vocalsAI;
    private bool vocalsAU;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        //Debug.Log(word);

        if (word == "RUOTA")
        {
            text.text = "R__TA";
            images.sprite = tire;
            vocalsUO = true;
        }
        else if (word == "LEONE")
        {
            text.text = "L__NE";
            images.sprite = lion;
            vocalsEO = true;
        }
        else if (word == "FUOCO")
        {
            text.text = "F__CO";
            images.sprite = fire;
            vocalsUO = true;
        }
        else if (word == "ZAINO")
        {
            text.text = "Z__NO";
            images.sprite = schoolBack;
            vocalsAI = true;
        }
        else if (word == "CUORE")
        {
            text.text = "C__RE";
            images.sprite = heart;
            vocalsUO = true;
        }
        else if (word == "FIOCCO")
        {
            text.text = "F__CCO";
            images.sprite = flake;
            vocalsIO = true;
        }
        else if (word == "PIATTO")
        {
            text.text = "P__TTO";
            images.sprite = dish;
            vocalsIA = true;
        }
        else if (word == "VIOLA")
        {
            text.text = "V__LA";
            images.sprite = violet;
            vocalsIO = true;
        }
        else if (word == "PIEDI")
        {
            text.text = "P__DI";
            images.sprite = feet;
            vocalsIE = true;
        }
        else if (word == "PIOGGA")
        {
            text.text = "P__GGA";
            images.sprite = rain;
            vocalsIO = true;
        }
        else if (word == "PIANTA")
        {
            text.text = "P__NTA";
            images.sprite = plant;
            vocalsIA = true;
        }
        else if (word == "CUOCO")
        {
            text.text = "C__CO";
            images.sprite = cook;
            vocalsUO = true;
        }
        else if (word == "AEREO")
        {
            text.text = "__REO";
            images.sprite = air;
            vocalsAE = true;
        }
        else if (word == "AUTO")
        {
            text.text = "__TO";
            images.sprite = car;
            vocalsAU = true;
        }
        else if (word == "FIORE")
        {
            text.text = "F__RE";
            images.sprite = flower;
            vocalsIO = true;
        }
        else if (word == "MIELE")
        {
            text.text = "M__LE";
            images.sprite = honey;
            vocalsIE = true;
        }
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (vocalsEO)
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
        if (vocalsIO)
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
        if (vocalsUO)
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
        if (vocalsIE)
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
        if (vocalsIA)
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
        if (vocalsAI)
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
        if (vocalsAE)
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
        if (vocalsAU)
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
