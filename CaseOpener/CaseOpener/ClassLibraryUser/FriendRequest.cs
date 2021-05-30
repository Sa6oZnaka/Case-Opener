using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    [Serializable]
    public class FriendRequest
    {

        private int _senderID;
        private int _receaverID;

        private string _senderName;

        private int _status; // 0 = pending, 1 = accepted

        public FriendRequest(int fromID, int toID, string senderName)
        {
            _senderID = fromID;
            _receaverID = toID;

            _senderName = senderName;

            _status = 0;
        }

        public string Name 
        {
            get
            {
                return _senderName;
            }
            set
            {
                _senderName = value;
            }
        }

        public int getSender()
        {
            return _senderID;
        }

        public int getReceaver()
        {
            return _receaverID;
        }

        public void accept()
        {
            _status = 1;
        }

        public int getStatus()
        {
            return _status;
        }

        public override string ToString()
        {
            return this._senderName;
        }

    }
}
