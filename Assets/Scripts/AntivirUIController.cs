using UnityEngine;
using System.Collections;

public class AntivirUIController : MonoBehaviour
{
    public Animator Animator;
    public GameObject SpawnerGO;

    void Update()
    {
       
        Animator.SetFloat("Speed", scoreboard.counter / 900f);
    }

    public void OnStartButtonClicked()
    {

        Animator.SetTrigger("Start");
        StartCoroutine(DelayedStartCoroutine());

    }

    private IEnumerator DelayedStartCoroutine()
    {
        yield return new WaitForSeconds(2f);
        SpawnerGO.SetActive(true);
    }
}
