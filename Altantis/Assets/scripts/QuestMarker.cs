using UnityEngine;
using UnityEngine.UI;

public class QuestMarker : MonoBehaviour
{
    public Sprite icon;
    public Image image;
    public int idQuest = 0;

    public void setId(int newId)
    {
        idQuest = newId;
    }

    public Vector2 position
    {
        get { return new Vector2(transform.position.x, transform.position.z); }
    }
}