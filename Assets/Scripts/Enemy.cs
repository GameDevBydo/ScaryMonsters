using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Image enemyTimerSlider;
    public int dangerLevelValue = 4, currentStep = 0;

    public float enemyBaseTimer = 5, enemyCurrentTimer;

    public GameObject stepsPositions;
    void Start()
    {
        enemyCurrentTimer = enemyBaseTimer;
    }

    // Update is called once per frame
    void Update()
    {
        CooldownSimples();
        UpdateSlider();
        if(enemyCurrentTimer <=0)
        {
            RollTheDice();
            ResetTimer();
        }
    }

    void CooldownSimples()
    {
        enemyCurrentTimer-= Time.deltaTime;
    }

    void CooldownComPause(bool condition)
    {
        if(condition) CooldownSimples();
    }

    void RollTheDice()
    {
        int roll = Random.Range(1, 21);

        if(roll <= dangerLevelValue)
        {
            currentStep++;
            Debug.Log("ANDOU com " + roll);
            MoveNextStep();
        }
    }

    void MoveNextStep()
    {
        if(currentStep<stepsPositions.transform.childCount)
        transform.position = stepsPositions.transform.GetChild(currentStep-1).position;
    }

    void ResetTimer()
    {
        enemyCurrentTimer = enemyBaseTimer;
    }

    void UpdateSlider()
    {
        enemyTimerSlider.fillAmount = enemyCurrentTimer/enemyBaseTimer;
    }
}
