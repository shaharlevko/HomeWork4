
using UnityEngine;

public class ConvertToSprite : MonoBehaviour {

    public string Tag;
    public Sprite Sprite;

    [ContextMenu("Convert")]
    public void Convert()
    {

        var objects = GameObject.FindGameObjectsWithTag(Tag);

        foreach (var obj in objects)
        {

            DestroyImmediate(obj.GetComponent<MeshFilter>());
            DestroyImmediate(obj.GetComponent<MeshRenderer>());

            float newX = Mathf.Abs(obj.transform.localScale.x);
            float newY = Mathf.Abs(obj.transform.localScale.y);

            
            var sr = obj.AddComponent<SpriteRenderer>();
            sr.sprite = Sprite;
            sr.drawMode = SpriteDrawMode.Tiled;
            sr.size = new Vector2(newX, newY);

            
            obj.GetComponent<BoxCollider2D>().size = new Vector2(newX, newY);



            obj.transform.localScale = Vector3.one;

        }
    }
}

