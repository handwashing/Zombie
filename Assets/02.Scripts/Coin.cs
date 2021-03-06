using Photon.Pun;
using UnityEngine;

public class Coin : MonoBehaviourPun, IItem
{
    public int score = 200; // 증가할 점수

    public void Use(GameObject target){
        // 게임매니저에 접근해 점수 추가
        GameManager.instance.AddScore(score);

        // 사용되었으므로 자신을 파괴
        PhotonNetwork.Destroy(gameObject);
    }
}
