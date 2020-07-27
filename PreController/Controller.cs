using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalInteractor;

using Newtonsoft.Json.Linq;

namespace PreController
{
    public class Controller : IController
    {
        InputBoundary _iSendInput;
        InputData _inputData;
        public InputBoundary ISendInput
        {
            set
            {
                ISendInput = value;
            }
        }
        public Controller(InputBoundary iSend)
        {
            _iSendInput = iSend;
        }
        internal InputData createInPutData(string[] filenames)
        {
            InputData inputData = new InputData(filenames);
            return inputData;
        }
        public void sendFileNames(string[] filenames)
        {
            //throw new NotImplementedException();
            _inputData = createInPutData(filenames);
            sendFileNamesToInteractor(_inputData);

        }
        internal void sendFileNamesToInteractor(InputData inputData)
        {
            _iSendInput.recieveFileNamesFromController(inputData);
        }

        public void sendIndexesAndFileNamesInJsonToAnalyze(string[] jsonItms)
        {
            //throw new NotImplementedException();
            _inputData = createInPutDataForAna(jsonItms);
            sendInputDataToAnalyze(_inputData);
        }

        private void sendInputDataToAnalyze(InputData inputData)
        {
            //throw new NotImplementedException();
            _iSendInput.recevieAnaFileNamesFromController(inputData);
        }

        internal InputData createInPutDataForAna(string[] jsonItms)
        {
            int[] indexes = new int[jsonItms.Length];
            string[] fileNames = new string[jsonItms.Length];

            int stt = 0;
            foreach (string str in jsonItms)
            {
                JObject itm = JObject.Parse(str);

                if (itm.ContainsKey("index") && itm.ContainsKey("fileName"))
                {
                    indexes[stt] = int.Parse(itm["index"].ToString());
                    fileNames[stt] = itm["fileName"].ToString();
                }
                stt++;


            }
            return new InputData(indexes, fileNames);
        }

        internal InputData createInPutDataForEdt(string[] jsonItms)
        {
            int[] indexes = new int[jsonItms.Length];
            string[] fileNames = new string[jsonItms.Length];

            int stt = 0;
            foreach (string str in jsonItms)
            {
                JObject itm = JObject.Parse(str);

                if (itm.ContainsKey("index") && itm.ContainsKey("fileName"))
                {
                    indexes[stt] = int.Parse(itm["index"].ToString());
                    fileNames[stt] = itm["fileName"].ToString();
                }
                stt++;


            }
            return new InputData(indexes, fileNames);
        }

        public void sendIndexesAndFileNamesInJsonToEdit(string[] items)
        {
            //throw new NotImplementedException();
            _inputData = createInPutDataForEdt(items);
            sendInputDataToEdit(_inputData);
        }

        private void sendInputDataToEdit(InputData inputData)
        {
            //throw new NotImplementedException();
            _iSendInput.recevieEdtFileNamesFromController(inputData);
        }

        public void sendIndexesAndFileNamesInJsonToOpen(string[] vs)
        {
            _inputData = createInPutDataForEdt(vs);
            sendInputDataToOpen(_inputData);
            //throw new NotImplementedException();
        }

        private void sendInputDataToOpen(InputData inputData)
        {
            _iSendInput.recevieOpenFileNamesFromController(inputData);
        }
    }
}
