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
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CASA", "CAVALLO", "CANDELE", "OCA", "FOCA", "CAPPELLO", "CAMALEONTE", "CALZE",
                               "CORDA", "COLLANA", "COLONNA", "CURVA", "CUCCHIAIO", "CUBO"};
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingImages();
    }

    #region Random words and assing texts and images
    private void RandomWordsAndAssingImages()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "__SA";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "__VALLO";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "__NDELE";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "O__";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "FO__";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "__PPELLO";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "__MALEONTE";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "__LZE";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "__RDA";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "__LLANA";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "__LONNA";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "__RVA";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "__CCHIAIO";
            images.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            text.text = "__BO";
            images.sprite = sprites[13];
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[0] || word == words[1] || word == words[2] || word == words[3]
            || word == words[4] || word == words[5] || word == words[6] || word == words[7])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingImages();

        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[8] || word == words[9] || word == words[10])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingImages();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[11] || word == words[12] || word == words[13])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingImages();
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

    public void Next()
    {
        SceneManager.LoadScene(6);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
