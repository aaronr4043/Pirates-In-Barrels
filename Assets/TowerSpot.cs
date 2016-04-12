using UnityEngine;
using System.Collections;

public class TowerSpot : MonoBehaviour {

	void OnMouseUp()
    {
        Debug.Log("TowerSpot clicked.");

        BuildingManager bm = GameObject.FindObjectOfType<BuildingManager>();

        if(bm.selectedTower != null)
        {
            ScoreMoney sm = GameObject.FindObjectOfType<ScoreMoney> ();
			if (sm.money < bm.selectedTower.GetComponent<CannonBehaviour>().cost)
			{
                Debug.Log("TowerSpadsdasd");
                return;
			}

			sm.money -= bm.selectedTower.GetComponent<CannonBehaviour>().cost;

            Instantiate(bm.selectedTower, transform.parent.position, transform.parent.rotation);
            Destroy(transform.parent.gameObject);
        }
    }
}
