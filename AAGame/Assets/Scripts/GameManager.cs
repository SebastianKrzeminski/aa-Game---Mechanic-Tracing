using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private bool GameEnded = false;

    public TargetRotator rotator;
    public SpawnPin spawner;

    public Animator animator;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    public void EndGame()
    {
        if (GameEnded) return;
        else GameEnded = true;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetBool("GameEnd", true);

        StartCoroutine(Restart());
    }

    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
