using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;

public class UI : MonoBehaviour
{
    public CharacterManager player;
    public GameObject UIPanel;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ComboText;


    public Animator animator;
    public bool isPlayer1;

    private void Start()
    {
        StartCoroutine(WaitingForUI());
    }
    private void Update()
    {
        ScoreText.text = player.Score.ToString();
        ComboText.text = player.Combo.ToString();
    }

    public IEnumerator WaitingForUI()
    {
        if(isPlayer1)
        {
            yield return new WaitForSeconds(0.5f);
            UIPanel.SetActive(true);
        }
        else
        {
            UIPanel.SetActive(true);
        }

        yield return new WaitForSeconds(0.1f);
        animator.SetBool("IsStarted", true);
    }
}
