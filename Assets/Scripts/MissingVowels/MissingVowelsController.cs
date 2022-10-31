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
    public Sprite airport;
    public Sprite bus;
    public Sprite museum;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "LEONE", "FUOCO", "CUORE", "RUOTA", "FIOCCO", "PIATTO", "PIEDI", "VIOLA", "ZAINO",
                               "PIANTA", "PIOGGIA", "CUOCO", "AEREO", "AEROPORTO", "AUTO", "FIORE", "MIELE", "AUTOBUS", "MUSEO"};
    private string word;

    private bool firstBtn;
    private bool secondBtn;
    private bool thirdBtn;
    private bool fourthBtn;
    private bool fifthBtn;
    private bool sixthBtn;
    private bool seventBtn;
    private bool eighthBtn;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        #region Check words
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
        else if (word == "AEREOPORTO")
        {
            text.text = "__REOPORTO";
            images.sprite = airport;
        }
        else if (word == "AUTO")
        {
            text.text = "__TO";
            images.sprite = car;
        }
        else if (word == "AUTOBUS")
        {
            text.text = "__TOBUS";
            images.sprite = bus;
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
        else if (word == "MUSEO")
        {
            text.text = "MUS__";
            images.sprite = museum;
        }
        #endregion

        #region Check bool
        if (word == "LEONE" || word == "MUSEO")
        {
            firstBtn = true;

            secondBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "PIOGGIA" || word == "FIOCCO" || word == "VIOLA")
        {
            secondBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "FUOCO" || word == "CUORE" || word == "RUOTA" || word == "CUOCO")
        {
            thirdBtn = true;

            firstBtn = false;
            secondBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "PIEDI" || word == "MIELE")
        {
            fourthBtn = true;

            firstBtn = false;
            thirdBtn = false;
            secondBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "PIATTO" || word == "PIANTA")
        {
            fifthBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            secondBtn = false;
            sixthBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "ZAINO")
        {
            sixthBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            secondBtn = false;
            seventBtn = false;
            eighthBtn = false;
        }
        else if (word == "AEREO" || word == "AEROPORTO")
        {
            seventBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            secondBtn = false;
            eighthBtn = false;
        }
        else if (word == "AUTO" || word == "AUTOBUS")
        {
            eighthBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
            sixthBtn = false;
            seventBtn = false;
            secondBtn = false;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (firstBtn)
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
        if (secondBtn)
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
        if (thirdBtn)
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
        if (fourthBtn)
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
        if (fifthBtn)
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
        if (sixthBtn)
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
        if (seventBtn)
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
        if (eighthBtn)
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
