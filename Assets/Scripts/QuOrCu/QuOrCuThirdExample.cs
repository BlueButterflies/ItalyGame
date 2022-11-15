using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuOrCuThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text textWord;
    public InputField inputAnswer;

    private string input;

    private string[] words = { "CUORE", "CUGINO","SCUOTERE","RISCUOTERE","CUBO","CUCCIOLO","INNOCUO",//0-6
                               "CIRCUITO","SCUOLA", "CUSCINO","CUCINA","CUSTODE","CUOCERE", "SCUOLABUS", "CUOIO",//7-14
                               "LIQUIDO","LIQUORE","qualità".ToUpper(),"SQUADRA","QUADERNO","QUADRO","AQUILONE",//15-21
                               "TACQUINO","PASQUA","QUINDICI","QUERCIA", "INQUINARE","TRANQUILLO","SQUARCIAGOLA","QUINTALE"};//22-29
    private string word;
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtWord();
    }

    #region Random words and assing text word
    private void RandomWordsAndAssingTxtWord()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            textWord.text = "__ORE";
        }
        else if (word == words[1])
        {
            textWord.text = "__GINO";
        }
        else if (word == words[2])
        {
            textWord.text = "S__OTERE";
        }
        else if (word == words[3])
        {
            textWord.text = "RIS__OTERE";
        }
        else if (word == words[4])
        {
            textWord.text = "__BO";
        }
        else if (word == words[5])
        {
            textWord.text = "__CCIOLO";
        }
        else if (word == words[6])
        {
            textWord.text = "INNO__O";
        }
        else if (word == words[7])
        {
            textWord.text = "CIR__ITO";
        }
        else if (word == words[8])
        {
            textWord.text = "S__OLA";
        }
        else if (word == words[9])
        {
            textWord.text = "__SCINO";
        }
        else if (word == words[10])
        {
            textWord.text = "__CINA";
        }
        else if (word == words[11])
        {
            textWord.text = "__STODE";
        }
        else if (word == words[12])
        {
            textWord.text = "__OCERE";
        }
        else if (word == words[13])
        {
            textWord.text = "S__OLABUS";
        }
        else if (word == words[14])
        {
            textWord.text = "__OIO";
        }
        else if (word == words[15])
        {
            textWord.text = "LI__IDO";
        }
        else if (word == words[16])
        {
            textWord.text = "LI__ORE";
        }
        else if (word == words[17])
        {
            textWord.text = "__alità".ToUpper();
        }
        else if (word == words[18])
        {
            textWord.text = "S__ADRA";
        }
        else if (word == words[19])
        {
            textWord.text = "__ADERNO";
        }
        else if (word == words[20])
        {
            textWord.text = "__ADRO";
        }
        else if (word == words[21])
        {
            textWord.text = "A__ILONE";
        }
        else if (word == words[22])
        {
            textWord.text = "TAC__INO";
        }
        else if (word == words[23])
        {
            textWord.text = "PAS__A";
        }
        else if (word == words[24])
        {
            textWord.text = "__INDICI";
        }
        else if (word == words[25])
        {
            textWord.text = "__ERCIA";
        }
        else if (word == words[26])
        {
            textWord.text = "INQ__INARE";
        }
        else if (word == words[27])
        {
            textWord.text = "TRAN__ILLO";
        }
        else if (word == words[28])
        {
            textWord.text = "S__ARCIAGOLA";
        }
        else if (word == words[29])
        {
            textWord.text = "__INTALE";
        }
    }
    #endregion

    #region Read and check input answer
    public void ReadInput(string s)
    {
        input =  s;
    }

    public void CheckInputAnswer()
    {
        if (input == word || input == word.ToLower())
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtWord();
            inputAnswer.text = "";
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
