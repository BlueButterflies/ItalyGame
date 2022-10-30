using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite house;
    public Sprite horse;
    public Sprite candles;
    public Sprite goose;
    public Sprite seaCalf;
    public Sprite hat;
    public Sprite chameleon;
    public Sprite bend;
    public Sprite socks;
    public Sprite tableSpoon;
    public Sprite rope;
    public Sprite column;
    public Sprite necklace;
    public Sprite cube;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CASA", "CAVALLO", "CANDELE", "OCA", "FOCA", "CAPPELLO", "CAMALEONTE", "CALZE",
                               "CORDA", "COLLANA", "COLONNA", "CURVA", "CUCCHIAIO", "CUBO"};
    private string word;

    private bool CA;
    private bool CO;
    private bool CU;
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

        if (word == "CASA")
        {
            text.text = "__SA";
            images.sprite = house;
            CA = true;
        }
        else if (word == "CAVALLO")
        {
            text.text = "__VALLO";
            images.sprite = horse;
            CA = true;
        }
        else if (word == "CANDELE")
        {
            text.text = "__NDELE";
            images.sprite = candles;
            CA = true;
        }
        else if (word == "OCA")
        {
            text.text = "O__";
            images.sprite = goose;
            CA = true;
        }
        else if (word == "FOCA")
        {
            text.text = "FO__";
            images.sprite = seaCalf;
            CA = true;
        }
        else if (word == "CAPPELLO")
        {
            text.text = "__PPELLO";
            images.sprite = hat;
            CA = true;
        }
        else if (word == "CAMALEONTE")
        {
            text.text = "__MALEONTE";
            images.sprite = chameleon;
            CA = true;
        }
        else if (word == "CALZE")
        {
            text.text = "__LZE";
            images.sprite = socks;
            CA = true;
        }
        else if (word == "CORDA")
        {
            text.text = "__RDA";
            images.sprite = rope;
            CO = true;
        }
        else if (word == "COLLANA")
        {
            text.text = "__LLANA";
            images.sprite = necklace;
            CO = true;
        }
        else if (word == "COLONNA")
        {
            text.text = "__LONNA";
            images.sprite = column;
            CO = true;
        }
        else if (word == "CURVA")
        {
            text.text = "__RVA";
            images.sprite = bend;
            CU = true;
        }
        else if (word == "CUCCHIAIO")
        {
            text.text = "__CCHIAIO";
            images.sprite = tableSpoon;
            CU = true;
        }
        else if (word == "CUBO")
        {
            text.text = "__BO";
            images.sprite = cube;
            CU = true;
        }
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (CA)
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
        if (CO)
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
        if (CU)
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
        SceneManager.LoadScene(5);
    }
    #endregion
}
