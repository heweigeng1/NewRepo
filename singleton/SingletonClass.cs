using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    /// <summary>
    /// c# 超简约 单例 多线程也没有问题
    /// </summary>
    public sealed class SingletonClass
    {
        private SingletonClass() { }
        public static readonly SingletonClass Instance = new SingletonClass();
    }
    /// <summary>
    /// 不加锁单例
    /// </summary>
    public class NoLookSingletonClass
    {
        private static NoLookSingletonClass _instance;
        private NoLookSingletonClass()
        {
        }
        public static NoLookSingletonClass Instance()
        {
            if (_instance == null)
            {
                _instance = new NoLookSingletonClass();
            }
            return _instance;
        }
        public static void Destroy()
        {
            _instance = null;
        }
    }
    public class NosingletonClass
    {
        public Guid id = Guid.NewGuid();
        public void Print()
        {
            Console.WriteLine(id);
        }
    }
    public class LookSingletonClass
    {
        private static readonly object look = new object();
        private static LookSingletonClass _instance = null;
        private LookSingletonClass() { }
        public static LookSingletonClass Instance()
        {
            if (_instance == null)
            {
                lock (look)
                {
                    if (_instance==null)
                    {
                        _instance = new LookSingletonClass();
                    }
                }
            }
            return _instance;
        }
        public static void Destroy()
        {
            _instance = null;
        }
    }
}
