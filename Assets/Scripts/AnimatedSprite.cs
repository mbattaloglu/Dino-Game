using UnityEngine;

public class AnimatedSprite : MonoBehaviour
{
    public Sprite[] sprites;

    private SpriteRenderer spriteRenderer;

    private int frame;

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Animate));
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Animate()
    {
        frame++;

        if (frame >= sprites.Length)
        {
            frame = 0;
        }

        spriteRenderer.sprite = sprites[frame];

        Invoke(nameof(Animate), 1f / GameManager.GetInstance().gameSpeed);
    }
}
