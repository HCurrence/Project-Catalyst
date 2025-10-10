using UnityEngine;

public enum BubbleColor
{
    White = 0,
    Green = 1,
    Yellow = 2,
}

public class BubbleBehavior : MonoBehaviour
{
    public BubbleColor bubbleColor;
    public float velocity = 1f;
    

    private MeshRenderer renderer;
    private bool inMotion = false;
    private bool inPlay = false;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        switch(bubbleColor)
        {
            case BubbleColor.White:
                renderer.material = renderer.materials[0];
                break;
            case BubbleColor.Green:
                renderer.material = renderer.materials[1];
                break;
            case BubbleColor.Yellow:
                renderer.material = renderer.materials[2];
                break;
        }
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        if(inMotion)
        {
            Vector3 movement = new Vector3(
                transform.forward.x,
                transform.forward.y,
                0f
            ) * velocity;

            transform.Translate(movement);
        }
    }

    public void ToggleMotion() 
    { 
        inMotion = !inMotion; 
    }

    public void ToggleInPlay()
    {
        inPlay = !inPlay;
    }

    public bool IsMoving() 
    { 
        return inMotion; 
    }

    public bool InPlay()
    {
        return inPlay;
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        BubbleBehavior bubble = collided.GetComponent<BubbleBehavior>();
        if (bubble && bubble.bubbleColor == this.bubbleColor && this.inPlay)
        {
            this.enabled = false;

            if(this.inMotion)
            {
                ToggleMotion();
            }
        }
    }
}
