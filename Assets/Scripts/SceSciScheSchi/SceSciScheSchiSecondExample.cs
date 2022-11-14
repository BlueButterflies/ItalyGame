using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceSciScheSchiSecondExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text text;
    public Sprite[] sprites;
    public Image images;

    public InputField input;

    private bool isCorrect;

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
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTextAndImages();
    }

    #region Random images and assing texts and images
    private void RandomWordsAndAssingTextAndImages()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "a__";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "___riffo";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "vi___";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "ru___llo";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "a___nsore";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "mu___rino";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "pe___2";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "___mmia";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "pi___na";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "___arpa";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "___";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "___volo";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "___roppo";
            images.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            text.text = "___are";
            images.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            text.text = "pro___utto";
            images.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            text.text = "ma____";
            images.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            text.text = "mo____";
            images.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            text.text = "____letro";
            images.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            text.text = "pe____";
            images.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            text.text = "____ggia";
            images.sprite = sprites[19];
        }
        else if (word == words[20])
        {
            text.text = "fi____etto";
            images.sprite = sprites[20];
        }
        else if (word == words[21])
        {
            text.text = "____accianoci";
            images.sprite = sprites[21];
        }
        else if (word == words[22])
        {
            text.text = "____ena";
            images.sprite = sprites[22];
        }
        else if (word == words[23])
        {
            text.text = "bo____";
            images.sprite = sprites[23];
        }
    }
    #endregion

    #region Read and control input result

    public void ReadInput(string s)
    {
        inputTxt = s;
    }

    public void ControlInputResult()
    {
        if (inputTxt.Contains(word) || inputTxt.Contains(word.ToUpper()))
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingTextAndImages();

            input.text = "";
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            input.text = "";
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
        SceneManager.LoadScene(14);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
