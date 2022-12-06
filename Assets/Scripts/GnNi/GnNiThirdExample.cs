using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnNiThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text firstTxt;
    public Text secondTxt;
    public Text thirdTxt;

    private string[] words = { "SPUGNA", "GNOCCHI", "LAVAGNA", "DISEGNO", "RAGNATELA", "LEGNA", "MONTAGNA", "STAGNO", "GNOMO", "MIGNOLO", "RAGNO", //0-10
                               "MACEDONIA", "GERANIO", "CERNIERA", "PANIERE", "MATRIMONIO", "GONIOMETRO", "PRIGIONIERO", "MINIERA", "MANINE" , "GRANITA", "CARABINIERE" };//11-21
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordAndAssingBtnTxt();
    }

    #region Random words and assing buttons text
    public void RandomWordAndAssingBtnTxt()
    {
        word = words[Random.Range(0, words.Length)];
 
        if (word == words[0])
        {
            firstTxt.text = word;
            secondTxt.text = "SPUNIA";
            thirdTxt.text = "SPOGNA";
        }
        else if (word == words[1])
        {
            firstTxt.text = "GNIOCCHI";
            secondTxt.text = word;
            thirdTxt.text = "NIOCCHI";
        }
        else if (word == words[2])
        {
            firstTxt.text = "LAVANIA";
            secondTxt.text = "LAVANA";
            thirdTxt.text = word;
        }
        else if (word == words[3])
        {
            firstTxt.text = word;
            secondTxt.text = "DESIGNO";
            thirdTxt.text = "DISENIO";
        }
        else if (word == words[4])
        {
            firstTxt.text = "RANATELO";
            secondTxt.text = word;
            thirdTxt.text = "RAGNIATELA";
        }
        else if (word == words[5])
        {
            firstTxt.text = "LENIA";
            secondTxt.text = "LEGNIA";
            thirdTxt.text = word;
        }
        else if (word == words[6])
        {
            firstTxt.text = word;
            secondTxt.text = "MUNTAGNA";
            thirdTxt.text = "MONTANIA";
        }
        else if (word == words[7])
        {
            firstTxt.text = "STANIO";
            secondTxt.text = word;
            thirdTxt.text = "STAGNIO";
        }
        else if (word == words[8])
        {
            firstTxt.text = "GNIOMO";
            secondTxt.text = "NIOMO";
            thirdTxt.text = word;
        }
        else if (word == words[9])
        {
            firstTxt.text = word;
            secondTxt.text = "MINOLO";
            thirdTxt.text = "MINIOLO";
        }
        else if (word == words[10])
        {
            firstTxt.text = "RAGNIO";
            secondTxt.text = word;
            thirdTxt.text = "RANIO";
        }
        else if (word == words[11])
        {
            firstTxt.text = "MACEDOGNA";
            secondTxt.text = "MACEDOGNIA";
            thirdTxt.text = word;
        }
        else if (word == words[12])
        {
            firstTxt.text = word;
            secondTxt.text = "GERAGNIO";
            thirdTxt.text = "GERAGNO";
        }
        else if (word == words[13])
        {
            firstTxt.text = "CERGNERA";
            secondTxt.text = word;
            thirdTxt.text = "CERGNIERA";
        }
        else if (word == words[14])
        {
            firstTxt.text = "PAGNIERE";
            secondTxt.text = "PAGNERE";
            thirdTxt.text = word;
        }
        else if (word == words[15])
        {
            firstTxt.text = word;
            secondTxt.text = "MATRIMOGNO";
            thirdTxt.text = "MATRIMOGNIO";
        }
        else if (word == words[16])
        {
            firstTxt.text = "GOGNIOMETRO";
            secondTxt.text = word;
            thirdTxt.text = "GOGNOMETRO";
        }
        else if (word == words[17])
        {
            firstTxt.text = "PRIGIOGNERO";
            secondTxt.text = "PRIGIOGNIERO";
            thirdTxt.text = word;
        }
        else if (word == words[18])
        {
            firstTxt.text = word;
            secondTxt.text = "MIGNIERA";
            thirdTxt.text = "MIGNERA";
        }
        else if (word == words[19])
        {
            firstTxt.text = "MANINO";
            secondTxt.text = word;
            thirdTxt.text = "MAGNINE";
        }
        else if (word == words[20])
        {
            firstTxt.text = "GRAGNITA";
            secondTxt.text = "GRENITA";
            thirdTxt.text = word;
        }
        else if (word == words[21])
        {
            firstTxt.text = word;
            secondTxt.text = "CARABIGNERE";
            thirdTxt.text = "CARABIGNIERE";
        }
    }
    #endregion

    #region Check correct button
    public void FirstBtn()
    {
        if (firstTxt.text ==  word)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordAndAssingBtnTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (secondTxt.text == word)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordAndAssingBtnTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (thirdTxt.text == word)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordAndAssingBtnTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
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
