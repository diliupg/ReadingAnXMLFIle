using System;
using System.Collections.Generic;
using System.Xml;

namespace ReadXMLfromFile
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static bool addToFile = false;
        static List<List<string>> imageData = new List<List<string>>();

        static void Main()
        {
            XmlReader xmlReader = XmlReader.Create("D:/C#/GameAssets/Images/alienExplode/images/alienExplode.xml");
            while (xmlReader.Read())
            {
                List<string> tempData = new List<string>();

                while (xmlReader.MoveToNextAttribute())
                {
                    Console.Write(xmlReader.Value + " ");
                    tempData.Add(xmlReader.Value);
                    Console.WriteLine("-----------------------------> adding data to tempList " + tempData.Count);
                    addToFile = true; // get ready to write
                }

                if (addToFile)
                {
                    Console.WriteLine("adding tempList to Mainlist");
                    imageData.Add(tempData);
                    Console.WriteLine("----------------------------> imagedata " + imageData.Count);

                    addToFile = false;
                }
            }

            Console.WriteLine(imageData.Count);

            for (int i = 1; i <= imageData.Count - 1; i++) // avoiding the first entry as it is the file name
            {
                for (int x = 0; x < imageData[i].Count; x++)
                {
                    Console.WriteLine(imageData[i][x]);
                }
            }
            Console.ReadKey(); // wait fo keyboard input to exit
        }
    }
}
