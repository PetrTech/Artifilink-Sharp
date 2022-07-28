using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ArtifilinkSharp
{
    public class Neural
    {
        public Action[] inputtedData;
        public HiddenLayer[] hLayers;

        public int generation = 0;

        public int[,,] trainedWeights; // consists of 3 int values: hidden layer number (starting at 0), place in hidden layer (starting at 0, visually top to bottom), best weight
        
        public Neural(Action[] input, int hiddenLayerCount, bool saveEachGeneration, string location)
        {
            Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Initializing");

            if(input.Length < 2)
            {
                Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Initialization succeeded, but there were some problems: ");
                Console.WriteLine("[Artifilink] <NEURAL NETWORK> - Initialization succeeded, but there were some problems: ");

                Debug.WriteLine("Not enough input data. Received number of data: " + input.Length);
                Console.WriteLine("Not enough input data. Received number of data: " + input.Length);

                return;
            }

            List<HiddenLayer> hiddenLayers = new List<HiddenLayer>();

            for (int i = 0; i < hiddenLayerCount; i++)
            {
                hiddenLayers.Add(new HiddenLayer(hiddenLayers.Count + 1, this));
            }
        }

        public void Advance()
        {
            Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Advancing to the next generation! [GEN " + generation.ToString() + "]");

            generation++;
        }

        public Neural Load(string location)
        {
            Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Begin loading from file...");

            if (File.Exists(location)) // exists (wow)
            {
                List<Action> input = new List<Action>();
                List<HiddenLayer> hiddenLayers = new List<HiddenLayer>();

                inputtedData = input.ToArray();
                hLayers = hiddenLayers.ToArray();

                return this; // convert list to array, input hidden layers found in the file
            }
            else
            {
                Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Load failed due to these problems:");
                Console.WriteLine("[Artifilink] <NEURAL NETWORK> - Load failed due to these problems:");

                Debug.WriteLine("File does not exist.");
                Console.WriteLine("File does not exist.");

                return null;
            }
        }
    }

    public class HiddenLayer
    {
        public List<MiddleNeuron> hiddenNeurons = new();
        public Neural AI;

        public HiddenLayer(int hiddenNeuronCount, Neural AI)
        {
            for (int i = 0; i < hiddenNeuronCount; i++)
            {
                hiddenNeurons.Add(new MiddleNeuron(((float)new Random().NextDouble())));
            }
        }
    }

    public class MiddleNeuron
    {
        public float currentWeight = 0;

        public MiddleNeuron(float weight)
        {
            currentWeight = weight;

            // Cap numbers
            if (weight > 1)
            {
                Debug.WriteLine("[Artifilink] <NEURAL NETWORK> *Hidden Neuron* - Weight is bigger than 1, automatically capping number to 1.");
                weight = 1;
            }else if (weight < 0)
            {
                Debug.WriteLine("[Artifilink] <NEURAL NETWORK> *Hidden Neuron* - Weight is smaller than 0, automatically setting number to 0.");
                weight = 0;
            }

            Debug.WriteLine("[Artifilink] <NEURAL NETWORK> - Created hidden neuron");
        }
    }
}
