using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuOrCuSecondController1 : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClip;

    public Text firstBtntxt;
    public Text secondBtntxt;

    private string[] words = { "CUOCO","SCUOLA", "CULLA", "CUFFIA", "CUSCINO", "CUCCIOLO","CUGINO","CUOCERE", "CUOIO","CUMINIOLO","CUCINARE", "CUCINA", //0-11
                               "QUA", "QUERCE", "QUADRO","QUATTRO","ACQUARIO", "SQUALO", "SQUADRE", "AQUILA","QUADRATO","ACQUA","SQUADRATO","PASQUA"}; //12-23
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingButtonsTxt();

    }

    #region Random words and assing buttons text
    private void RandomWordsAndAssingButtonsTxt()
    {
        word = words[Random.Range(0, words.Length)];
        
        if (word == words[0])
        {
            firstBtntxt.text = "CUOCO";
            secondBtntxt.text = "QUOCO";
        }
        else if(word == words[1])
        {
            firstBtntxt.text = "SQUOLA";
            secondBtntxt.text = "SCUOLA";
        }
        else if (word == words[2])
        {
            firstBtntxt.text = "CULLA";
            secondBtntxt.text = "QULLA";
        }
        else if (word == words[3])
        {
            firstBtntxt.text = "QUFFIA";
            secondBtntxt.text = "CUFFIA";
        }
        else if (word == words[4])
        {
            firstBtntxt.text = "CUSCINO";
            secondBtntxt.text = "QUSCINO";
        }
        else if (word == words[5])
        {
            firstBtntxt.text = "QUCCIOLO";
            secondBtntxt.text = "CUCCIOLO";
        }
        else if (word == words[6])
        {
            firstBtntxt.text = "CUGINO";
            secondBtntxt.text = "QUGINO";
        }
        else if (word == words[7])
        {
            firstBtntxt.text = "QUOCERE";
            secondBtntxt.text = "CUOCERE";
        }
        else if (word == words[8])
        {
            firstBtntxt.text = "CUOIO";
            secondBtntxt.text = "QUOIO";
        }
        else if (word == words[9])
        {
            firstBtntxt.text = "QUMINIOLO";
            secondBtntxt.text = "CUMINIOLO";
        }
        else if (word == words[10])
        {
            firstBtntxt.text = "CUCINARE";
            secondBtntxt.text = "QUCINARE";
        }
        else if (word == words[11])
        {
            firstBtntxt.text = "QUCINA";
            secondBtntxt.text = "CUCINA";
        }
        else if (word == words[12])
        {
            firstBtntxt.text = "QUA";
            secondBtntxt.text = "CUA";
        }
        else if (word == words[13])
        {
            firstBtntxt.text = "CUERCE";
            secondBtntxt.text = "QUERCE";
        }
        else if (word == words[14])
        {
            firstBtntxt.text = "QUADRO";
            secondBtntxt.text = "CUADRO";
        }
        else if (word == words[15])
        {
            firstBtntxt.text = "CUATTRO";
            secondBtntxt.text = "QUATTRO";
        }
        else if (word == words[16])
        {
            firstBtntxt.text = "ACQUARIO";
            secondBtntxt.text = "ACCUARIO";
        }
        else if (word == words[17])
        {
            firstBtntxt.text = "SCUALO";
            secondBtntxt.text = "SQUALO";
        }
        else if (word == words[18])
        {
            firstBtntxt.text = "SQUADRE";
            secondBtntxt.text = "SCUADRE";
        }
        else if (word == words[19])
        {
            firstBtntxt.text = "ACUILA";
            secondBtntxt.text = "AQUILA";
        }
        else if (word == words[20])
        {
            firstBtntxt.text = "QUADRATO";
            secondBtntxt.text = "CUADRATO";
        }
        else if (word == words[21])
        {
            firstBtntxt.text = "ACCUA";
            secondBtntxt.text = "ACQUA";
        }
        else if (word == words[22])
        {
            firstBtntxt.text = "SQUADRATO";
            secondBtntxt.text = "SCUADRATO";
        }
        else if (word == words[23])
        {
            firstBtntxt.text = "PASCUA";
            secondBtntxt.text = "PASQUA";
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {if (word == words[0] || word == words[2] || word == words[4] || word == words[6] || word == words[8] || word == words[10]//0 2 4 6 8 10
             || word == words[12] || word == words[14] || word == words[16] || word == words[18] || word == words[20] || word == words[22])//12 14 16 18 20 22
        
        {
            audioSource.PlayOneShot(audioClip[0]);
            RandomWordsAndAssingButtonsTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClip[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[1] || word == words[3] || word == words[5] || word == words[7] || word == words[9] || word == words[11]//1 3 5 7 9 11
             || word == words[13] || word == words[15] || word == words[17] || word == words[19] || word == words[21] || word == words[23])//13 15 17 19 21 23
        {
            audioSource.PlayOneShot(audioClip[0]);
            RandomWordsAndAssingButtonsTxt();
        }
        else
        {
            audioSource.PlayOneShot(audioClip[1]);
        }
    }
    #endregion

    #region Buttons Return, Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(10);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
