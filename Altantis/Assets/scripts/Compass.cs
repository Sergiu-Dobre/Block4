using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Compass : MonoBehaviour
{
    public GameObject iconPrefab;
    List<QuestMarker> questMarkers = new List<QuestMarker>();
    List<GameObject> markers = new List<GameObject>();

    public RawImage compassImage;
    public Transform player;

    float compassUnit;

    public QuestMarker one;
    public QuestMarker two;
    public QuestMarker three;

    private int count = 0;

    private void Start()
    {
        compassUnit = compassImage.rectTransform.rect.width / 400f;

        AddQuestMarker(one);
        AddQuestMarker(two);
        AddQuestMarker(three);
    }

    private void Update()
    {
        compassImage.uvRect = new Rect(player.localEulerAngles.y / 360f, 0f, 1f, 1f);

        foreach (QuestMarker marker in questMarkers)
        {
            marker.image.rectTransform.anchoredPosition = GetPosOnCompass(marker);
        }
    }

    public void completeQuest(int questId)
    {
        markers[questId].SetActive(false);
        Debug.Log("test");
       // questMarkers.Remove(questId);
    }

    public void AddQuestMarker(QuestMarker marker)
    {
        marker.setId(count);
        GameObject newMarker = Instantiate(iconPrefab, compassImage.transform);
        marker.image = newMarker.GetComponent<Image>();
        marker.image.sprite = marker.icon;
        newMarker.SetActive(true);
        markers.Add(newMarker);
        questMarkers.Add(marker);
        count++;
    }

    Vector2 GetPosOnCompass(QuestMarker marker)
    {
        Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.z);
        Vector2 playerFwd = new Vector2(player.transform.position.x, player.transform.forward.z);

        float angle = Vector2.SignedAngle(marker.position - playerPos, playerFwd);

        return new Vector2(compassUnit * angle, 0f);
    }

}
