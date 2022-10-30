using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissingVowelsThirdExample : MonoBehaviour
{
    #region Variables
    public Text text;
    public Text btnFirst;
    public Text btnSecond;
    public Text btnThird;
    public Text btnFourth;
    public Text btnFive;

    public Image images;
    public Sprite goose;
    public Sprite island;
    public Sprite umbrella;
    public Sprite boll;
    public Sprite flowers;
    public Sprite cat;
    public Sprite wing;
    public Sprite funnel;
    public Sprite bee;
    public Sprite candles;
    public Sprite bird;
    public Sprite strawberry;
    public Sprite fungus;
    public Sprite donkey;
    public Sprite igloo;
    public Sprite elf;
    public Sprite hippopotamus;
    public Sprite rainbow;
    public Sprite duck;
    public Sprite clock;
    public Sprite grape;
    public Sprite one;


    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "ALA","OMBRELLO", "FIORI", "GATTO", "UVA", "UNO", "PALLA", "CANDELE", "FUNGHI", "IMBUTO", "ISOLA",
                               "FRAGOLE","APE", "ELFO", "ASINO", "ANATRA", "IPPOPOTAMO", "ARCOBALENO", "OROLOGIO","iglù".ToUpper()};
    private string word;

    private bool vocaleA;
    private bool vocaleI;
    private bool vocaleO;
    private bool vocaleU;
    private bool vocaleE;
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        //Debug.Log(word);

        if (word == "ALA")
        {
            text.text = "_LA";
            images.sprite = wing;
            vocaleA = true;
        }
        else if (word == "OMBRELLO")
        {
            text.text = "_MBRELLO";
            images.sprite = umbrella;
            vocaleO = true;
        }
        else if (word == "FIORI")
        {
            text.text = "FIOR_";
            images.sprite = flowers;
            vocaleI = true;
        }
        else if (word == "GATTO")
        {
            text.text = "GATT_";
            images.sprite = cat;
            vocaleO = true;
        }
        else if (word == "PALLA")
        {
            text.text = "PALL_";
            images.sprite = boll;
            vocaleA = true;
        }
        else if (word == "CANDELE")
        {
            text.text = "CANNDEL_";
            images.sprite = candles;
            vocaleE = true;
        }
        else if (word == "FUNGHI")
        {
            text.text = "FUNGH_";
            images.sprite = fungus;
            vocaleI = true;
        }
        else if (word == "IMBUTO")
        {
            text.text = "_MBUTO";
            images.sprite = funnel;
            vocaleI = true;
        }
        else if (word == "ISOLA")
        {
            text.text = "_SOLA";
            images.sprite = island;
            vocaleI = true;
        }
        else if (word == "FRAGOLE")
        {
            text.text = "FRAGOL_";
            images.sprite = strawberry;
            vocaleE = true;
        }
        else if (word == "APE")
        {
            text.text = "_PE";
            images.sprite = bee;
            vocaleA = true;
        }
        else if (word == "ELFO")
        {
            text.text = "_LFO";
            images.sprite = elf;
            vocaleE = true;
        }
        else if (word == "ASINO")
        {
            text.text = "_SINO";
            images.sprite = donkey;
            vocaleA = true;
        }
        else if (word == "ANATRA")
        {
            text.text = "_NATRA";
            images.sprite = duck;
            vocaleA = true;
        }
        else if (word == "IPPOPOTAMO")
        {
            text.text = "_PPOPOTAMO";
            images.sprite = hippopotamus;
            vocaleI = true;
        }
        else if (word == "ARCOBALENO")
        {
            text.text = "_RCOBALENO";
            images.sprite = rainbow;
            vocaleA = true;
        }
        else if (word == "OROLOGGIO")
        {
            text.text = "_ROLOGGIO";
            images.sprite = clock;
            vocaleO = true;
        }
        else if (word == "iglù".ToUpper())
        {
            text.text = "_glù".ToUpper();
            images.sprite = igloo;
            vocaleI = true;
        }
        else if (word == "UNO")
        {
            text.text = "_NO";
            images.sprite = one;
            vocaleU = true;
        }
        else if (word == "UVA")
        {
            text.text = "_VA";
            images.sprite = grape;
            vocaleU = true;
        }
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (vocaleA)
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
        if (vocaleE)
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
        if (vocaleI)
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
        if (vocaleO)
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
        if (vocaleU)
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

    #region Buttons Return, Exit
    public void Return()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
