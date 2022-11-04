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

    private string[] words = { "CUOCO","SCUOLA", "CULLA", "CUFFIA", "CUSCINO", "CUCCIOLO","CUGINO","CUOCERE",
                               "CUOIO","CUMINIOLO","CUCINARE", "CUCINA", "QUA", "QUERCE", "QUADRO","QUATTRO","SQUADRE", 
                                "SQUALO", "ACQUARIO", "AQUILA","QUADRATO","ACQUA","SQUADRATO","PASQUA"};

    private string word;

    private bool boolFirst;
    private bool boolSecond;
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
        if (word == "CUOCO")
        {
            firstBtntxt.text = "CUOCO";
            secondBtntxt.text = "QUOCO";
        }
        else if(word == "SCUOLA")
        {
            firstBtntxt.text = "SQUOLA";
            secondBtntxt.text = "SCUOLA";
        }
        else if (word == "CULLA")
        {
            firstBtntxt.text = "CULLA";
            secondBtntxt.text = "QULLA";
        }
        else if (word == "CUFFIA")
        {
            firstBtntxt.text = "QUFFIA";
            secondBtntxt.text = "CUFFIA";
        }
        else if (word == "CUSCINO")
        {
            firstBtntxt.text = "CUSCINO";
            secondBtntxt.text = "QUSCINO";
        }
        else if (word == "CUCCIOLO")
        {
            firstBtntxt.text = "QUCCIOLO";
            secondBtntxt.text = "CUCCIOLO";
        }
        else if (word == "CUGINO")
        {
            firstBtntxt.text = "CUGINO";
            secondBtntxt.text = "QUGINO";
        }
        else if (word == "CUOCERE")
        {
            firstBtntxt.text = "QUOCERE";
            secondBtntxt.text = "CUOCERE";
        }
        else if (word == "CUOIO")
        {
            firstBtntxt.text = "CUOIO";
            secondBtntxt.text = "QUOIO";
        }
        else if (word == "CUMINIOLO")
        {
            firstBtntxt.text = "QUMINIOLO";
            secondBtntxt.text = "CUMINIOLO";
        }
        else if (word == "CUCINARE")
        {
            firstBtntxt.text = "CUCINARE";
            secondBtntxt.text = "QUCINARE";
        }
        else if (word == "CUCINA")
        {
            firstBtntxt.text = "QUCINA";
            secondBtntxt.text = "CUCINA";
        }
        else if (word == "QUA")
        {
            firstBtntxt.text = "QUA";
            secondBtntxt.text = "CUA";
        }
        else if (word == "QUERCE")
        {
            firstBtntxt.text = "CUERCE";
            secondBtntxt.text = "QUERCE";
        }
        else if (word == "QUADRO")
        {
            firstBtntxt.text = "QUADRO";
            secondBtntxt.text = "CUADRO";
        }
        else if (word == "QUATTRO")
        {
            firstBtntxt.text = "CUATTRO";
            secondBtntxt.text = "QUATTRO";
        }
        else if (word == "ACQUARIO")
        {
            firstBtntxt.text = "ACQUARIO";
            secondBtntxt.text = "ACCUARIO";
        }
        else if (word == "SQUALO")
        {
            firstBtntxt.text = "SCUALO";
            secondBtntxt.text = "SQUALO";
        }
        else if (word == "SQUADRE")
        {
            firstBtntxt.text = "SQUADRE";
            secondBtntxt.text = "SCUADRE";
        }
        else if (word == "AQUILA")
        {
            firstBtntxt.text = "ACUILA";
            secondBtntxt.text = "AQUILA";
        }
        else if (word == "QUADRATO")
        {
            firstBtntxt.text = "QUADRATO";
            secondBtntxt.text = "CUADRATO";
        }
        else if (word == "ACQUA")
        {
            firstBtntxt.text = "ACCUA";
            secondBtntxt.text = "ACQUA";
        }
        else if (word == "SQUADRATO")
        {
            firstBtntxt.text = "SQUADRATO";
            secondBtntxt.text = "SCUADRATO";
        }
        else if (word == "PASQUA")
        {
            firstBtntxt.text = "PASCUA";
            secondBtntxt.text = "PASQUA";
        }
        #endregion

        #region Check bool
        if (word == "CUOCO" || word == "CULLA" || word == "CUSCINO" || word == "CUGINO" || word == "CUOIO" || word == "CUCINARE"
             || word == "QUA" || word == "QUADRO" || word == "ACQUARIO" || word == "SQUADRE" || word == "QUADRATO" || word == "SQUADRATO")
        {
            boolFirst = true;

            boolSecond = false;
        }
        else if (word == "SCUOLA" || word == "CUFFIA" || word == "CUCCIOLO" || word == "CUOCERE" || word == "CUMINIOLO" || word == "CUCINA"
             || word == "QUERCE" || word == "QUATTRO" || word == "SQUALO" || word == "AQUILA" || word == "ACQUA" || word == "PASQUA")
        {
            boolSecond = true;

            boolFirst = false;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (boolFirst)
        {
            audioSource.PlayOneShot(audioClip[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClip[1]);
        }
    }

    public void SecondBtn()
    {
        if (boolSecond)
        {
            audioSource.PlayOneShot(audioClip[0]);
            Controller();
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

    public void Close()
    {
        Application.Quit();
    }
    #endregion
}
