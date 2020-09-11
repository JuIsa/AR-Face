
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Head_Control : MonoBehaviour
{
    public Animator anim;
    public GameObject btn;
    public Text txt;
    private int count;

    private string show = "Show";
    private string hide = "Hide";

    private void Start()
    {
        count = 0;
    }

    public void btnPressed()
    {
        btn.SetActive(false);
        if (count % 2 == 0)
            HideHead();
        else
            ShowHead();

        count++;
        StartCoroutine(ShowButton());
    }

   

    private void ShowHead()
    {
        txt.text = hide;
        anim.Play("up");
    }

    private void HideHead()
    {
        txt.text = show;
        anim.Play("down");
    }

    IEnumerator ShowButton()
    {
        yield return new WaitForSeconds(2.5f);
        btn.SetActive(true);
    }
}
