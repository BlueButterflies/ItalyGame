using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceSciScheSchiThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text text;
    public InputField input;
    public Sprite[] sprites;
    public Image image;

    private string[] words =
   {
        "asce", "sceriffo", "visce", "ruscello", "ascensore", "muscerino",//0-5
        "pesci", "scimmia", "piscina", "sciarpa", "sci", "scivolo", "sciroppo", "sciare", "prosciutto",//6-14
        "masche", "mosche", "scheletro", "pesche", "scheggia",//15-19
        "fischietto", "schiaccianoci", "schiena", "boschi"//20-23
    };

    private string word;
    private string inputTxt;
    #endregion

    public void Start()
    {
        audioSource= GetComponent<AudioSource>();

        RandomWords();
        AssingTextAndImages();
    }

    private void RandomWords()
    {
        word = words[Random.Range(0, words.Length)];
    }

    #region Random images and assing text
    private void AssingTextAndImages()
    {
        image.sprite = sprites[Random.Range(0, sprites.Length)];

        if (word == words[0])
        {
            image.sprite = sprites[0];
            text.text = "ecas";//asce
        }
        else if (word == words[1])
        {
            image.sprite = sprites[1];
            text.text = "riescoff";//sceriffo
        }
        else if (word == words[2])
        {
            image.sprite = sprites[2];
            text.text = "esicv";//visce
        }
        else if (word == words[3])
        {
            image.sprite = sprites[3];
            text.text = "llocseru";//ruscello
        }
        else if (word == words[4])
        {
            image.sprite = sprites[4];
            text.text = "anoresesce";//ascensore
        }
        else if (word == words[5])
        {
            image.sprite = sprites[5];
            text.text = "murisceno";//muscerino
        }
        else if (word == words[6])
        {
            image.sprite = sprites[6];
            text.text = "csipe";//pesci
        }
        else if (word == words[7])
        {
            image.sprite = sprites[7];
            text.text = "miamsci";//scimmia
        }
        else if (word == words[8])
        {
            image.sprite = sprites[8];
            text.text = "pinacis";//piscina
        }
        else if (word == words[9])
        {
            image.sprite = sprites[9];
            text.text = "rpascia";//sciarpa
        }
        else if (word == words[10])
        {
            image.sprite = sprites[10];
            text.text = "ics";//sci
        }
        else if (word == words[11])
        {
            image.sprite = sprites[11];
            text.text = "voisclo";//scivolo
        }
        else if (word == words[12])
        {
            image.sprite = sprites[12];
            text.text = "opopcsir";//sciroppo
        }
        else if (word == words[13])
        {
            image.sprite = sprites[13];
            text.text = "airesc";//sciare
        }
        else if (word == words[14])
        {
            image.sprite = sprites[14];
            text.text = "uttocspiro";//prosciutto
        }
        else if (word == words[15])
        {
            image.sprite = sprites[15];
            text.text = "csehma";//masche
        }
        else if (word == words[16])
        {
            image.sprite = sprites[16];
            text.text = "mehcso";//mosche
        }
        else if (word == words[17])
        {
            image.sprite = sprites[17];
            text.text = "trolecesh";//scheletro
        }
        else if (word == words[18])
        {
            image.sprite = sprites[18];
            text.text = "hspece";//pesche
        }
        else if (word == words[19])
        {
            image.sprite = sprites[19];
            text.text = "ggehcias";//scheggia
        }
        else if (word == words[20])
        {
            image.sprite = sprites[20];
            text.text = "fitohiesct";//fischietto
        }
        else if (word == words[21])
        {
            image.sprite = sprites[21];
            text.text = "noccaischaici";//schiaccianoci
        }
        else if (word == words[22])
        {
            image.sprite = sprites[22];
            text.text = "eihcsna";//schiena
        }
        else if (word == words[23])
        {
            image.sprite = sprites[23];
            text.text = "ihcsbo";//boschi
        }
    }
    #endregion

    #region Read and check input
    public void ReadInput(string s)
    {
        inputTxt = s;
    }

    public void CheckInput()
    {
        if (inputTxt.Contains(word) || inputTxt.Contains(word.ToUpper()))
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWords();
            AssingTextAndImages();

            input.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            input.text = "";
        }
    }
    #endregion

    #region Buttons Return and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
