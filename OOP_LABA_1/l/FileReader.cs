﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace l
{
    class FileReader
    {
        private string pathRead = @"d:\text.txt";
        private string pathWrite = @"d:\result.txt";
        public FileReader()
        {
            if(!File.Exists(pathRead))
            {
                File.Create(pathRead);
            }
        }
        public void Reader(Controller cont)
        {
            StreamReader stream = new StreamReader(pathRead);
            string bufferString;
            string[] parts;
            try
            {
                while ((bufferString = stream.ReadLine()) != null)
                {
                    parts = bufferString.Split(';');
                    string[] stringMass = parts[2].Split(' ');
                    if (parts[0] == "matrix")
                    {
                        int size = (int)Math.Sqrt(stringMass.Length);
                        int[,] intMass = new int[size, size];
                        int iterator = 0;
                        try {
                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < size; j++, iterator++)
                                    intMass[i, j] = Convert.ToInt32(stringMass[iterator]);
                            }
                            Log.ToLog(DateTime.Now.ToString(), "matrix created", "success");
                            cont.Add(new Matrix(parts[1], intMass));
                        }
                        catch(Exception e)
                        {
                            Log.ToLog(DateTime.Now.ToString(), "matrix created", "failed");
                            Console.Write(e.ToString());
                        }
                    }
                    else if (parts[0] == "vector")
                    {
                        try {
                            int size = (int)(stringMass.Length);
                            int[] intMass = new int[size];
                            for (int i = 0; i < size; i++)
                                intMass[i] = Convert.ToInt32(stringMass[i]);
                            cont.Add(new Vector(parts[1], intMass));
                            Log.ToLog(DateTime.Now.ToString(), "vector created", "success");
                        }
                        catch (Exception e)
                        {
                            Log.ToLog(DateTime.Now.ToString(), "matrix created", "failed");
                            Console.Write(e.ToString());
                        }
                    }
                }
            }
            finally
            {
                stream.Close();
            }
        }
        public void Writer(Controller cont)
        {
            StreamWriter stream = new StreamWriter(pathWrite);
            Base firstAct = Controller.Mult(cont["A"], cont["B"]);
            Base secondAct = Controller.Sub(firstAct, cont["C"]);
            Base thirdAct = Controller.Mult(cont["Y"], 4);
            Base fourthAct = Controller.Add(thirdAct, cont["X"]);
            Base final = Controller.Combine(secondAct, fourthAct);
            try
            {
                string Result = string.Format("Result:\n {0} : {1}", final.Name, final.ReturnString());
                stream.Write(Result);
            }
            finally
            {
                stream.Close();
            }

        }

            
    }
}