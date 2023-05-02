using System.Collections;
using UnityEngine;

namespace Enemies.Base
{
    public abstract class BaseEnemy : MonoBehaviour
    {
        [SerializeField] protected float attackDamage;
        [SerializeField] protected float attackRadius;
        [SerializeField] protected Transform? attackPosition;
        [SerializeField][Range(0,10)] protected int levelOfEvil;
    
        //public  GameObject?  player { get; protected internal set; }

        public abstract void Flip();
    
        public virtual void Hit(Collider2D col)
        { }

        public abstract IEnumerator StopMove(float time);
    
    }
}