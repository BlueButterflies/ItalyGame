using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ThirdControllesr : MonoBehaviour
{
    #region Vriables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text firstTxt;
    public Text secondTxt;
    public Text thirdTxt;

    private string[] words = { "CEROTTO", "CERVELLO", "CESTO", "CETRIOLO", "CENTO", "CELLULARE", "CERVO", "NOCE",
                               "DOLCE", "CROCE", "RADICE", "CERNIERA", "CINQUE", "CIRCO","CIGNO","CIBO","PULCI",
                               "CILINDRO", "CICOGNA","CINGHIALE","CIPOLLA","BICI","RECINTO"};
    private string word;
    #endregion

    void Start()
    {
        audioSource= GetComponent<AudioSource>();

        RandomWordsAndAssingText();
    }

    #region Rndom and Assing text buttons
    private void RandomWordsAndAssingText()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            firstTxt.text = word;
            secondTxt.text = "CIROTTO";
            thirdTxt.text = "CERROTTO";
        }
        else if (word == words[1])
        {
            firstTxt.text = "CIRVELO";
            secondTxt.text = "CERRVELLO";
            thirdTxt.text = word;
        }
        else if (word == words[2])
        {
            firstTxt.text = "CISSTO";
            secondTxt.text = word;
            thirdTxt.text = "CISTO";
        }
        else if (word == words[3])
        {
            firstTxt.text = word;
            secondTxt.text = "CITRIOLLO";
            thirdTxt.text = "CITRIOLO";
        }
        else if (word == words[4])
        {
            firstTxt.text = "CENNTO";
            secondTxt.text = "CINTO";
            thirdTxt.text = word;
        }
        else if (word == words[5])
        {
            firstTxt.text = "CILULLLARE";
            secondTxt.text = word;
            thirdTxt.text = "CILLULARE";
        }
        else if (word == words[6])
        {
            firstTxt.text = word;
            secondTxt.text = "CERRVO";
            thirdTxt.text = "CIRVO";
        }
        else if (word == words[7])
        {
            firstTxt.text = "NOCCI";
            secondTxt.text = "NOCCE";
            thirdTxt.text = word;
        }
        else if (word == words[8])
        {
            firstTxt.text = "DULCE";
            secondTxt.text = word;
            thirdTxt.text = "DOLCCI";
        }
        else if (word == words[9])
        {
            firstTxt.text = word;
            secondTxt.text = "CROCCE";
            thirdTxt.text = "CRROCI";
        }
        else if (word == words[10])
        {
            firstTxt.text = "RADICCE";
            secondTxt.text = "RADECI";
            thirdTxt.text = word;
        }
        else if (word == words[11])
        {
            firstTxt.text = "CERNIERRA";
            secondTxt.text = word;
            thirdTxt.text = "CIRNIERA";
        }
        else if (word == words[12])
        {
            firstTxt.text = word;
            secondTxt.text = "CINQUI";
            thirdTxt.text = "CENQUE";
        }
        else if (word == words[13])
        {
            firstTxt.text = "CIRCE";
            secondTxt.text = "CERCO";
            thirdTxt.text = word;
        }
        else if (word == words[14])
        {
            firstTxt.text = "CIGNE";
            secondTxt.text = word;
            thirdTxt.text = "CEGNI";
        }
        else if (word == words[15])
        {
            firstTxt.text = word;
            secondTxt.text = "CIBBO";
            thirdTxt.text = "CEBO";
        }
        else if (word == words[16])
        {
            firstTxt.text = "PULCCI";
            secondTxt.text = "PULLCE";
            thirdTxt.text = word;
        }
        else if (word == words[17])
        {
            firstTxt.text = "CELINDRO";
            secondTxt.text = word;
            thirdTxt.text = "CILLINDRO";
        }
        else if (word == words[18])
        {
            firstTxt.text = word;
            secondTxt.text = "CECOGNA";
            thirdTxt.text = "CICOGNE";
        }
        else if (word == words[19])
        {
            firstTxt.text = "CENGHIALLE";
            secondTxt.text = "CINGHILLO";
            thirdTxt.text = word;
        }
        else if (word == words[20])
        {
            firstTxt.text = "CIPPOLLA";
            secondTxt.text = word;
            thirdTxt.text = "CEPOLA";
        }
        else if (word == words[21])
        {
            firstTxt.text = word;
            secondTxt.text = "BECI";
            thirdTxt.text = "BICE";
        }
        else if (word == words[22])
        {
            firstTxt.text = "RECCINTO";
            secondTxt.text = "RICINTO";
            thirdTxt.text = word;
        }

    }
    #endregion
   
    #region Buttons first, second and third
    public void FirstBtn()
    {
        if (word == words[0] || word == words[3] || word == words[6] || word == words[9] || word == words[12]
            || word == words[15] || word == words[18] || word == words[21])
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingText();
        }
        else 
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[2] || word == words[5] || word == words[8] || word == words[11] || word == words[14]
            || word == words[17] || word == words[20] || word == words[21])
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[1] || word == words[4] || word == words[7] || word == words[10] || word == words[13]
            || word == words[16] || word == words[19] || word == words[22])
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomWordsAndAssingText();
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
