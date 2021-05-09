using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    public class FriendRequest
    {

        private int _senderID;
        private int _receaverID;
        private int _status; // 0 = pending, 1 = accepted

        public FriendRequest(int fromID, int toID)
        {
            _senderID = fromID;
            _receaverID = toID;

            _status = 0;
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

    }
}
