using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    [Serializable]
    public class Offer
    {

        List<Item> _send;
        List<Item> _receave;

        int _senderID,
            _receaverID;

        public List<Item> Send {
            get
            {
                return _send;
            }
            set
            {
                _send = value;
            } 
        }
        public List<Item> Receave {
            get
            {
                return _receave;
            }
            set
            {
                _receave = value;
            }
        }

        public int SenderID
        {
            get
            {
                return _senderID;
            }
            set
            {
                _senderID = value;
            }

        }

        public int ReceaverID
        {
            get
            {
                return _receaverID;
            }
            set
            {
                _receaverID = value;
            }

        }

        public Offer(int senderID, int receaverID, List<Item> send, List<Item> receave)
        {
            _senderID = senderID;
            _receaverID = receaverID;

            _send = send;
            _receave = receave;
        }
        public override string ToString()
        {
            return "Offer";
        }

    }
}
