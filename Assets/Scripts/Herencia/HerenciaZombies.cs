using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HerenciaZombies : MonoBehaviour
{
    protected int life;
    protected int damage;
    protected float speedX;
    public float directionX;
    private Rigidbody2D _compRigidbody;
    public GameManagerControl gameManager;
    private Animator animator;
    private bool isAttacking = false;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, 0);
    }

    public void ReduceLife(int amount)
    {
        life = life - amount;
        if (life <= 0)
        {

            gameManager.UpdatePoints(1);
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Plantas") && !isAttacking)
        {
            animator.SetBool("IsAttacking", true);
            isAttacking = true;
        }
        if (collision.CompareTag("Lose"))
        {
            SceneManager.LoadScene("Lose");
        }
        else
        {
        }
    }

    public void SetGameManager(GameManagerControl gm)
    {
        gameManager = gm;
    }

}
