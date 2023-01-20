namespace InterviewCS.Classes
{
    /// <summary>
    /// Create and utilise object with array index notation.
    /// </summary>
    /// <typeparam name="T"></typeparam>    
    public class Indexmate<T>
    {
        private static int initArrayLength = default  ;
        private T[] arr = new T[initArrayLength];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public Indexmate(int arrayLength)
        {
            initArrayLength = arrayLength;
        }

        public Indexmate() { }

        /// <summary>
        /// Returns the length of the attribute arr 'arr'.
        /// </summary>
        public int GetLength { get => arr.Length; } 

        public override string ToString() => $"Indexer can contain {arr.Count()} elements.";

    }
}