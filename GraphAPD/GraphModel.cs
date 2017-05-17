using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace GraphAPD
{

    public class GraphModel
    {
        private ArrayList graphRecords;
        private GraphController theController;
        BinaryFormatter binFor = new BinaryFormatter();
        FileInfo finfo;
        public ArrayList GraphList
        {
            get
            {
                return graphRecords;
            }
        }

        public GraphModel(GraphController aController)
		{
            graphRecords = new ArrayList();
			theController = aController;
		}

        public void AddRecord(Line newRecord) 
        {
            graphRecords.Add(newRecord);
            UpdateViews();
        }

        public void AddFromFile(Object openRecord) // 
        {
            graphRecords.Add(openRecord);
            UpdateViews();
        }

        public void UpdateRecord(Line Record,int index) 
        {
            graphRecords[index] = Record;              // Updating updating that record with a new data
            UpdateViews();
        }

        public void DeleteRecord(int index)
        {
            graphRecords.RemoveAt(index);
            UpdateViews();
        }

        public void ClearAll()
        {
            graphRecords.Clear();
            UpdateViews();
        }

        public void UpdateViews()
        {
            theController.UpdateViews();
        }

        public void fileInfoForSave(FileInfo fi)  // need the file info inorder to save data through the thread. This initiates the global finfo object 
        {
            finfo = fi;
        }

        public void Save()
        {
                Stream strm;
                strm = finfo.Open(FileMode.Create, FileAccess.ReadWrite);
                Line[] LineRecords = (Line[])this.GraphList.ToArray(typeof(Line)); // Converting the Arraylisit in gModel to an array
                foreach (Line l in LineRecords)
                {
                    binFor.Serialize(strm, l); // Serialize each record 
                }
                strm.Close();
        }

        public string beginSaveThread(FileInfo fi) // Saving works through a thread 
        {
            try
            {
                fileInfoForSave( fi);
                Thread aWorker = new Thread(new ThreadStart(Save));
                aWorker.IsBackground = true;
                aWorker.Start();
                return "true";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
