using System.Collections;
using UnityEngine;

namespace MouseStory
{
    public class IdleAnimation : MonoBehaviour
    {
        [field: SerializeField]
        public Animator Animator { get; private set; }

        [field: SerializeField]
        public int ChanceIdleAnimation { get; private set; }

        [field: SerializeField]
        public int TickCheckerSecond { get; private set; }

        private void Start()
        {
            StartCoroutine(CalculateAnimationIdle());
        }

        private IEnumerator CalculateAnimationIdle()
        {
            while (true)
            {
                int randomNumber = Random.Range(0, ChanceIdleAnimation);

                switch (randomNumber)
                {
                    case 0:
                        Animator.SetTrigger("Idle_1");
                        break;
                    case 1:
                        Animator.SetTrigger("Idle_2");
                        break;
                    case 2:
                        Animator.SetTrigger("Idle_3");
                        break;
                    case 3:
                        Animator.SetTrigger("Idle_4");
                        break;
                    default:
                        break;
                }

                yield return new WaitForSeconds(TickCheckerSecond);
            }
        }
    }
}