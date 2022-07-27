using System;
using System.Diagnostics;

namespace ArtifilinkSharp
{
    public class Neural
    {
        string[] inputted;
        
        public Neural(string[] input, int hiddenLayerCount, bool saveEachGeneration, string location)
        {
            Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Initializing");

            if(input.Length < 2)
            {
                Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Initialization succeeded, but there were some problems: ");
                Console.WriteLine("[Artifilink] <NEURAL NETWORK> - Initialization succeeded, but there were some problems: ");

                Debug.WriteLine("Not enough input data. Received number of data: " + input.Length);
                Console.WriteLine("Not enough input data. Received number of data: " + input.Length);
            }
        }

        public void Load()
        {

        }
    }
}
