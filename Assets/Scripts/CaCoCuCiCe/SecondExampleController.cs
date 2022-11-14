using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondExampleController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CEROTTO", "CERVELLO", "CESTO", "CETRIOLO", "CENTO", "CELLULARE", "CERVO", "NOCE",
                               "DOLCE", "CROCE", "RADICE", "CERNIERA", 
                               "CINQUE", "CIRCO","CIGNO","CIBO","PULCI", "CILINDRO", "CICOGNA","CINGHIALE","CIPOLLA","BICI","RECINTO"};
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
            text.text = "__ROTTO";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "__RVELLO";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "__STO";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "__TRIOLO";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "__NTO";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "__LLULARE";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "__RVO";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "NO__";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "DOL__";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "CRO__";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "RADI__";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "__RNIERA";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "__NQUE";
            images.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            text.text = "__RCO";
            images.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            text.text = "__GNO";
            images.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            text.text = "__BO";
            images.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            text.text = "PUL__";
            images.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            text.text = "__LINDRO";
            images.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            text.text = "__COGNA";
            images.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            text.text = "__NGHIALE";
            images.sprite = sprites[19];
        }
        else if (word == words[20])
        {
            text.text = "__POLLA";
            images.sprite = sprites[20];
        }
        else if (word == words[21])
        {
            text.text = "BI__";
            images.sprite = sprites[21];
        }
        else if (word == words[22])
        {
            text.text = "RE__NTO";
            images.sprite = sprites[22];
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[0] || word == words[1] || word == words[2] || word == words[3]
            || word == words[4] || word == words[5] || word == words[6] || word == words[7] || word == words[8]
             || word == words[9] || word == words[10] || word == words[11])
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
        if (word == words[12] || word == words[13] || word == words[14] || word == words[15] || word == words[16]
                 || word == words[17] || word == words[18] || word == words[19] || word == words[20] || word == words[21] || word == words[22])
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

    #region Buttons Return, Next, Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(7);
    }

    public void Exit()
    {
        Application.Quit();
    }


    #endregion
}
