using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    Color tempColour;
    SpriteRenderer sr;

    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }

    // Code for mouse hover
    private void OnMouseEnter()
    {
        sr = transform.GetComponent<SpriteRenderer>();
        tempColour = sr.color;
        sr.color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        sr.color = tempColour;
    }
}
