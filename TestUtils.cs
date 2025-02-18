using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    internal static class TestUtils
    {
        public static Stack<T> Copy<T>(this Stack<T> stack) => new Stack<T>(new Stack<T>(stack));

        public static Queue<T> Copy<T>(this Queue<T> queue) => new Queue<T>(queue);

        public static List<T> Copy<T>(this List<T> list) => new List<T>(list);

        public static void ClearAll<T>(this ICollection<T> collection)
        {
            if (collection != null)
            {
                collection.Clear();
                collection = null;
            }
        }

        public static void ClearAll<T>(this Stack<T> stack)
        {
            if (stack != null)
            {
                stack.Clear();
                stack = null;
            }
        }

        public static void ClearAll<T>(this Queue<T> queue)
        {
            if (queue != null)
            {
                queue.Clear();
                queue = null;
            }
        }

        internal static bool HasSameElementsAtIndeces<T>(this ICollection<T> sourceCollection, ICollection<T> targetCollection)
        {
            bool result = sourceCollection.Count == targetCollection.Count;

            if (result)
            {
                for (int i = 0; i < sourceCollection.Count; i++)
                {
                    result = sourceCollection.ElementAt(i).Equals(targetCollection.ElementAt(i));

                    if (!result)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        internal static bool HasSameElementsAtIndeces<T>(this Stack<T> sourceStack, Stack<T> targetStack)
        {
            bool result = sourceStack.Count == targetStack.Count;

            if (result)
            {
                for (int i = 0; i < sourceStack.Count; i++)
                {
                    result = sourceStack.ElementAt(i).Equals(targetStack.ElementAt(i));

                    if (!result)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        internal static bool HasSameElementsAtIndeces<T>(this Queue<T> sourceQueue, Queue<T> targetQueue)
        {
            bool result = sourceQueue.Count == targetQueue.Count;

            if (result)
            {
                for (int i = 0; i < sourceQueue.Count; i++)
                {
                    result = sourceQueue.ElementAt(i).Equals(targetQueue.ElementAt(i));

                    if (!result)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        internal static bool HasSameElementsAtIndeces<T>(this Stack<T> sourceStack, List<T> targetList)
        {
            bool result = sourceStack.Count == targetList.Count;

            if (result)
            {
                for (int i = 0; i < sourceStack.Count; i++)
                {
                    result = sourceStack.ElementAt(i).Equals(targetList.ElementAt(i));

                    if (!result)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}